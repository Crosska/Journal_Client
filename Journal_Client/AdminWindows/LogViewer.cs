using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Client.AdminWindows
{
    public partial class LogViewer : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;

        public LogViewer(NpgsqlConnection con_received)
        {
            InitializeComponent();
            con = con_received;
        }

        private void LogViewer_Load(object sender, EventArgs e)
        {
            StreamReader stream = new StreamReader("data.lg", System.Text.Encoding.UTF8);
            while (!stream.EndOfStream)
            {
                string[] line_parsed = stream.ReadLine().Split('|');
                datagridview_log_file.Rows.Add(line_parsed);
            }
            stream.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            datagridview_log_file.Rows.Clear();
            StreamReader stream = new StreamReader("data.lg", System.Text.Encoding.UTF8);
            while (!stream.EndOfStream)
            {
                string[] line_parsed = stream.ReadLine().Split('|');
                datagridview_log_file.Rows.Add(line_parsed);
            }
            stream.Close();
        }
    }
}
