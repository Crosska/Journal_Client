using Journal_Client.DialogWindows;
using Npgsql;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Client.AdminWindows
{
    public partial class AdminWorkspace : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        Form previous;

        public AdminWorkspace(NpgsqlConnection con_received, Form previous_received)
        {
            InitializeComponent();
            con = con_received;
            previous = previous_received;
            refresh_table();
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
            con.Close();
        }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            previous.Visible = true;
        }

        private void button_open_log_Click(object sender, EventArgs e)
        {
            Process.Start(@"data.lg");
        }

        private void button_clear_log_Click(object sender, EventArgs e)
        {
            DialogLogClear dialog = new DialogLogClear();
            dialog.ShowDialog();
        }

        private void button_open_prg_log_Click(object sender, EventArgs e)
        {
            LogViewer window = new LogViewer();
            window.ShowDialog();
        }
    }
}
