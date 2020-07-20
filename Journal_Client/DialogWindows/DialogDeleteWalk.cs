﻿using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DialogDeleteWalk : Form
    {

        NpgsqlConnection con;
        NpgsqlCommand cmd;

        public DialogDeleteWalk(string date, string street, NpgsqlConnection con_received)
        {
            InitializeComponent(); 
            con = con_received;
            label_date.Text = date;
            label_street.Text = street;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (check_walk_on_empty()) 
            {
                try
                {
                    con.Open();
                    string SQLCommand = "DELETE FROM \"Участок\" WHERE \"#Код улицы\" = " + getStreetCode() + " AND \"Дата обхода\" = '" + label_date.Text + "'";
                    //MessageBox.Show(SQLCommand);
                    cmd = new NpgsqlCommand(SQLCommand, con);
                    cmd.Prepare();
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления обхода");
                }
                finally
                {
                    con.Close();
                }
            } else
            {
                MessageBox.Show("Обход нельзя удалить, с ним связаны одна или несколько записей.");
            }
            this.Close();
        }

        private bool check_walk_on_empty()
        {
            try
            {
                con.Open();
                string SQLCommand = "select count(\"#Код заявки\") from \"Журнал регистраций заявок\" " +
                "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                "inner join \"Улица\" on \"Участок\".\"#Код улицы\" = \"Улица\".\"#Код улицы\" " +
                "where \"Дата обхода\" = '" + label_date.Text + "' and \"Журнал регистраций заявок\".\"Улица\" = '" + label_street.Text + "'";
                cmd = new NpgsqlCommand(SQLCommand, con);
                DataTable datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                con.Close();
                if(datatable.Rows.Count==0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Есть записи связанные с этим обходом.");
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        private string getStreetCode()
        {
            string street_code = "";
            try
            {
                string SQLCommand = "select \"#Код улицы\" from \"Улица\" " +
                "where \"Улица\" = '" + label_street.Text + "' ";
                //MessageBox.Show(SQLCommand);
                cmd = new NpgsqlCommand(SQLCommand, con);
                DataTable datatable = new DataTable();
                datatable.Load(cmd.ExecuteReader());
                foreach (DataRow row in datatable.Rows)
                {
                    try
                    {
                        street_code = row[0].ToString();
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при определении кода улицы");
            }
            return street_code;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
