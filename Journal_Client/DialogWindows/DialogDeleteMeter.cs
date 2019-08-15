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
    public partial class DialogDeleteMeter : Form
    {

        private string personal_account;

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

        public DialogDeleteMeter(string IP, List<string> data_list, string personal_account_received)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = IP;
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";" ;
            combobox_meter.DataSource = data_list;
            personal_account = personal_account_received;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                string[] data_string = combobox_meter.SelectedItem.ToString().Split(new char[] { '|' }); // Деление строки по символу '|'
                string SQLCommand = "";
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
                database.Open();
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                cmd = new NpgsqlCommand(SQLCommand, database);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена.");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность вводимых данных");
            }
            finally
            {
                database.Close();
            }
            this.Close();
        }

        private string getControllerCode(string FIO)
        {
            string code = "";
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"#Код контролера\" from \"Контролер\" " +
                "where \"ФИО контролера\" = '" + FIO.TrimStart() + "' ";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, database);
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
                MessageBox.Show(error.ToString());
            }
            finally
            {
                database.Close();
            }
            MessageBox.Show(code);
            return code;
        }

        private string getApplicationCode(string[] data_string)
        {
            string code = "";
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"#Код заявки \" from \"Журнал ввода/вывода\" " +
                "where \"№ пломбы\" = " + data_string[2] + " and \"Задолженность\" = " + data_string[1] + " and \"#Код контролера\" = " + getControllerCode(data_string[4]) + " and \"Показания\" = " + data_string[0] + " ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
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
                MessageBox.Show(error.ToString());
            }
            finally
            {
                database.Close();
            }
            return code;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
