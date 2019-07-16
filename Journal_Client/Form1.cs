using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DatabaseConnection : Form
    {

        private struct Server
        {
            internal string IP;
            internal string Port;
            internal string DatabaseName;
            internal void ShowAllInfo()
            {
                MessageBox.Show($"IP: {IP}\nPort: {Port}\nDatabaseName: {DatabaseName}");
            }
        }
        private Server ConData;


        public DatabaseConnection()
        {
            InitializeComponent();
            ConData.IP = "192.168.23.100";
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
        }

        private void Operator_connect_online_Click(object sender, EventArgs e)
        {
            string login = Operator_login_online.Text;
            string password = Operator_password_online.Text;
            MessageBox.Show("Введенный логин = " + login + "\nВведенный пароль = " + password);
        }
    }
}
