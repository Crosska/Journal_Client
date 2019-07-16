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


        private struct Server
        {
            internal string IP;
            internal string Port;
            internal string DatabaseName;
            internal string User;
            internal string Password;
        }
        private Server ConData;

        public DatabaseConnection()
        {
            InitializeComponent();
            ConData.IP = "192.168.23.100";
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            button_ok.Enabled = false;
            timer_fake_progress.Interval = 500; // 0,5 секунды
            timer_fake_progress.Enabled = true;
            timer_fake_progress.Tick += timer1_Tick;
            progress_bar.Minimum = 0;
            progress_bar.Maximum = 100;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        // обработчик события Tick таймера
        void timer1_Tick(object sender, EventArgs e)
        {
            progress_bar.Value += 10;
            if (progress_bar.Value == 100)
            {
                timer_fake_progress.Stop();
                button_ok.Enabled = true;
                String conString = "Server=" + ConData.IP + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
                MessageBox.Show(conString);
                try
                {
                    NpgsqlConnection database = new NpgsqlConnection(conString);
                    database.Open();
                    label_connect.Text = "Подключение успешное";
                    MessageBox.Show("Подключение прошло успешно");
                    //this.Visible = false;
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ошибка подключения");
                    label_connect.Text = "Ошибка подключения";
                }
            }

        }
    }
  
}

