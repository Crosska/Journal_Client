﻿using Npgsql;
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
    public partial class DatabaseControllersDirectory : Form
    {
        private string DistrictName;

        struct Database
        {
            public string IP;
            public string Port;
            public string DatabaseName;
            public string User;
            public string Password;
        }
        private Database ConData = new Database();

        public DatabaseControllersDirectory(string DistrictName_received)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            DistrictName = DistrictName_received;
            switch (DistrictName)
            {
                case "Гвардейский":
                    ConData.IP = "192.168.85.250"; // Гвардейский
                    break;
                case "Горняцкий":
                    ConData.IP = "192.168.82.250"; // Горняцкий
                    break;
                case "Кировский":
                    ConData.IP = "192.168.1.250"; // Кировский
                    break;
                case "Советский":
                    ConData.IP = "192.168.87.250"; // Советский
                    break;
                case "Центральный":
                    ConData.IP = "192.168.88.250"; // Центральный
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче выбранного сервера в форму добавления");
                    this.Close();
                    break;
            }
        }

        private void Button_add_controller_Click(object sender, EventArgs e)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                DataTable temp_table = new DataTable();
                database.Open();
                string SQLCommand = "INSERT INTO \"Контролер\" (\"ФИО контролера\") VALUES ('" + textbox_fio_controller.Text + "')";
                MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                cmd = new NpgsqlCommand(SQLCommand, database);
                cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена.");
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }
        }
    }
}
