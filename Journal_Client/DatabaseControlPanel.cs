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

    public partial class DatabaseControlPanel : Form
    {

        private string ServerIP = "";

        public DatabaseControlPanel(string ServerIP_received)
        {
            InitializeComponent();
            ServerIP = ServerIP_received;
            MessageBox.Show(ServerIP);
            switch (ServerIP)
            {
                case "192.168.85.250":
                    label_server.Text = "Гвардейский";
                    break;
                case "192.168.82.250":
                    label_server.Text = "Горняцкий";
                    break;
                case "192.168.1.250":
                    label_server.Text = "Кировский";
                    break;
                case "192.168.87.250":
                    label_server.Text = "Советский";
                    break;
                case "192.168.88.250":
                    label_server.Text = "Центральный";
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче IP адреса сервера в программу");
                    break;
            }
        }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
