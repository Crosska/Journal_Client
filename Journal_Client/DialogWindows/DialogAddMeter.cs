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
    public partial class DialogAddMeter : Form
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

        public DialogAddMeter(string personal_account, string IP)
        {
            InitializeComponent();
            label_personal_account.Text = personal_account;
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = IP;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            bool error = check_all();
            if (!error)
            {
                string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
                NpgsqlConnection database = new NpgsqlConnection(conString);
                try
                {
                    DataTable temp_table = new DataTable();
                    database.Open();
                    string SQLCommand = "insert into \"Журнал ввода/вывода\" " +
                    "(\"#Код заявки \", \"№ пломбы\", \"Задолженность\", \"#Код контролера\", \"Показания\") " +
                    "values( " + getApplicationCode() + ", " + textbox_seal_number.Text + " , " + numeric_saldo.Value + " , " + getControllerCode() + " , " + numeric_meter.Value + " )";
                    //MessageBox.Show(SQLCommand);
                    NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                    cmd = new NpgsqlCommand(SQLCommand, database);
                    cmd.Prepare();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Показания успешно добавлены.");
                }
                catch (Exception error_str)
                {
                    MessageBox.Show(error_str.ToString());
                }
                finally
                {
                    database.Close();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность вводимых данных");
            }
        }

        private bool check_all()
        {
            bool error = false;
            try
            {
                string temp_string = textbox_seal_number.Text;
                int temp_int = Convert.ToInt32(temp_string);
            }
            catch
            {
                error = true;
            }
            return error;
        }

        private void DialogAddMeter_Load(object sender, EventArgs e)
        {
            getWalksDate();
            getControllerFIO();
        }

        private void getWalksDate()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"Дата обхода\" from \"Участок\" " +
                "inner join \"Журнал регистраций заявок\" on \"Участок\".\"#Код участка\" = \"Журнал регистраций заявок\".\"#Код участка\" " +
                "where \"Лицевой счет\" = '" + label_personal_account.Text + "' group by \"Дата обхода\"";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> date_list = new List<string>();
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        date_list.Add( ( Convert.ToDateTime(row[0]) ).ToShortDateString() );
                    }
                    catch { }
                }
                combobox_date.DataSource = date_list;
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

        private void getControllerFIO()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"ФИО контролера\" from \"Контролер\" ";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> FIO_list = new List<string>();
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        FIO_list.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_controller.DataSource = FIO_list;
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

        private string getApplicationCode()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            database = new NpgsqlConnection(conString);
            string code = "";
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"#Код заявки\" from \"Журнал регистраций заявок\" " +
                "where \"Лицевой счет\" = '" + label_personal_account.Text + "' ";
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
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }
            return code;
        }

        private string getControllerCode()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            database = new NpgsqlConnection(conString);
            string code = "";
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"#Код контролера\" from \"Контролер\" " +
                "where \"ФИО контролера\" = '" + combobox_controller.SelectedItem + "' ";
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
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }
            return code;
        }

    }
}
