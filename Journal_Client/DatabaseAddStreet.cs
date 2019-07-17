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
    public partial class DatabaseAddStreet : Form
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

        private DateTime chosen_date;
        private string DistrictName;

        public DatabaseAddStreet(DateTime chosen_date_received, string DistrictName_received)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            chosen_date = chosen_date_received;
            DistrictName = DistrictName_received;
            date_active.Value = chosen_date;
            string IP = "";
            switch (DistrictName)
            {
                case "Гвардейский":
                    IP = "192.168.85.250"; // Гвардейский
                    getStreets(IP);
                    break;
                case "Горняцкий":
                    IP = "192.168.82.250"; // Горняцкий
                    getStreets(IP);
                    break;
                case "Кировский":
                    IP = "192.168.1.250"; // Кировский
                    getStreets(IP);
                    break;
                case "Советский":
                    IP = "192.168.87.250"; // Советский
                    getStreets(IP);
                    break;
                case "Центральный":
                    IP = "192.168.88.250"; // Центральный
                    getStreets(IP);
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче выбранного сервера в форму добавления");
                    this.Close();
                    break;
            }

        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            string street_code = get_street_code();
            string date_code = get_date_code();
            string conString = "Server=" + /*IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "INSERT INTO \"Участок\" VALUES (" + date_code + ", " + street_code + " )";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                cmd = new NpgsqlCommand(SQLCommand, database);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена.");
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

        private string get_street_code()
        {
            string street_code = "";
            string conString = "Server=" + /*IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                string chosen_street_sql = combobox_streets.SelectedItem.ToString();
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"Улица\".\"#Код улицы\" FROM \"Улица\" " +
                "INNER JOIN \"Участок\" ON \"Улица\".\"#Код улицы\" = \"Участок\".\"#Код улицы\" " +
                "INNER JOIN \"Дата обхода\" ON \"Участок\".\"#Код даты\" = \"Дата обхода\".\"#Код даты\" " +
                "INNER JOIN \"Район\" ON \"Дата обхода\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Улица\" = '" + combobox_streets.SelectedItem.ToString() + "' AND \"Район\" = '" + DistrictName + "' " +
                "GROUP BY \"Улица\".\"#Код улицы\" ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                street_code = temp_table.Rows[0].Field<int>(0).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }
            return street_code;
        }

        private string get_date_code()
        {
            string date_code = "";
            string conString = "Server=" + /*IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                string chosen_street_sql = combobox_streets.SelectedItem.ToString();
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = " SELECT \"Дата обхода\".\"#Код даты\" FROM \"Дата обхода\" " +
                "INNER JOIN \"Район\" ON \"Дата обхода\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Район\" = '" + DistrictName + "' AND \"Дата\" = '" + date_active.Value.ToShortDateString() + "' ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                date_code = temp_table.Rows[0].Field<int>(0).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }
            return date_code;
        }

        private void getStreets(string IP)
        {
            string conString = "";
            conString = "Server=" + /*IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"Улица\" FROM \"Участок\" " +
                    "INNER JOIN \"Улица\" ON \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                    "INNER JOIN \"Дата обхода\" ON \"Участок\".\"#Код даты\" = \"Дата обхода\".\"#Код даты\" " +
                    "INNER JOIN \"Район\" ON \"Дата обхода\".\"#Код района\" = \"Район\".\"#Код района\" " +
                    "WHERE \"Район\" = '" + DistrictName + "' ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_streets = new List<string>(temp_table.Rows.Count);
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        List_streets.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_streets.DataSource = new BindingSource(List_streets, null);
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
