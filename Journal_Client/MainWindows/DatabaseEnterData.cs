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
    public partial class DatabaseEnterData : Form
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

        NpgsqlConnection database;
        NpgsqlCommand cmd;

        public DatabaseEnterData(string IP)
        {
            InitializeComponent();
            datagridtable_meter.DataSource = null;
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

        private void personal_account_changed(object sender, EventArgs e)
        {
            listbox_FIO_adress.Items.Clear();
            datagridtable_meter.DataSource = null;
            try
            {
                database.Open();
                string SQLCommand = "select \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\" from \"Журнал регистраций заявок\" " +
                "where \"Лицевой счет\" || '' like '" + textbox_personal_account.Text + "%' " +
                "group by \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\"";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable datatable;
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                List<string> temp = new List<string>();
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    temp.Add(datatable.Rows[i].Field<string>(0) + " | " + datatable.Rows[i].Field<string>(1) + " | " + datatable.Rows[i].Field<string>(2) + " | " + datatable.Rows[i].Field<string>(3) + " = " + datatable.Rows[i].Field<string>(4));
                }
                for (int i = 0; i < temp.Count; i++)
                {
                    listbox_FIO_adress.Items.Add(temp.ElementAtOrDefault<string>(i));
                }
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

        private void personal_account_selected(object sender, EventArgs e)
        {
            datagridtable_meter.DataSource = null;
            try
            {
                database.Open();
                string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' }); // Деление строки по символу '='
                string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' }); // Деление строки по символу ' '
                string SQLCommand = "select \"Показания\",\"Задолженность\",\"№ пломбы\",\"Дата обхода\",\"ФИО контролера\" from \"Журнал ввода/вывода\" " +
                "inner join \"Журнал регистраций заявок\" on \"Журнал ввода/вывода\".\"#Код заявки \" = \"Журнал регистраций заявок\".\"#Код заявки\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                "inner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                "where \"Лицевой счет\" = '" + personal_number_second[1] + "'";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable datatable;
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                datagridtable_meter.DataSource = datatable;
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

        private void Button_add_Click(object sender, EventArgs e)
        {
            string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' }); // Деление строки по символу '='
            string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' }); // Деление строки по символу ' '
            DialogAddMeter add_meter_form = new DialogAddMeter(personal_number_second[1], ConData.IP);
            add_meter_form.ShowDialog();
        }

        private void Button_change_Click(object sender, EventArgs e)
        {
            DialogChangeMeter change_meter_form = new DialogChangeMeter();
            change_meter_form.ShowDialog();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            List<String> data_list = new List<string>();
            foreach (DataGridViewRow row in datagridtable_meter.Rows)
            {
                try
                {
                    string temp_str = ( row.Cells[0].Value.ToString() + " | " + row.Cells[1].Value.ToString() + " | " + row.Cells[2].Value.ToString() + " | " + (Convert.ToDateTime(row.Cells[3].Value)).ToShortDateString() + " | " + row.Cells[4].Value.ToString());
                    data_list.Add(temp_str);
                }
                catch { }
            }
            /*for (int i = 0; i < data_list.Count; i++)
            {
                MessageBox.Show(data_list.ElementAt(i));
            }*/
            string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' }); // Деление строки по символу '='
            string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' }); // Деление строки по символу ' '
            DialogDeleteMeter delete_meter_form = new DialogDeleteMeter(ConData.IP, data_list, personal_number_second[1]);
            delete_meter_form.ShowDialog();
        }

        private void DatabaseEnterData_Load(object sender, EventArgs e)
        {
            try
            {
                database.Open();
                string SQLCommand = "select \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\" from \"Журнал регистраций заявок\" " +
                "where \"Лицевой счет\" || '' like '" + textbox_personal_account.Text + "%' " +
                "group by \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\"";
                MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable datatable;
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                List<string> temp = new List<string>();
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    temp.Add(datatable.Rows[i].Field<string>(0) + " | " + datatable.Rows[i].Field<string>(1) + " | " + datatable.Rows[i].Field<string>(2) + " | " + datatable.Rows[i].Field<string>(3) + " = " + datatable.Rows[i].Field<string>(4));
                }
                for (int i = 0; i < temp.Count; i++)
                {
                    listbox_FIO_adress.Items.Add(temp.ElementAtOrDefault<string>(i));
                }
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

        private void tableRefresh(object sender, EventArgs e)
        {
            datagridtable_meter.DataSource = null;
            try
            {
                database.Open();
                string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' }); // Деление строки по символу '='
                string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' }); // Деление строки по символу ' '
                string SQLCommand = "select \"Показания\",\"Задолженность\",\"№ пломбы\",\"Дата обхода\",\"ФИО контролера\" from \"Журнал ввода/вывода\" " +
                "inner join \"Журнал регистраций заявок\" on \"Журнал ввода/вывода\".\"#Код заявки \" = \"Журнал регистраций заявок\".\"#Код заявки\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                "inner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                "where \"Лицевой счет\" = '" + personal_number_second[1] + "'";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable datatable;
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                datagridtable_meter.DataSource = datatable;
            }
            catch
            {
            }
            finally
            {
                database.Close();
            }
        }
    }
}
