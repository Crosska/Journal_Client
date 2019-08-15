using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Journal_Client
{
    public partial class DatabaseInOutJournal : Form
    {

        struct Database
        {
            public string IP;
            public string Port;
            public string DatabaseName;
            public string User;
            public string Password;
        }
        private Database ConData = new Database();

        private bool select_in = true;
        private int select_type = 0;

        public DatabaseInOutJournal(String server_ip)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = server_ip;
            // DistrictName = DistrictName_received;
            // MessageBox.Show(DistrictName_received);
            

            datagridview.RowHeadersVisible = false;
            getFIO();
        }

        private void radiobutton_only_date_checked(object sender, EventArgs e)
        {
            calendar.Enabled = true;
            combobox_controller.Enabled = false;
            select_type = 0;
        }

        private void radiobutton_only_controller_checked(object sender, EventArgs e)
        {
            calendar.Enabled = false;
            combobox_controller.Enabled = true;
            select_type = 1;
        }

        private void radiobutton_all_checked(object sender, EventArgs e)
        {
            calendar.Enabled = false;
            combobox_controller.Enabled = false;
            select_type = 2;
        }

        private void radiobutton_in_checked(object sender, EventArgs e)
        {
            select_in = true;
        }

        private void radiobutton_out_checked(object sender, EventArgs e)
        {
            select_in = false;
        }

        private void Button_do_select_Click(object sender, EventArgs e)
        {
            switch (select_in)
            {
                case false:
                    string SQLCommand = "select \"Журнал регистраций заявок\".\"Лицевой счет\", \"Улица\", \"Дом\", \"Квартира\", \"Дата обхода\", \"Показания\", \"№ пломбы\", \"ФИО контролера\" from \"Журнал регистраций заявок\" " +
                    "inner join \"Журнал ввода/вывода\" on \"Журнал регистраций заявок\".\"#Код заявки\" = \"Журнал ввода/вывода\".\"#Код заявки \" " +
                    "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                    "inner join \"Вид заявки\" on \"Журнал регистраций заявок\".\"#Код вида заявки\" = \"Вид заявки\".\"#Код вида заявки\" " +
                    "inner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" ";
                    make_select(SQLCommand);
                    break;
                case true:
                    SQLCommand = "select \"Журнал регистраций заявок\".\"Лицевой счет\", \"Улица\", \"Дом\", \"Квартира\", \"Дата обхода\", \"Показания\", \"№ пломбы\", \"ФИО контролера\" from \"Журнал регистраций заявок\" " +
                    "inner join \"Журнал ввода/вывода\" on \"Журнал регистраций заявок\".\"#Код заявки\" = \"Журнал ввода/вывода\".\"#Код заявки \" " +
                    "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" " +
                    "inner join \"Вид заявки\" on \"Журнал регистраций заявок\".\"#Код вида заявки\" = \"Вид заявки\".\"#Код вида заявки\" " +
                    "inner join \"Контролер\" on \"Журнал ввода/вывода\".\"#Код контролера\" = \"Контролер\".\"#Код контролера\" ";
                    make_select(SQLCommand);
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при формировании запроса");
                    break;
            }
        }

        private void make_select(string main_sql)
        {
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            string sql_rule = "";
            try
            {
                System.Data.DataTable temp_table = new System.Data.DataTable();
                database.Open();
                string type = "Вывод";
                if (radiobutton_select_in.Checked)
                {
                    type = "Ввод";
                }
                switch (select_type)
                {
                    case 0:
                        sql_rule = "where \"Дата обхода\" = '" + datetime_show.Value.ToString() + "' and \"Вид заявки\".\"Вид заявки\" = '" + type + "'";
                        break;
                    case 1:
                        sql_rule = "where \"Контролер\".\"ФИО контролера\" = '" + combobox_controller.SelectedItem.ToString() + "' and \"Вид заявки\".\"Вид заявки\" = '" + type + "'";
                        break;
                    case 2:
                        sql_rule = "where \"Вид заявки\".\"Вид заявки\" = '" + type + "'";
                        break;
                    default:
                        MessageBox.Show("Ошибка на этапе формирования условий запроса");
                        break;
                }
                string SQLCommand = main_sql + sql_rule;
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table = new System.Data.DataTable();
                temp_table.Load(cmd.ExecuteReader());
                datagridview.DataSource = temp_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                database.Close();
            }
            
        }

        private void date_changed(object sender, DateRangeEventArgs e)
        {
            datetime_show.Value = calendar.SelectionStart;
        }

        private void getFIO()
        {
            string conString = "";
            conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";";
            NpgsqlConnection database = new NpgsqlConnection(conString);
            try
            {

                System.Data.DataTable temp_table = new System.Data.DataTable();
                database.Open();
                string SQLCommand = "select \"ФИО контролера\" from \"Контролер\" ";
                //MessageBox.Show(SQLCommand);
                NpgsqlCommand cmd = new NpgsqlCommand(SQLCommand, database);
                temp_table.Load(cmd.ExecuteReader());
                List<string> List_FIO = new List<string>(temp_table.Rows.Count);
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        List_FIO.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_controller.DataSource = new BindingSource(List_FIO, null);
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

        private void Button_export_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = (System.Data.DataTable)datagridview.DataSource;
            try
            {
                if (dt.Rows.Count != 0)
                {

                    Microsoft.Office.Interop.Excel.Application objexcelapp = new Microsoft.Office.Interop.Excel.Application();
                    objexcelapp.Application.Workbooks.Add(Type.Missing);
                    objexcelapp.Columns.AutoFit();
                    for (int i = 1; i < dt.Columns.Count + 1; i++)
                    {
                        Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)objexcelapp.Cells[1, i];
                        xlRange.Font.Bold = -1;
                        xlRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        xlRange.Borders.Weight = 1d;
                        xlRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        objexcelapp.Cells[1, i] = dt.Columns[i - 1].ColumnName;
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Rows[i][j] != null)
                            {
                                Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)objexcelapp.Cells[i + 2, j + 1];
                                xlRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                xlRange.Borders.Weight = 1d;
                                objexcelapp.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                            }
                        }
                    }
                    objexcelapp.Columns.AutoFit();
                    System.Windows.Forms.Application.DoEvents();
                    saveFileDialog1.Filter = "Excel современный формат|*.xlsx|Excel старый формат|*.xls|All files(*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    string filename = saveFileDialog1.FileName;
                    MessageBox.Show(filename);
                    if (Directory.Exists("C:\\CTR_Data\\"))
                    {
                        objexcelapp.ActiveWorkbook.SaveCopyAs(filename);
                    }
                    else
                    {
                        Directory.CreateDirectory("C:\\CTR_Data\\");
                        objexcelapp.ActiveWorkbook.SaveCopyAs(filename);
                    }
                    objexcelapp.ActiveWorkbook.Saved = true;
                    System.Windows.Forms.Application.DoEvents();
                    foreach (Process proc in System.Diagnostics.Process.GetProcessesByName("EXCEL"))
                    {
                        proc.Kill();
                    }
                }
                else
                {
                    MessageBox.Show("Таблица пуста");
                }
            }
            catch
            {
                MessageBox.Show("Сначала выполните запрос.");
            }
        }
    }
}
