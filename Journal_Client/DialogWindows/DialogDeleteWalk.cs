using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DialogDeleteWalk : Form
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

        private string DistrictName = "";

        public DialogDeleteWalk(string date, string street, string IP)
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
                    MessageBox.Show("Произошла ошибка при определении района по IP адресу");
                    break;
            }
            label_date.Text = date;
            label_street.Text = street;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.99" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                database.Open();
                string SQLCommand = "DELETE FROM \"Участок\" WHERE \"#Код улицы\" = " + getStreetCode() + " AND \"Дата обхода\" = '" + label_date.Text + "'";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                cmd = new NpgsqlCommand(SQLCommand, database);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Обход успешно удален.");
            }
            catch
            {
                MessageBox.Show("Есть записи связанные с этим обходом.");
            }
            finally
            {
                database.Close();
            }
            this.Close();
        }

        private string getStreetCode()
        {
            string street_code = "";
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.99" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                database.Open();
                string SQLCommand = "select \"#Код улицы\" from \"Улица\" " +
                "where \"Улица\" = '" + label_street.Text + "' ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd;
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable datatable;
                datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                foreach (DataRow row in datatable.Rows)
                {
                    try
                    {
                        street_code = row[0].ToString();
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получении кода улицы.");
            }
            finally
            {
                database.Close();
            }
            return street_code;
        }

    }
}
