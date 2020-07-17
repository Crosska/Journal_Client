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

namespace Journal_Client.AdminWindows
{
    public partial class AdminWorkspace : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;

        public AdminWorkspace(NpgsqlConnection con_received)
        {
            InitializeComponent();
            con = con_received;
        }

        private void radiobutton_users_checked(object sender, EventArgs e)
        {
            refresh_table();
        }

        private void refresh_table()
        {
            con.Open();
            if(radiobutton_users.Checked)
            {
                datagridview.DataSource = null;
                String SQL = "select * from \"Сотрудник\"";
                cmd = new NpgsqlCommand(SQL, con);
                DataTable temp_table = new DataTable();
                temp_table.Load(cmd.ExecuteReader());
                datagridview.DataSource = temp_table;
            }
        }

    }
}
