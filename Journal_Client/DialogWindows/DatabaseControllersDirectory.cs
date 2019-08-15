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
    public partial class DatabaseControllersDirectory : Form
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

        public DatabaseControllersDirectory(string IP)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = IP;
        }

        private void Button_add_controller_Click(object sender, EventArgs e)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "INSERT INTO \"Контролер\" (\"ФИО контролера\") VALUES ('" + textbox_fio_controller.Text + "')";
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
            refresh_list_controller();
        }

        private void DatabaseControllersDirectory_Load(object sender, EventArgs e)
        {
            refresh_list_controller();
        }

        private void refresh_list_controller()
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                System.Data.DataTable temp_table = new System.Data.DataTable();
                database.Open();
                string SQLCommand = "select \"ФИО контролера\" from \"Контролер\" " +
                "group by \"ФИО контролера\" "+
                "order by \"ФИО контролера\" ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table = new System.Data.DataTable();
                temp_table.Load(cmd.ExecuteReader());
                List<string> templist = new List<string>();
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        templist.Add(row[0].ToString());
                    }
                    catch { }
                }
                listbox_controllers.DataSource = new BindingSource(templist, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                database.Close();
            }
        }

    }
}
