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
        private string district;
        private string login;
        private NpgsqlCommand cmd;
        private NpgsqlConnection con;

        public DatabaseSealsDirectory(string district_received, NpgsqlConnection con_received, string login_received)
        {
            InitializeComponent();
            district = district_received;
            con = con_received;
            login = login_received;
        }

        private void Button_add_seal_Click(object sender, EventArgs e)
        {
            bool main_error = check_main();
            if (!main_error)
            {
                bool error = check_all(textbox_number_seal.Text);
                if (!error)
                {
                    try
                    {
                        DataTable temp_table = new DataTable();
                        con.Open();
                        string SQLCommand = "INSERT INTO \"Пломбиратор\" (\"Номер\") VALUES ( " + textbox_number_seal.Text + " )";
                        cmd = new NpgsqlCommand(SQLCommand, con);
                        cmd.Prepare();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        SystemInfoLogger logger = new SystemInfoLogger();
                        logger.WriteNewDataline(login, "Добавил пломбиратор с номером " + textbox_number_seal.Text);
                        MessageBox.Show("Запись успешно добавлена.");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при добавлении пломбиратора.");
                    }
                    finally
                    {
                        con.Close();
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
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select * from \"Пломбиратор\" " +
                "where \"Номер\" = 123 ";
                cmd = new NpgsqlCommand(SQLCommand, con);
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
                if (List_streets.Count != 0)
                {
                    error = true;
                    MessageBox.Show("Пломбиратор с данным номером уже существует");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных о пломбираторах.");
            }
            finally
            {
                con.Close();
            }
            return error;
        }

        private void Button_delete_seal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "DELETE FROM \"Пломбиратор\" where \"Номер\" = '" + combobox_sealer_list.SelectedItem.ToString() + "'";
                cmd = new NpgsqlCommand(SQLCommand, con);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                SystemInfoLogger logger = new SystemInfoLogger();
                logger.WriteNewDataline(login, "Удалил пломбиратор с номером " + combobox_sealer_list.SelectedItem);
                MessageBox.Show("Запись успешно удалена.");
            }
            catch
            {
                MessageBox.Show("Ошибка при попытке удаления пломбиратора.");
            }
            finally
            {
                con.Close();
                Update_seals_list();
            }
        }

        private void Update_seals_list()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"Номер\" FROM \"Пломбиратор\" ";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                MessageBox.Show("Ошибка при получении данных о номерах пломбираторов.");
            }
            finally
            {
                con.Close();
            }
        }

        private void DatabaseSealsDirectory_Load(object sender, EventArgs e)
        {
            Update_seals_list();
        }
    }
}
