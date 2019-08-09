﻿using System;
using System.Windows.Forms;

namespace Journal_Client
{

    public partial class DatabaseControlPanel : Form
    {

        private string ServerIP = "";                       // Глобальная переменная IP-адреса

        public DatabaseControlPanel(string ServerIP_received)
        {
            InitializeComponent();
            ServerIP = ServerIP_received;                   // Запись принятого IP в глобальную переменную
            switch (ServerIP)                               // Свич на IP для выведения на экран названия сервера
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
                    MessageBox.Show("Ошибка при определении названия района по IP");
                    break;
            }
        }

        private void Button_registry_area_Click(object sender, EventArgs e) // Форма регистрации участков
        {
            DatabaseRegistryArea registry_area_form = new DatabaseRegistryArea(ServerIP); // Открыть форму регистрации участка
            registry_area_form.Show();
        }

        private void Button_registry_request_Click(object sender, EventArgs e) // Форма регистрации заявок 
        {
            DatabaseRegistryRequest registry_request_form = new DatabaseRegistryRequest(ServerIP); // Открыть форму регистрации запроса
            registry_request_form.Show();
        }

        private void Button_sealers_directory_Click(object sender, EventArgs e) // Справочник пломбираторов
        {
            DatabaseSealsControllersLinks seals_controllers_links_form = new DatabaseSealsControllersLinks(ServerIP); // Открыть форму связей контролера и пломбиратора
            seals_controllers_links_form.Show();
        }

        private void Button_controllers_directory_Click(object sender, EventArgs e) // Справочник контролеров
        {
            DatabaseControllersDirectory controllers_directory_form = new DatabaseControllersDirectory(ServerIP); // Открыть форму справочника контролеров
            controllers_directory_form.Show();
        }

        private void Button_seales_directory_Click(object sender, EventArgs e) // Справочник пломбираторов
        {
            DatabaseSealsDirectory seals_directory_form = new DatabaseSealsDirectory(ServerIP); // Открыть форму справочника пломбираторов
            seals_directory_form.Show();
        }

        private void Button_in_out_journal_Click(object sender, EventArgs e) // Журнал ввода/вывода 
        {
            DatabaseInOutJournal in_out_journal_form = new DatabaseInOutJournal(ServerIP); // Открыть форму журнала ввод/вывод
            in_out_journal_form.Show();
        }

        private void Button_enter_data_Click(object sender, EventArgs e) // Форма показаний
        {
            DatabaseEnterData in_out_enter_form = new DatabaseEnterData(ServerIP); // Открыть форму ввода показаний
            in_out_enter_form.Show();
        }

        private void form_closed(object sender, FormClosedEventArgs e) // Действие при закрытии формы (закрывает всю программу)
        {
            Application.Exit();
        }

    }
}