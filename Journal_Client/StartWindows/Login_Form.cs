using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Client.StartWindows
{
    public partial class Login_Form : Form
    {

        NpgsqlCommand cmd;

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
                if(search_user_post(textbox_login.Text))
                {
                    //MessageBox.Show("Успешно вошли");

                } else
                {
                    //MessageBox.Show("Ошибка входа");
                }
            }
        }

        private bool search_user_post(string login)
        {
            bool exist = false;

            DataTable temp_table = new DataTable();
            String connection_root = "Server=192.168.23.99;Port=5432;UserID=user_seeker;Password=userqueryexecute;Database=postgres;";

            NpgsqlConnection con_root = new NpgsqlConnection(connection_root);
            con_root.Open();
            String SQL = "select get_user_type('" + login + "')";

            cmd = new NpgsqlCommand(SQL, con_root);
            temp_table.Load(cmd.ExecuteReader());

            if (temp_table.Rows[0][0].Equals("User"))
            {
                exist = true;
                con_root.Close();
                return exist;
            }
            
            con_root.Close();
            return exist;
        }

    }
}
