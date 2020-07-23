using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DatabaseControllersDirectory : Form
    {

        private NpgsqlConnection con;
        private NpgsqlCommand cmd;
        private string login;

        public DatabaseControllersDirectory(string login_received, NpgsqlConnection con_received)
        {
            InitializeComponent();
            login = login_received;
            con = con_received;
        }

        private void Button_add_controller_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "INSERT INTO \"Контролер\" (\"ФИО контролера\") VALUES ('" + textbox_fio_controller.Text + "')";
                cmd = new NpgsqlCommand(SQLCommand, con);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                SystemInfoLogger logger = new SystemInfoLogger();
                logger.WriteNewDataline(login, "Добавил контролера " + textbox_fio_controller.Text);
                MessageBox.Show("Контролер успешно добавлен.");
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении контролера.");
            }
            finally
            {
                con.Close();
            }
            refresh_list_controller();
        }

        private void DatabaseControllersDirectory_Load(object sender, EventArgs e)
        {
            refresh_list_controller();
        }

        private void refresh_list_controller()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select \"ФИО контролера\" from \"Контролер\" " +
                "group by \"ФИО контролера\" "+
                "order by \"ФИО контролера\" ";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                con.Close();
            }
        }

    }
}
