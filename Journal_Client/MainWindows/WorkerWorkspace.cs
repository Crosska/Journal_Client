﻿using Npgsql;
using System;
using System.Windows.Forms;

namespace Journal_Client
{

    public partial class WorkerWorkspace : Form
    {

        private string login;
        private Form prev_form;
        private NpgsqlConnection con;
        private string district;

        public WorkerWorkspace(string login_received, string district_received, Form prev, NpgsqlConnection con_received)
        {
            InitializeComponent();
            login = login_received;
            prev_form = prev;
            con = con_received;
            district = district_received;
        }

        private void Button_registry_area_Click(object sender, EventArgs e) // Форма регистрации участков
        {
            DatabaseRegistryArea registry_area_form = new DatabaseRegistryArea(district, con, login); // Открыть форму регистрации участка
            registry_area_form.Show();
        }

        private void Button_registry_request_Click(object sender, EventArgs e) // Форма регистрации заявок 
        {
            DatabaseRegistryRequest registry_request_form = new DatabaseRegistryRequest(district, con, login); // Открыть форму регистрации запроса
            registry_request_form.Show();
        }

        private void Button_sealers_directory_Click(object sender, EventArgs e) // Справочник пломбираторов
        {
            DatabaseSealsControllersLinks seals_controllers_links_form = new DatabaseSealsControllersLinks(con, login); // Открыть форму связей контролера и пломбиратора
            seals_controllers_links_form.Show();
        }

        private void Button_controllers_directory_Click(object sender, EventArgs e) // Справочник контролеров
        {
            DatabaseControllersDirectory controllers_directory_form = new DatabaseControllersDirectory(login, con); // Открыть форму справочника контролеров
            controllers_directory_form.Show();
        }

        private void Button_seales_directory_Click(object sender, EventArgs e) // Справочник пломбираторов
        {
            DatabaseSealsDirectory seals_directory_form = new DatabaseSealsDirectory(district, con, login); // Открыть форму справочника пломбираторов
            seals_directory_form.Show();
        }

        private void Button_in_out_journal_Click(object sender, EventArgs e) // Журнал ввода/вывода 
        {
            DatabaseInOutJournal in_out_journal_form = new DatabaseInOutJournal(con); // Открыть форму журнала ввод/вывод
            in_out_journal_form.Show();
        }

        private void Button_enter_data_Click(object sender, EventArgs e) // Форма показаний
        {
            DatabaseEnterData in_out_enter_form = new DatabaseEnterData(con, login); // Открыть форму ввода показаний
            in_out_enter_form.Show();
        }

        private void form_closed(object sender, FormClosedEventArgs e) // Действие при закрытии формы (закрывает всю программу)
        {
            prev_form.Visible = true;
        }

        private void Button_inventory_journal_Click(object sender, EventArgs e)
        {
            DatabaseInventoryJournal inventory_form = new DatabaseInventoryJournal(con);
            inventory_form.Show();
        }

        private void Button_jurnal_reg_Click(object sender, EventArgs e)
        {
            DatabaseJournalAllReg journal_reg_form = new DatabaseJournalAllReg();
            journal_reg_form.Show();
        }

        private void WorkerWorkspace_Load(object sender, EventArgs e)
        {
            label_server.Text = district;
        }
    }
}
