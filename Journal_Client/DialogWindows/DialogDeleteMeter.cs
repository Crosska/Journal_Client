using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DialogDeleteMeter : Form
    {

        private string login;
        NpgsqlConnection con;
        NpgsqlCommand cmd;

        public DialogDeleteMeter(NpgsqlConnection con_received, List<string> data_list, string login_received)
        {
            InitializeComponent();
            con = con_received;
            login = login_received;
            combobox_meter.DataSource = data_list;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data_string = combobox_meter.SelectedItem.ToString().Split(new char[] { '|' });                         // Деление строки по символу '|'
                string SQLCommand = "";
                con.Open();
                if (data_string[0] == " ")
                {
                    SQLCommand = "delete from \"Журнал ввода/вывода\" " +
                "where \"#Код заявки \" = " + getApplicationCode(data_string) + " and \"№ пломбы\" = " + data_string[2] + " and \"Задолженность\" = " + data_string[1] + " and \"#Код контролера\" = " + getControllerCode(data_string[4]) + " and \"Показания\" is null ";
                }
                else
                {
                    SQLCommand = "delete from \"Журнал ввода/вывода\" " +
                "where \"#Код заявки \" = " + getApplicationCode(data_string) + " and \"№ пломбы\" = " + data_string[2] + " and \"Задолженность\" = " + data_string[1] + " and \"#Код контролера\" = " + getControllerCode(data_string[4]) + " and \"Показания\" = " + data_string[0] + " ";
                }
                cmd = new NpgsqlCommand(SQLCommand, con);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                SystemInfoLogger logger = new SystemInfoLogger();
                logger.WriteNewDataline(login, "Удалил показания " + combobox_meter.SelectedItem);
                MessageBox.Show("Запись успешно удалена.");
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при удалении показаний.");
            }
            finally
            {
                con.Close();
            }
            Close();
        }

        private string getControllerCode(string FIO)
        {
            string code = "";
            try
            {
                DataTable temp_table = new DataTable();
                string SQLCommand = "select \"#Код контролера\" from \"Контролер\" " +
                "where \"ФИО контролера\" = '" + FIO.TrimStart() + "' ";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        code = row[0].ToString();
                    }
                    catch { }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.StackTrace);
            }
            return code;
        }

        private string getApplicationCode(string[] data_string)
        {
            string code = "";
            try
            {
                DataTable temp_table = new DataTable();
                string SQLCommand = "select \"#Код заявки \" from \"Журнал ввода/вывода\" " +
                "where \"№ пломбы\" = " + data_string[2] + " and \"Задолженность\" = " + data_string[1] + " and \"#Код контролера\" = " + getControllerCode(data_string[4]) + " and \"Показания\" = " + data_string[0];
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        code = row[0].ToString();
                    }
                    catch { }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.StackTrace);
            }
            return code;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
