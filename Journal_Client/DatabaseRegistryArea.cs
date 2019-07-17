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
    public partial class DatabaseRegistryArea : Form
    {

        struct Database
        {
            public string IP;
            public string Port;
            public string DatabaseName;
            public string User;
            public string Password;
        }
        private Database ConData = new Database();

        public DatabaseRegistryArea(string ServerIP_received)
        {
            InitializeComponent();
            ConData.IP = ServerIP_received;
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            datagridtable_streets.RowHeadersVisible = false;
            show_streets_for_date();
        }

        private void date_changed(object sender, DateRangeEventArgs e)
        {
            show_streets_for_date();
        }

        private void show_streets_for_date()
        {
            DateTime chosen_date = Calendar.SelectionRange.Start;
            //MessageBox.Show(chosen_date.ToString());
            datetime_show.Value = chosen_date;
            string chosen_date_sql = Calendar.SelectionRange.Start.ToShortDateString();
            string conString = "";
            conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                database.Open();
                string SQLCommand = "SELECT \"Улица\" FROM \"Участок\" " +
                "INNER JOIN \"Улица\" ON \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "INNER JOIN \"Дата обхода\" ON \"Участок\".\"#Код даты\" = \"Дата обхода\".\"#Код даты\" " +
                "WHERE \"Дата обхода\".\"Дата\" = '" + chosen_date_sql + "'";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd;
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable datatable;
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                datagridtable_streets.DataSource = datatable;
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }


        }

    }
}
