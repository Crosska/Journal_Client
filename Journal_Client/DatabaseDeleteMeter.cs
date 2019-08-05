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

namespace Journal_Client
{
    public partial class DatabaseDeleteMeter : Form
    {

        private string DistrictName;
        struct Database
        {
            public string IP;
            public string Port;
            public string DatabaseName;
            public string User;
            public string Password;
        }
        private Database ConData = new Database();

        NpgsqlConnection database;
        NpgsqlCommand cmd;

        public DatabaseDeleteMeter(string IP)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = IP;
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            try
            {
                database = new NpgsqlConnection(conString);
                database.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                database.Close();
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {

        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
