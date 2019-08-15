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
    public partial class DatabaseRegistryRequest : Form
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

        public DatabaseRegistryRequest(string IP)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = IP;
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
            getStreets();                                                                               // Вызов функции для заполенения выпадающего списка улиц
            getApplicationType();                                                                       // Вызов функции для заполенения выпадающего списка видов заявок
            combobox_processing_date.DataSource = null;                                                 // Очистка поля даты обработки
        }

        private void getApplicationType()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"Вид заявки\" FROM \"Вид заявки\" ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_streets = new List<string>(temp_table.Rows.Count);                    // Создание списка с типом данных string с размеров = кол-ву строк из таблицы с результатами
                foreach (DataRow row in temp_table.Rows)                                                // Цикл на каждую строку из таблицы с результатом запроса
                {
                    try
                    {
                        List_streets.Add(row[0].ToString());                                            // Добавление значения первой ячейки из строки таблицы в список
                    }
                    catch { }
                }
                combobox_type_application.DataSource = new BindingSource(List_streets, null);           // Заполенение выпадающего списка данными из списка List_streets
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

        private void getStreets()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"Улица\" from \"Улица\" " +
                "inner join \"Район\" on \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "where \"Район\" = '" + DistrictName + "' ";
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
                combobox_street.DataSource = new BindingSource(List_streets, null);                     // Заполенение выпадающего списка данными из списка List_streets
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
            bool error = check_all();
            if (!error)
            {
                int district_code = get_district_code();
                int application_type_code = get_application_type_code();
                string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
                NpgsqlConnection database = new NpgsqlConnection(conString);
                try
                {
                    DataTable temp_table = new DataTable();
                    database.Open();
                    string SQLCommand = "INSERT INTO \"Журнал регистраций заявок\" (\"#Код участка\", \"Дата подачи заявки\", \"ФИО потребителя\", \"Улица\", " +
                    "\"Дом\", \"Квартира\", \"Оплата\", \"Лицевой счет\", \"#Код вида заявки\") " +
                    "VALUES(" + district_code + ", '" + datetime_show.Value.ToShortDateString() + "', '" + textbox_fio.Text + "', '" + combobox_street.SelectedItem.ToString() + "'," +
                    " '" + textbox_house.Text + "', '" + textbox_flat.Text + "', '" + numericupdown_payment.Value.ToString().Replace(',', '.') + "' , " + textbox_personal_account.Text + ", " + application_type_code + ")";
                    //MessageBox.Show(SQLCommand);
                    NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                    cmd.Prepare();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена.");
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность вводимых данных");
                }
                finally
                {
                    database.Close();
                }
                date_count_refresh();
            }
        }

        private bool check_all()
        {
            bool error = false;
            try
            {
                int temp = Convert.ToInt32(textbox_fio.Text);
                MessageBox.Show("Проверьте правильность вводимых данных");
                error = true;
            }
            catch
            {
            }
            return error;
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selected_new_date(object sender, DateRangeEventArgs e)
        {
            datetime_show.Value = calendar_application_submission.SelectionRange.Start;                 // Присваивание даты из календаря в элемент с датой
        }

        private void street_changed(object sender, EventArgs e)
        {
            get_dates_walks();                                                                          // Вызов функции для получения дат обхода
        }

        private int get_district_code()                                                                 // Функция для получения кода участка (возвращает код)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            int district_code = -1;
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"#Код участка\" FROM \"Участок\" " +
                "INNER JOIN \"Улица\" ON \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Район\" = '" + DistrictName + "' AND \"Дата обхода\" = '" + combobox_processing_date.SelectedItem.ToString() + "' AND \"Улица\" = '" + combobox_street.SelectedItem.ToString() + "'";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        district_code = Convert.ToInt32(row[0]);
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }
            return district_code;
        }

        private int get_application_type_code()                                                         // Функция для получения кода вида заявки (возвращает код)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            int application_type_code = -1;
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"#Код вида заявки\" FROM \"Вид заявки\" " +
                "WHERE \"Вид заявки\" = '" + combobox_type_application.SelectedItem.ToString() + "' ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        application_type_code = Convert.ToInt32(row[0]);
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }
            return application_type_code;
        }

        private void date_proccessing_changed(object sender, EventArgs e)                               // Действие при изменении даты обработки
        {
            date_count_refresh();                                                                       // Вызов функции обновления количества обходов
        }

        private void date_count_refresh()                                                               // Функция обновления количества обходов
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            int count = 0;
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select count(\"#Код заявки\") from \"Журнал регистраций заявок\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                "inner join \"Улица\" on \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "where \"Дата обхода\" = '" + combobox_processing_date.SelectedValue + "' and \"Журнал регистраций заявок\".\"Улица\" = '" + combobox_street.SelectedValue + "'";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        count = Convert.ToInt32(row[0]);
                    }
                    catch { }
                }
            }
            catch
            {
                count = 0;
            }
            finally
            {
                textview_bypass.Text = count.ToString();
                database.Close();
            }
        }

        private void get_dates_walks()
        {
            combobox_processing_date.DataSource = null;
            string street = combobox_street.SelectedItem.ToString();
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"Дата обхода\" FROM \"Участок\" " +
                "INNER JOIN \"Улица\" ON \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Район\".\"Район\" = '" + DistrictName + "' AND \"Улица\" = '" + street + "'";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_streets = new List<string>(temp_table.Rows.Count);
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        List_streets.Add(((DateTime)row[0]).ToShortDateString());
                    }
                    catch { }
                }
                combobox_processing_date.DataSource = new BindingSource(List_streets, null);
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

        private void DatabaseRegistryRequest_Load(object sender, EventArgs e)
        {
            get_dates_walks();
        }
    }
}
