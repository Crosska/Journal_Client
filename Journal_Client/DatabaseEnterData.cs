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

        public DatabaseEnterData(string DistrictName_received)
        {
            InitializeComponent();
            datagridtable_meter.DataSource = null;
            DistrictName = DistrictName_received;
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
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
                "where \"Лицевой счет\" || '' like '" + textbox_personal_account.Text + "%'";
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
                string SQLCommand = "select \"Показания\", \"№ пломбы\", \"Дата обхода\" from \"Показания\" " +
                "inner join \"Журнал ввода/вывода\" on \"Показания\".\"#Код показания\" = \"Журнал ввода/вывода\".\"#Код показания\" " +
                "inner join \"Журнал регистраций заявок\" on \"Журнал ввода/вывода\".\"#Код заявки \" = \"Журнал регистраций заявок\".\"#Код заявки\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
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
                //MessageBox.Show(error.ToString());
            }
            finally
            {
                database.Close();
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            DatabaseAddMeter add_meter_form = new DatabaseAddMeter();
            add_meter_form.ShowDialog();
        }

        private void Button_change_Click(object sender, EventArgs e)
        {
            DatabaseChangeMeter change_meter_form = new DatabaseChangeMeter();
            change_meter_form.ShowDialog();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            DatabaseDeleteMeter delete_meter_form = new DatabaseDeleteMeter();
            delete_meter_form.ShowDialog();
        }
    }
}
