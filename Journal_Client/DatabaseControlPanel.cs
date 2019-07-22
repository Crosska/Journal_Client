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
            //MessageBox.Show(ServerIP);
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

        private void Button_registry_area_Click(object sender, EventArgs e)
        {
            DatabaseRegistryArea registry_area_form = new DatabaseRegistryArea(ServerIP);
            registry_area_form.Show();
        }

        private void Button_registry_request_Click(object sender, EventArgs e)
        {
            DatabaseRegistryRequest registry_request_form = new DatabaseRegistryRequest(label_server.Text);
            registry_request_form.Show();
        }

        private void Button_sealers_directory_Click(object sender, EventArgs e)
        {
            DatabaseSealsControllersLinks sealers_directory_form = new DatabaseSealsControllersLinks(label_server.Text);
            sealers_directory_form.Show();
        }

        private void Button_controllers_directory_Click(object sender, EventArgs e)
        {
            DatabaseControllersDirectory controllers_directory_form = new DatabaseControllersDirectory(label_server.Text);
            controllers_directory_form.Show();
        }

        private void Button_seales_directory_Click(object sender, EventArgs e)
        {
            DatabaseSealsDirectory seals_directory_form = new DatabaseSealsDirectory(label_server.Text);
            seals_directory_form.Show();
        }
    }
}
