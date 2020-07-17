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
                String connection = "Server=" + get_global_ip() + ";Port=5432;UserID=" + textbox_login.Text + ";Password=" + textbox_password.Text + ";Database=postgres;";
                NpgsqlConnection con = new NpgsqlConnection(connection);
                try
                {
                    con.Open();
                    con.Close();
                    //if (combobox_district.SelectedItem.ToString() != search_user_district()) throw new Exception();
                    String District = search_user_district();
                    String IP = "";
                    if (search_user_post(textbox_login.Text) == 1)
                    {
                        connection = "Server=" + get_global_ip() + ";Port=5432;UserID=" + textbox_login.Text + ";Password=" + textbox_password.Text + ";Database=postgres;";
                        con = new NpgsqlConnection(connection);
                        WorkerWorkspace main_form = new WorkerWorkspace(IP, search_user_district(), this, con);
                        main_form.Show();
                        this.Visible = false;
                    }
                    else if (search_user_post(textbox_login.Text) == 2)
                    {
                        connection = "Server=" + get_global_ip() + ";Port=5432;UserID=" + textbox_login.Text + ";Password=" + textbox_password.Text + ";Database=postgres;";
                        con = new NpgsqlConnection(connection);
                        AdminWorkspace main_form = new AdminWorkspace(con);
                        main_form.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка, введены неправильные данные.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка, введите правильные данные.");
                }
            }
        }

        private string search_user_district()
        {
            String district = "";

            DataTable temp_table = new DataTable();
            String connection_root = "Server=" + get_global_ip() + ";Port=5432;UserID=user_seeker;Password=userqueryexecute;Database=postgres;";

            NpgsqlConnection con_root = new NpgsqlConnection(connection_root);
            con_root.Open();
            String SQL = "select \"Район\" from \"Район\" " +
                "inner join \"Сотрудник\" on \"Район\".\"#Код района\" = \"Сотрудник\".\"#Код_района\" " +
                "where \"Логин\" = '" + textbox_login.Text + "' and \"Сотрудник\".\"#Код_района\" = \"Район\".\"#Код района\"";

            cmd = new NpgsqlCommand(SQL, con_root);
            temp_table.Load(cmd.ExecuteReader());

            try
            {
                district = temp_table.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ваша учетная запись не привязана ни к одному району");
            }

            con_root.Close();
            return district;
        }

        private int search_user_post(string login)
        {
            int post = 0;

            DataTable temp_table = new DataTable();
            String connection_root = "Server=" + get_global_ip() + ";Port=5432;UserID=user_seeker;Password=userqueryexecute;Database=postgres;";

            NpgsqlConnection con_root = new NpgsqlConnection(connection_root);
            con_root.Open();
            String SQL = "select get_user_type('" + login + "')";

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

        private string get_global_ip()
        {
            String IP = "";
            switch (combobox_district.SelectedItem)
            {
                case "Тестовый":
                    IP = "192.168.23.99";
                    break;
                case "Гвардейский":
                    IP = "192.168.85.250";
                    break;
                case "Горняцкий":
                    IP = "192.168.82.250";
                    break;
                case "Кировский":
                    IP = "192.168.1.250";
                    break;
                case "Советский":
                    IP = "192.168.87.250";
                    break;
                case "Центрально-городской":
                    IP = "192.168.88.250";
                    break;
                default:
                    MessageBox.Show("Ошибка при определении IP сервера");
                    this.Close();
                    break;
            }
            return IP;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            combobox_district.SelectedIndex = 0;
        }
    }
}
