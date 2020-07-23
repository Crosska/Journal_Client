using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DatabaseEnterData : Form
    {
        private string login;
        private NpgsqlConnection con;
        private NpgsqlCommand cmd;

        public DatabaseEnterData(NpgsqlConnection con_received, string login_received)
        {
            InitializeComponent();
            con = con_received;
            login = login_received;
            datagridtable_meter.DataSource = null;
        }

        private void personal_account_changed(object sender, EventArgs e)
        {
            listbox_FIO_adress.Items.Clear();
            datagridtable_meter.DataSource = null;
            try
            {
                con.Open();
                string SQLCommand = "select \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\" from \"Журнал регистраций заявок\" " +
                "where \"Лицевой счет\" || '' like '" + textbox_personal_account.Text + "%' " +
                "group by \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\"";
                cmd = new NpgsqlCommand(SQLCommand, con);
                DataTable datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                con.Close();
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
                con.Close();
            }
        }

        private void personal_account_selected(object sender, EventArgs e)
        {
            datagridtable_meter.DataSource = null;
            try
            {
                con.Open();
                string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' }); // Деление строки по символу '='
                string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' }); // Деление строки по символу ' '
                string SQLCommand = "select \"Показания\",\"Задолженность\",\"№ пломбы\",\"Дата обхода\",\"ФИО контролера\" from \"Журнал ввода/вывода\" " +
                "inner join \"Журнал регистраций заявок\" on \"Журнал ввода/вывода\".\"#Код заявки \" = \"Журнал регистраций заявок\".\"#Код заявки\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                "inner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                "where \"Лицевой счет\" = '" + personal_number_second[1] + "'";
                cmd = new NpgsqlCommand(SQLCommand, con);
                DataTable datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                con.Close();
                datagridtable_meter.DataSource = datatable;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' }); // Деление строки по символу '='
                string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' }); // Деление строки по символу ' '
                DialogAddMeter add_meter_form = new DialogAddMeter(personal_number_second[1], con, login);
                add_meter_form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Выберите лицевой счет.");
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> data_list = new List<string>();
                foreach (DataGridViewRow row in datagridtable_meter.Rows)
                {
                    try
                    {
                        string temp_str = (row.Cells[0].Value.ToString() + " | " + row.Cells[1].Value.ToString() + " | " + row.Cells[2].Value.ToString() + " | " + (Convert.ToDateTime(row.Cells[3].Value)).ToShortDateString() + " | " + row.Cells[4].Value.ToString());
                        data_list.Add(temp_str);
                    }
                    catch { }
                }
                string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' });              // Деление строки по символу '='
                string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' });                                       // Деление строки по символу ' '
                DialogDeleteMeter delete_meter_form = new DialogDeleteMeter(con, data_list, login);
                delete_meter_form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Выберите лицевой счет.");
            } 
        }

        private void DatabaseEnterData_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string SQLCommand = "select \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\" from \"Журнал регистраций заявок\" " +
                "where \"Лицевой счет\" || '' like '" + textbox_personal_account.Text + "%' " +
                "group by \"ФИО потребителя\",\"Улица\",\"Дом\",\"Квартира\",\"Лицевой счет\"";
                cmd = new NpgsqlCommand(SQLCommand, con);
                DataTable datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                con.Close();
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
                con.Close();
            }
        }

        private void tableRefresh(object sender, EventArgs e)
        {
            datagridtable_meter.DataSource = null;
            try
            {
                con.Open();
                string[] personal_number_first = listbox_FIO_adress.SelectedItem.ToString().Split(new char[] { '=' });              // Деление строки по символу '='
                string[] personal_number_second = personal_number_first[1].Split(new char[] { ' ' });                                       // Деление строки по символу ' '
                string SQLCommand = "select \"Показания\",\"Задолженность\",\"№ пломбы\",\"Дата обхода\",\"ФИО контролера\" from \"Журнал ввода/вывода\" " +
                "inner join \"Журнал регистраций заявок\" on \"Журнал ввода/вывода\".\"#Код заявки \" = \"Журнал регистраций заявок\".\"#Код заявки\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                "inner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                "where \"Лицевой счет\" = '" + personal_number_second[1] + "'";
                cmd = new NpgsqlCommand(SQLCommand, con);
                DataTable datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                con.Close();
                datagridtable_meter.DataSource = datatable;
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }
    }
}
