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

        private NpgsqlCommand cmd;
        private NpgsqlConnection con;
        private string login;

        public DatabaseSealsControllersLinks(NpgsqlConnection con_received, string login_received)
        {
            InitializeComponent();
            con = con_received;
            login = login_received;
            load_controllers_list();
        }

        private void load_controllers_list()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"ФИО контролера\" FROM \"Контролер\" ";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                MessageBox.Show("Ошибка при получении данных о контролерах.");
            }
            finally
            {
                con.Close();
            }
        }

        private void chosen_controller_changed(object sender, EventArgs e)
        {
            load_seals_to_controllers();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            DialogAddSealToController temp_form_link = new DialogAddSealToController(combobox_controller.Text, con, login);
            temp_form_link.ShowDialog();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            DialogDeleteSealFromController temp_form_link = new DialogDeleteSealFromController(listbox_sealers.SelectedItem.ToString(), login, con, combobox_controller.SelectedItem.ToString());
            temp_form_link.ShowDialog();
        }

        private void update_form(object sender, EventArgs e)
        {
            load_seals_to_controllers();
        }

        private void load_seals_to_controllers()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "select \"Номер\" from \"Пломбиратор\" " +
                "inner join \"Контролер\" on \"Пломбиратор\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" " +
                "where \"ФИО контролера\" = '" + combobox_controller.Text + "' ";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
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
                MessageBox.Show("Ошибка при получении данных о пломбираторах.");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
