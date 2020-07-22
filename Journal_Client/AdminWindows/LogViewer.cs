using System;
using System.IO;
using System.Windows.Forms;

namespace Journal_Client.AdminWindows
{
    public partial class LogViewer : Form
    {

        public LogViewer()
        {
            InitializeComponent();
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
