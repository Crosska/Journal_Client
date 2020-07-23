using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DatabaseRegistryRequest : Form
    {

        private string login;
        private string district;
        private NpgsqlConnection con;
        private NpgsqlCommand cmd;

        public DatabaseRegistryRequest(string district_received, NpgsqlConnection con_received, string login_received)
        {
            InitializeComponent();
            con = con_received;
            login = login_received;
            district = district_received;
            combobox_processing_date.DataSource = null;
            getStreets();
            getApplicationType();
        }

        private void getApplicationType()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"Вид заявки\" FROM \"Вид заявки\" ";
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                List<string> List_streets = new List<string>(temp_table.Rows.Count);                // Создание списка с типом данных string с размеров = кол-ву строк из таблицы с результатами
                foreach (DataRow row in temp_table.Rows)                                                         // Цикл на каждую строку из таблицы с результатом запроса
                {
                    try
                    {
                        List_streets.Add(row[0].ToString());                                                                                // Добавление значения первой ячейки из строки таблицы в список
                    }
                    catch { }
                }
                combobox_type_application.DataSource = new BindingSource(List_streets, null);               // Заполенение выпадающего списка данными из списка List_streets
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                con.Close();
            }
        }

        private void getStreets()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select \"Улица\" from \"Улица\" " +
                "inner join \"Район\" on \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "where \"Район\" = '" + district + "' ";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                MessageBox.Show("Ошибка при подключении к локальному серверу. 1");
            }
            finally
            {
                con.Close();
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            bool error_first = check_date_exist();
            bool error_second = check_all_textbox();
            if (!error_first && !error_second)
            {
                int district_code = get_district_code();
                int application_type_code = get_application_type_code();
                try
                {
                    DataTable temp_table = new DataTable();
                    con.Open();
                    string SQLCommand = "INSERT INTO \"Журнал регистраций заявок\" (\"#Код участка\", \"Дата подачи заявки\", \"ФИО потребителя\", \"Улица\", " +
                    "\"Дом\", \"Квартира\", \"Оплата\", \"Лицевой счет\", \"#Код вида заявки\") " +
                    "VALUES(" + district_code + ", '" + datetime_show.Value.ToShortDateString() + "', '" + textbox_fio.Text + "', '" + combobox_street.SelectedItem.ToString() + "'," +
                    " '" + textbox_house.Text + "', '" + textbox_flat.Text + "', '" + numericupdown_payment.Value.ToString().Replace(',', '.') + "' , " + textbox_personal_account.Text + ", " + application_type_code + ")";
                    cmd = new NpgsqlCommand(SQLCommand, con);
                    cmd.Prepare();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SystemInfoLogger logger = new SystemInfoLogger();
                    logger.WriteNewDataline(login, "Добавил заявку по лицевому счету " + textbox_personal_account.Text + " по улице " + combobox_street.SelectedItem
                        + " по дате подачи заявки " + datetime_show.Value + " по дате обработки " + combobox_processing_date.Text);
                    MessageBox.Show("Запись успешно добавлена.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
                date_count_refresh();
            }
            else
            {
                MessageBox.Show("Для добавления заявки необходимо заполнить все важные поля (со звездочкой) и выбрать дату обработки.");
            }
        }

        private bool check_date_exist()
        {
            try
            {
                string temp = combobox_processing_date.SelectedItem.ToString();
                return false;
            }
            catch
            {
                return true;
            }
        }

        private bool check_all_textbox()
        {
            if (textbox_fio.Text.Length != 0)
            {
                if (textbox_personal_account.Text.Length != 0)
                {
                    if (textbox_house.Text.Length != 0)
                    {
                        return false;
                    }
                    else return true;
                }
                else return true;
            }
            else return true;
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
            int district_code = -1;
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"#Код участка\" FROM \"Участок\" " +
                "INNER JOIN \"Улица\" ON \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Район\" = '" + district + "' AND \"Дата обхода\" = '" + combobox_processing_date.SelectedItem.ToString() + "' AND \"Улица\" = '" + combobox_street.SelectedItem.ToString() + "'";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                MessageBox.Show("Ошибка при определении участка.");
            }
            finally
            {
                con.Close();
            }
            return district_code;
        }

        private int get_application_type_code()                                                         // Функция для получения кода вида заявки (возвращает код)
        {
            int application_type_code = -1;
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"#Код вида заявки\" FROM \"Вид заявки\" " +
                "WHERE \"Вид заявки\" = '" + combobox_type_application.SelectedItem.ToString() + "' ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        application_type_code = Convert.ToInt32(row[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получении видов заявок.");
            }
            return application_type_code;
        }

        private void date_proccessing_changed(object sender, EventArgs e)                               // Действие при изменении даты обработки
        {
            date_count_refresh();                                                                       // Вызов функции обновления количества обходов
        }

        private void date_count_refresh()                                                               // Функция обновления количества обходов
        {
            int count = 0;
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select count(\"#Код заявки\") from \"Журнал регистраций заявок\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                "inner join \"Улица\" on \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "where \"Дата обхода\" = '" + combobox_processing_date.SelectedValue + "' and \"Журнал регистраций заявок\".\"Улица\" = '" + combobox_street.SelectedValue + "'";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        count = Convert.ToInt32(row[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
            }
            catch
            {
                count = 0;
            }
            finally
            {
                con.Close();
                textview_bypass.Text = count.ToString();
            }
        }

        private void get_dates_walks()
        {
            combobox_processing_date.DataSource = null;
            string street = combobox_street.SelectedItem.ToString();
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"Дата обхода\" FROM \"Участок\" " +
                "INNER JOIN \"Улица\" ON \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Район\".\"Район\" = '" + district + "' AND \"Улица\" = '" + street + "'";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void DatabaseRegistryRequest_Load(object sender, EventArgs e)
        {
            get_dates_walks();
        }

    }
}
