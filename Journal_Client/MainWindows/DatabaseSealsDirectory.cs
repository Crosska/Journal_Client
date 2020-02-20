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
    public partial class DatabaseSealsDirectory : Form
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

        public DatabaseSealsDirectory(string DistrictName_received)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            DistrictName = DistrictName_received;
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
        }

        private void Button_add_seal_Click(object sender, EventArgs e)
        {
            bool main_error = check_main();
            if (!main_error)
            {
                bool error = check_all(textbox_number_seal.Text);
                if (!error)
                {
                    string conString = "Server=" + /*ConData.IP*/ "192.168.23.99" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
                    NpgsqlConnection database = new NpgsqlConnection(conString);
                    try
                    {
                        DataTable temp_table = new DataTable();
                        database.Open();
                        string SQLCommand = "INSERT INTO \"Пломбиратор\" (\"Номер\") VALUES ( " + textbox_number_seal.Text + " )";
                        //MessageBox.Show(SQLCommand);
                        NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                        cmd = new NpgsqlCommand(SQLCommand, database);
                        cmd.Prepare();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно добавлена.");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при подключении к локальному серверу.");
                    }
                    finally
                    {
                        database.Close();
                    }
                    Update_seals_list();
                }
            }
        }

        private bool check_main()
        {
            bool error = false;
            try
            {
                int temp = Convert.ToInt32(textbox_number_seal.Text);
            }
            catch
            {
                error = true;
                MessageBox.Show("Проверьте правильность введенных данных.");
            }
            return error;
        }

        private bool check_all(string text)
        {
            bool error = false;
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.99" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select * from \"Пломбиратор\" " +
                "where \"Номер\" = 123 ";
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
                if (List_streets.Count != 0)
                {
                    error = true;
                    MessageBox.Show("Пломбиратор с данным номером уже существует");
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
            return error;
        }

        private void Button_delete_seal_Click(object sender, EventArgs e)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.99" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "DELETE FROM \"Пломбиратор\" where \"Номер\" = '" + combobox_sealer_list.SelectedItem.ToString() + "'";
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
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
                Update_seals_list();
            }
        }

        private void Update_seals_list()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.99" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"Номер\" FROM \"Пломбиратор\" ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_seals = new List<string>(temp_table.Rows.Count);
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        List_seals.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_sealer_list.DataSource = new BindingSource(List_seals, null);
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

        private void DatabaseSealsDirectory_Load(object sender, EventArgs e)
        {
            Update_seals_list();
        }
    }
}
