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
    public partial class DatabaseInOutJournal : Form
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
        private bool select_in = true;
        private int select_type = 0;

        public DatabaseInOutJournal(String DistrictName_received)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            DistrictName = DistrictName_received;
            switch (DistrictName)
            {
                case "Гвардейский":
                    ConData.IP = "192.168.85.250"; // Гвардейский
                    break;
                case "Горняцкий":
                    ConData.IP = "192.168.82.250"; // Горняцкий
                    break;
                case "Кировский":
                    ConData.IP = "192.168.1.250"; // Кировский
                    break;
                case "Советский":
                    ConData.IP = "192.168.87.250"; // Советский
                    break;
                case "Центральный":
                    ConData.IP = "192.168.88.250"; // Центральный
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче выбранного сервера в форму добавления");
                    this.Close();
                    break;
            }
            datagridview.RowHeadersVisible = false;
            getFIO();
        }

        private void radiobutton_only_date_checked(object sender, EventArgs e)
        {
            calendar.Enabled = true;
            combobox_controller.Enabled = false;
            select_type = 0;
        }

        private void radiobutton_only_controller_checked(object sender, EventArgs e)
        {
            calendar.Enabled = false;
            combobox_controller.Enabled = true;
            select_type = 1;
        }

        private void radiobutton_date_and_controller_checked(object sender, EventArgs e)
        {
            calendar.Enabled = true;
            combobox_controller.Enabled = true;
            select_type = 2;
        }

        private void radiobutton_in_checked(object sender, EventArgs e)
        {
            select_in = true;
        }

        private void radiobutton_out_checked(object sender, EventArgs e)
        {
            select_in = false;
        }

        private void Button_do_select_Click(object sender, EventArgs e)
        {
            switch (select_in)
            {
                case false:
                    string SQLCommand = "select \"Лицевой счет\",\"Улица\",\"Дом\",\"Квартира\",\"Дата обработки\",\"Вид заявки\",\"Показания водомера\",\"№ пломбы\",\"Контроллер\".\"ФИО контролера\" from \"Журнал регистраций заявок\" " +
                    "inner join \"Вид заявки\" on \"Журнал регистраций заявок\".\"#Код вида заявки\" = \"Вид заявки\".\"#Код вида заявки\" " +
                    "inner join \"Журнал ввода/вывода\" on \"Журнал регистраций заявок\".\"#Код заявки\" = \"Журнал ввода/вывода\".\"#Код заявки \" ";
                    make_select(SQLCommand);
                    break;
                case true:
                    SQLCommand = "SELECT \"Лицевой счет\",\"Улица\",\"Дом\",\"Квартира\",\"Дата обработки\",\"Показания водомера\",\"№ пломбы\",\"Контроллер\".\"ФИО контролера\" FROM \"Журнал регистраций заявок\" " +
                    "inner join \"Журнал ввода/вывода\" on \"Журнал регистраций заявок\".\"#Код заявки\" = \"Журнал ввода/вывода\".\"#Код заявки \" ";
                    make_select(SQLCommand);
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при формировании запроса");
                    break;
            }
        }

        private void make_select(string main_sql)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            string sql_rule = "";
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                switch (select_type)
                {
                    case 0:
                        sql_rule = " \ninner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                        "where \"Дата обработки\" = '" + datetime_show.Value.ToString() + "'";
                        break;
                    case 1:
                        sql_rule = "\ninner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                        "where \"Контролер\".\"ФИО контролера\" = '" + combobox_controller.SelectedItem.ToString() + "'";
                        break;
                    case 2:
                        sql_rule = "\ninner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                        "where \"Контролер\".\"ФИО контролера\" = '" + combobox_controller.SelectedItem.ToString() + "' and \"Дата обработки\" = '" + datetime_show.Value.ToString() + "'";
                        break;
                    default:
                        MessageBox.Show("Ошибка на этапе формирования условий запроса");
                        break;
                }
                string SQLCommand = main_sql + sql_rule;
                MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table = new DataTable();
                temp_table.Load(cmd.ExecuteReader());
                datagridview.DataSource = temp_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                database.Close();
            }
            
        }

        private void date_changed(object sender, DateRangeEventArgs e)
        {
            datetime_show.Value = calendar.SelectionStart;
        }

        private void getFIO()
        {
            string conString = "";
            conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {

                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"ФИО контролера\" from \"Контролер\" ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_FIO = new List<string>(temp_table.Rows.Count);
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        List_FIO.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_controller.DataSource = new BindingSource(List_FIO, null);
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
