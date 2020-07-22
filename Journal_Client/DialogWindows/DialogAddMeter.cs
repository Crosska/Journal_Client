using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DialogAddMeter : Form
    {

        private string login;

        NpgsqlConnection con;
        NpgsqlCommand cmd;

        public DialogAddMeter(string personal_account, NpgsqlConnection con_received, string login_received)
        {
            InitializeComponent();
            label_personal_account.Text = personal_account;
            con = con_received;
            login = login_received;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            bool error = check_all();
            if (!error)
            {
                try
                {
                    DataTable temp_table = new DataTable();
                    con.Open();
                    string SQLCommand = "insert into \"Журнал ввода/вывода\" " +
                    "(\"#Код заявки \", \"№ пломбы\", \"Задолженность\", \"#Код контролера\", \"Показания\") " +
                    "values( " + getApplicationCode() + ", " + textbox_seal_number.Text + " , " + numeric_saldo.Value + " , " + getControllerCode() + " , " + numeric_meter.Value + " )";
                    cmd = new NpgsqlCommand(SQLCommand, con);
                    cmd.Prepare();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SystemInfoLogger logger = new SystemInfoLogger();
                    logger.WriteNewDataline(login, "Добавил на лицевой счет " + label_personal_account.Text + " показания " + numeric_meter.Value);
                    MessageBox.Show("Показания успешно добавлены.");
                }
                catch (Exception error_str)
                {
                    MessageBox.Show(error_str.StackTrace);
                }
                finally
                {
                    con.Close();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность вводимых данных");
            }
        }

        private bool check_all()
        {
            try
            {
                string temp_string = textbox_seal_number.Text;
                int temp_int = Convert.ToInt32(temp_string);
                return false;
            }
            catch
            {
                return true;
            }
        }

        private void DialogAddMeter_Load(object sender, EventArgs e)
        {
            getWalksDate();
            getControllerFIO();
        }

        private void getWalksDate()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select \"Дата обхода\" from \"Участок\" " +
                "inner join \"Журнал регистраций заявок\" on \"Участок\".\"#Код участка\" = \"Журнал регистраций заявок\".\"#Код участка\" " +
                "where \"Лицевой счет\" = '" + label_personal_account.Text + "' group by \"Дата обхода\"";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                MessageBox.Show("Ошибка при получении списка дат обходов.");
            }
            finally
            {
                con.Close();
            }
        }

        private void getControllerFIO()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select \"ФИО контролера\" from \"Контролер\" ";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                MessageBox.Show("Ошибка при получении ФИО контроллеров.");
            }
            finally
            {
                con.Close();
            }
        }

        private string getApplicationCode()
        {
            string code = "";
            try
            {
                DataTable temp_table = new DataTable();
                MessageBox.Show(con.State.ToString());
                string SQLCommand = "select \"#Код заявки\" from \"Журнал регистраций заявок\" " +
                "where \"Лицевой счет\" = '" + label_personal_account.Text + "' ";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            return code;
        }

        private string getControllerCode()
        {
            string code = "";
            try
            {
                DataTable temp_table = new DataTable();
                string SQLCommand = "select \"#Код контролера\" from \"Контролер\" " +
                "where \"ФИО контролера\" = '" + combobox_controller.SelectedItem + "'";
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
            catch
            {
                MessageBox.Show("Ошибка при получении кода контроллера.");
            }
            return code;
        }

    }
}
