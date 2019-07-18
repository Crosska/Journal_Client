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

        private string DistrictName = "";

        public DatabaseRegistryArea(string ServerIP_received)
        {
            InitializeComponent();
            ConData.IP = ServerIP_received;
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            datagridtable_streets.RowHeadersVisible = false;
            switch (ConData.IP)
            {
                case "192.168.85.250":
                    DistrictName = "Гвардейский";
                    break;
                case "192.168.82.250":
                    DistrictName = "Горняцкий";
                    break;
                case "192.168.1.250":
                    DistrictName = "Кировский";
                    break;
                case "192.168.87.250":
                    DistrictName = "Советский";
                    break;
                case "192.168.88.250":
                    DistrictName = "Центральный";
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче IP адреса сервера в программу");
                    break;
            }
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
                string SQLCommand = "SELECT \"Улица\" FROM \"Улица\" " +
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "INNER JOIN \"Участок\" ON \"Улица\".\"#Код улицы\" = \"Участок\".\"#Код улицы\" " +
                "WHERE \"Район\" = '" + DistrictName + "' AND \"Дата обхода\" = '" + chosen_date_sql + "' ";
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

        private void Button_add_Click(object sender, EventArgs e)
        {
            DatabaseAddStreet AddStreetForm = new DatabaseAddStreet(datetime_show.Value, DistrictName);
            AddStreetForm.ShowDialog();
        }

        private void RefreshTable(object sender, EventArgs e)
        {
            show_streets_for_date();
        }
    }
}
