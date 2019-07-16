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
        private struct Server
        {
            internal string IP;
            internal string Port;
            internal string DatabaseName;
            internal string User;
            internal string Password;
        }
        private Server ConData;

        public DatabaseChooseRayon()
        {
            InitializeComponent();
            ConData.IP = "192.168.23.100";
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            String conString = "Server=" + ConData.IP + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";

            NpgsqlConnection database = new NpgsqlConnection(conString);
            database.Open();
            string SQLCommand = "select \"Район\" from \"Район\" order by \"Район\"";
            NpgsqlCommand cmd;
            cmd = new NpgsqlCommand(SQLCommand, database);
            DataTable TempTable = new DataTable();
            TempTable.Load(cmd.ExecuteReader());
            List<string> ListRayon = new List<string>(TempTable.Rows.Count);
            for (int i = 0; i < TempTable.Rows.Count; i++)
            {
                try
                {
                    ListRayon.Add(TempTable.Rows[i].Field<string>(0));
                }
                catch { }
            }
            combocox_rayon.DataSource = new BindingSource(ListRayon, null);
        }



        private void CloseAll(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
