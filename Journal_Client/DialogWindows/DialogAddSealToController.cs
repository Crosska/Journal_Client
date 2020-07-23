using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DialogAddSealToController : Form
    {

        private NpgsqlCommand cmd;
        private NpgsqlConnection con;
        private string login;
        private string fio;

        public DialogAddSealToController(string fio_received, NpgsqlConnection con_received, string login_received)
        {
            InitializeComponent();
            con = con_received;
            login = login_received;
            fio = fio_received;
            update_controllers_list();
        }

        private void Button_add_link_Click(object sender, EventArgs e)
        {
            string code = getControllerCode();
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "UPDATE \"Пломбиратор\" SET \"#Код контролера\" = " + code + "  WHERE \"Номер\" = '" + combobox_seal_number.Text + "';";
                cmd = new NpgsqlCommand(SQLCommand, con);
                MessageBox.Show(SQLCommand);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                SystemInfoLogger logger = new SystemInfoLogger();
                logger.WriteNewDataline(login, "Привязал пломбиратор " + combobox_seal_number.Text + " к контролеру " + fio);
                MessageBox.Show("Операция успешно выполнена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Ошибка при добавлении пломбиратора контролеру.");
            }
            finally
            {
                con.Close();
            }
        }

        private string getControllerCode()
        {
            string code = "";
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"#Код контролера\" from \"Контролер\" where \"ФИО контролера\" = '" + fio + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                List<string> List_controllers = new List<string>(temp_table.Rows.Count);
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
                MessageBox.Show("Ошибка при получении кода контролера..");
            }
            finally
            {
                con.Close();
            }
            return code;
        }

        private void update_controllers_list()
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "SELECT \"Номер\" FROM \"Пломбиратор\" ";
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, con);
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
                combobox_seal_number.DataSource = new BindingSource(List_seals, null);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении списка пломбираторов.");
            }
            finally
            {
                con.Close();
            }
        }

    }
}
