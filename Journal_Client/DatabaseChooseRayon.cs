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

    public partial class DatabaseChooseRayon : Form
    {

        private bool online;

        private struct Server
        {
            internal string IP;
            internal string Port;
            internal string DatabaseName;
            internal string User;
            internal string Password;
        }
        private Server ConData;

        public DatabaseChooseRayon(bool online_received)
        {
            InitializeComponent();
            ConData.IP = "192.168.23.100";
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            online = online_received;
            String conString = "";
            switch (online)
            {
                case true:
                    conString = "Server=" + ConData.IP + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
                    break;
                case false:
                    conString = "Server=localhost;Port=5432;UserID=localroot;Password=Qwerty2;Database=postgres;";
                    break;
                default:
                    MessageBox.Show("Ошибка при передаче данных из формы.");
                    break;
            }
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                database.Open();
                string SQLCommand = "select \"Район\" from \"Район\" order by \"Район\"";
                NpgsqlCommand cmd;
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable TempTable = new DataTable();
                TempTable.Load(cmd.ExecuteReader());
                List<string> ListRayon = new List<string>(TempTable.Rows.Count);
                for (int i = 0; i < TempTable.Rows.Count; i++)
                {
                    ListRayon.Add(TempTable.Rows[i].Field<string>(0));
                }
                combocox_rayon.DataSource = new BindingSource(ListRayon, null);
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

        private void CloseAll(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
