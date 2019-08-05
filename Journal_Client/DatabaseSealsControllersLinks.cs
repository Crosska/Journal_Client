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
    public partial class DatabaseSealsControllersLinks : Form
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

        public DatabaseSealsControllersLinks(string IP)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = IP;
            switch (ConData.IP)
            {
                case "192.168.85.250":
                    DistrictName = "Гвардейский";
                    break;
                case "192.168.82.250":
                    DistrictName = "Горняцкий";
                    break;
                case "192.168.1.250":
                    DistrictName = "Кировский";
                    break;
                case "192.168.87.250":
                    DistrictName = "Советский";
                    break;
                case "192.168.88.250":
                    DistrictName = "Центральный";
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче IP адреса сервера в программу");
                    break;
            }
            load_controllers_list();
        }

        private void load_controllers_list()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "SELECT \"ФИО контролера\" FROM \"Контролер\" ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_controllers = new List<string>(temp_table.Rows.Count);
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        List_controllers.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_controller.DataSource = new BindingSource(List_controllers, null);
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

        private void chosen_controller_changed(object sender, EventArgs e)
        {
            load_seals_to_controllers();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            DatabaseAddSealToController temp_form_link = new DatabaseAddSealToController(DistrictName, combobox_controller.Text);
            temp_form_link.ShowDialog();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            DatabaseDeleteSealFromController temp_form_link = new DatabaseDeleteSealFromController(DistrictName, listbox_sealers.SelectedItem.ToString());
            temp_form_link.ShowDialog();
        }

        private void update_form(object sender, EventArgs e)
        {
            load_seals_to_controllers();
        }

        private void load_seals_to_controllers()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "select \"Номер\" from \"Пломбиратор\" " +
                "inner join \"Контролер\" on \"Пломбиратор\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                "where \"ФИО контролера\" = '" + combobox_controller.Text + "' ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_controllers = new List<string>(temp_table.Rows.Count);
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        List_controllers.Add(row[0].ToString());
                    }
                    catch { }
                }
                listbox_sealers.DataSource = new BindingSource(List_controllers, null);
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
    }
}
