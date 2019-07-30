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
    public partial class DatabaseConnection : Form
    {

        private string ServerIP = "";

        public DatabaseConnection(int chosen_district_received)
        {
            InitializeComponent();
            switch (chosen_district_received)
            {
                case 0:
                    ServerIP = "192.168.85.250";            // Гвардейский
                    break;
                case 1:
                    ServerIP = "192.168.82.250";            // Горняцкий
                    break;
                case 2:
                    ServerIP = "192.168.1.250";             // Кировский
                    break;
                case 3:
                    ServerIP = "192.168.87.250";            // Советский
                    break;
                case 4:
                    ServerIP = "192.168.88.250";            // Центральный
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче выбранного сервера в программу");
                    break;
            }
            timer_fake_progress.Interval = 400;             // 0,4 секунды
            timer_fake_progress.Enabled = true;
            timer_fake_progress.Tick += timer_Tick;
            progress_bar.Minimum = 0;
            progress_bar.Maximum = 100;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            progress_bar.Value += 20;
            if (progress_bar.Value == 100)
            {
                timer_fake_progress.Stop();
                this.Visible = false;
                DatabaseControlPanel ControlForm = new DatabaseControlPanel(ServerIP); // Передача IP в форму
                ControlForm.Show();
            }
        }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
  
}

