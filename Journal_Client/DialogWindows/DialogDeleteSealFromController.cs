using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DialogDeleteSealFromController : Form
    {

        private string seal_number;
        private string login;
        private string controler;
        private NpgsqlCommand cmd;
        private NpgsqlConnection con;

        public DialogDeleteSealFromController(string seal_number_received, string login_received, NpgsqlConnection con_received, string controler_received)
        {
            InitializeComponent();
            con = con_received;
            seal_number = seal_number_received;
            login = login_received;
            controler = controler_received;
            label_seal_number.Text = seal_number;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_delete_link_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable temp_table = new DataTable();
                con.Open();
                string SQLCommand = "UPDATE \"Пломбиратор\" SET \"#Код контролера\" = null  WHERE \"Номер\" = '" + seal_number + "';";
                cmd = new NpgsqlCommand(SQLCommand, con);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                SystemInfoLogger logger = new SystemInfoLogger();
                logger.WriteNewDataline(login, "Отвязал пломбиратор с номером " + seal_number + " от контролера " + controler);
                MessageBox.Show("Пломбиратор успешно отвязан.");
            }
            catch
            {
                MessageBox.Show("Ошибка при отвязке пломбиратора.");
            }
            finally
            {
                con.Close();
            }
            Close();
        }

    }
}
