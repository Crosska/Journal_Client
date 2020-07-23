using Journal_Client.DialogWindows;
using Npgsql;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Client.AdminWindows
{
    public partial class AdminWorkspace : Form
    {

        string login;
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        Form previous;

        public AdminWorkspace(NpgsqlConnection con_received, Form previous_received, string login_received)
        {
            InitializeComponent();
            login = login_received;
            con = con_received;
            previous = previous_received;
            refresh_table();
        }

        private void radiobutton_users_checked(object sender, EventArgs e)
        {
            refresh_table();
        }

        private void refresh_table()
        {
            con.Open();
            if(radiobutton_users.Checked)
            {
                datagridview.DataSource = null;
                String SQL = "select * from \"Сотрудник\"";
                cmd = new NpgsqlCommand(SQL, con);
                DataTable temp_table = new DataTable();
                temp_table.Load(cmd.ExecuteReader());
                datagridview.DataSource = temp_table;
            }
            con.Close();
        }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            previous.Visible = true;
        }

        private void button_clear_log_Click(object sender, EventArgs e)
        {
            DialogLogClear dialog = new DialogLogClear();
            dialog.ShowDialog();
        }

        private void button_open_prg_log_Click(object sender, EventArgs e)
        {
            LogViewer window = new LogViewer();
            window.ShowDialog();
        }

        private void button_create_new_Click(object sender, EventArgs e)
        {
            if(textbox_new_login.Text.Length != 0 && textbox_new_password.Text.Length != 0)
            {
                if (radiobutton_user.Checked)
                {
                    string connection_root = "Server=192.168.23.99;Port=5432;UserID=postgres;Password=Qwerty2;Database=postgres;";
                    NpgsqlConnection con = new NpgsqlConnection(connection_root);
                    string SQL = "create user " + textbox_new_login.Text + " with password '" + textbox_new_password.Text + "';" +
        "grant \"User\" to " + textbox_new_login.Text + ";" +
        "insert into \"Сотрудник\" (\"ФИО\",\"Логин\") VALUES('" + richtextbox_fio.Text + "', '" + textbox_new_login.Text + "');";
                    try
                    {
                        con.Open();
                        cmd = new NpgsqlCommand(SQL, con);
                        cmd.Prepare();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Сотрудник успешно создан");
                        SystemInfoLogger logger = new SystemInfoLogger();
                        logger.WriteNewDataline(login, "Создал сотрудника " + textbox_new_login.Text);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Данный логин уже занят.");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    string connection_root = "Server=192.168.23.99;Port=5432;UserID=postgres;Password=Qwerty2;Database=postgres;";
                    NpgsqlConnection con = new NpgsqlConnection(connection_root);
                    string SQL = "create user " + textbox_new_login.Text + " with password '" + textbox_new_password.Text + "';" +
        "grant \"Admin\" to " + textbox_new_login.Text;
                    try
                    {
                        con.Open();
                        cmd = new NpgsqlCommand(SQL, con);
                        cmd.Prepare();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Администратор успешно создан");
                        SystemInfoLogger logger = new SystemInfoLogger();
                        logger.WriteNewDataline(login, "Создал администратора " + textbox_new_login.Text);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Данный логин уже занят.");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            } else if (textbox_new_login.Text.Length == 0 && textbox_new_password.Text.Length != 0)
            {
                MessageBox.Show("Необходимо ввести логин.");
            } else if (textbox_new_login.Text.Length != 0 && textbox_new_password.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести пароль.");
            } else
            {
                MessageBox.Show("Необходимо ввести логин и пароль.");
            }
        }

        private void radiobutton_admin_CheckedChanged(object sender, EventArgs e)
        {
            richtextbox_fio.Enabled = false;
        }

        private void radiobutton_user_CheckedChanged(object sender, EventArgs e)
        {
            richtextbox_fio.Enabled = true;
        }
    }
}
