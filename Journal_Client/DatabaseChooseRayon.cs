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

    public partial class DatabaseChooseRayon : Form
    {

        /*private struct Server
        {
            internal string IP;
            internal string Port;
            internal string DatabaseName;
            internal string User;
            internal string Password;
        }
        private Server ConData;*/

        public DatabaseChooseRayon()
        {
            InitializeComponent();
            combobox_district.SelectedIndex = 0;
            /*ConData.IP = "192.168.23.100";
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            String conString = "";
            switch (online)
            {
                case true:
                    conString = "Server=" + ConData.IP + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
                    break;
                case false:
                    conString = "Server=localhost;Port=5432;UserID=localroot;Password=Qwerty2;Database=postgres;";
                    break;
                default:
                    MessageBox.Show("Ошибка при передаче данных из формы.");
                    break;
            }
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {
                database.Open();
                string SQLCommand = "select \"Район\" from \"Район\" order by \"Район\"";
                NpgsqlCommand cmd;
                cmd = new NpgsqlCommand(SQLCommand, database);
                DataTable TempTable = new DataTable();
                TempTable.Load(cmd.ExecuteReader());
                List<string> ListRayon = new List<string>(TempTable.Rows.Count);
                for (int i = 0; i < TempTable.Rows.Count; i++)
                {
                    ListRayon.Add(TempTable.Rows[i].Field<string>(0));
                }
                combobox_district.DataSource = new BindingSource(ListRayon, null);
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();
            }*/
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            int chosen_district = combobox_district.SelectedIndex;
            //MessageBox.Show(chosen_district.ToString());
            this.Visible = false;
            DatabaseConnection ConnectionForm = new DatabaseConnection(chosen_district);
            ConnectionForm.ShowDialog();
        }
    }
}