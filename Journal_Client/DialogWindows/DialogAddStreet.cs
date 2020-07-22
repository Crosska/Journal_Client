using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DialogAddStreet : Form
    {

        private NpgsqlCommand cmd;
        private NpgsqlConnection con;
        private DateTime chosen_date;
        private string district;

        public DialogAddStreet(DateTime chosen_date_received, string district_received, NpgsqlConnection con_received)
        {
            InitializeComponent();
            chosen_date = chosen_date_received;
            district = district_received;
            date_active.Value = chosen_date;
         }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            string street_code = get_street_code();
            string date = date_active.Value.ToShortDateString();
            bool error = check_area(street_code, date);
            if (!error)
            {
                try
                {
                    DataTable temp_table = new DataTable();
                    con.Open();
                    string SQLCommand = "INSERT INTO \"Участок\" (\"#Код улицы\", \"Дата обхода\") VALUES (" + street_code + ", '" + date + "' )";
                    NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
                    cmd = new NpgsqlCommand(SQLCommand, con);
                    cmd.Prepare();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись успешно добавлена.");
                }
                catch
                {
                    MessageBox.Show("Ошибка при вставке записи в БД.");
                }
                finally
                {
                    con.Close();
                }
            }

        }

        private bool check_area(string street_code, string date)
        {
            bool error = false;
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select * from \"Участок\" " +
                "where \"#Код улицы\" = " + street_code + " and \"Дата обхода\" = '" + date + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
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
                if(List_streets.Count != 0)
                {
                    error = true;
                    MessageBox.Show("Улица с данным названием уже добавлена");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при проверке улицы.");
            }
            finally
            {
                con.Close();
            }
            return error;
        }

        private string get_street_code()
        {
            string street_code = "";
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"#Код улицы\" FROM \"Улица\" " +
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Район\" = '" + district + "' and \"Улица\" = '" + combobox_streets.SelectedItem.ToString() + "' ";
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                street_code = temp_table.Rows[0].Field<int>(0).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка при получении кода улицы..");
            }
            finally
            {
                con.Close();
            }
            return street_code;
        }

        private void getStreets()
        {
            try
            {              
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"Улица\" FROM \"Улица\" " +
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +
                "WHERE \"Район\" = '" + con + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
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
                combobox_streets.DataSource = new BindingSource(List_streets, null);
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

    }
}
