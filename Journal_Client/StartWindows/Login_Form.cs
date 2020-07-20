using Journal_Client.AdminWindows;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Client.StartWindows
{
    public partial class Login_Form : Form
    {
        private NpgsqlCommand cmd;
        private SystemInfoLogger logger = new SystemInfoLogger();

        public Login_Form()
        {
            InitializeComponent();
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if (textbox_login.Text.Length == 0 && textbox_password.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
            }
            else if (textbox_login.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите логин.");
            }
            else if (textbox_password.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите пароль.");
            }
            else
            {
                string connection = "Server=192.168.23.99;Port=5432;UserID=" + textbox_login.Text + ";Password=" + textbox_password.Text + ";Database=postgres;";
                NpgsqlConnection con = new NpgsqlConnection(connection);
                try
                {
                    con.Open();
                    con.Close();
                    string IP = "";
                    if (search_user_post(textbox_login.Text) == 1)
                    {
                        logger.WriteNewDataline(textbox_login.Text, "Вошел в систему, район " + combobox_district.SelectedItem.ToString());
                        WorkerWorkspace main_form = new WorkerWorkspace(textbox_login.Text, combobox_district.SelectedItem.ToString(), this, con);
                        main_form.Show();
                        this.Visible = false;
                    }
                    else if (search_user_post(textbox_login.Text) == 2)
                    {
                        logger.WriteNewDataline(textbox_login.Text, "Вошел в систему ");
                        AdminWorkspace main_form = new AdminWorkspace(con, this);
                        main_form.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка, введите правильные данные.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка, введите правильные данные.");
                }
            }
        }

        private int search_user_post(string login)
        {
            int post = 0;
            DataTable temp_table = new DataTable();
            string connection_root = "Server=192.168.23.99;Port=5432;UserID=user_seeker;Password=userqueryexecute;Database=postgres;";
            NpgsqlConnection con_root = new NpgsqlConnection(connection_root);
            con_root.Open();
            string SQL = "select get_user_type('" + login + "')";
            cmd = new NpgsqlCommand(SQL, con_root);
            temp_table.Load(cmd.ExecuteReader());
            if (temp_table.Rows[0][0].Equals("User"))
            {
                post = 1;
                con_root.Close();
                return post;
            } else if (temp_table.Rows[0][0].Equals("Admin"))
            {
                post = 2;
                con_root.Close();
                return post;
            }
            con_root.Close();
            return post;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            combobox_district.SelectedIndex = 0;
        }
    }
}
