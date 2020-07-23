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

namespace Journal_Client
{
    public partial class DatabaseJournalAllReg : Form
    {
        private int select_type;
        private NpgsqlConnection con;
        private NpgsqlCommand cmd;

        private void Radiobutton_date_CheckedChanged(object sender, EventArgs e)
        {
            combobox_fio.Enabled = false;
            date_сalendar.Enabled = true;
            combobox_personal_account.Enabled = false;
            select_type = 0;
        }
       
        private void Radiobutton_personal_account_CheckedChanged(object sender, EventArgs e)
        {
            combobox_fio.Enabled = false;
            date_сalendar.Enabled = false;
            combobox_personal_account.Enabled = true;
            select_type = 1;
        }

        private void Radiobutton_fio_CheckedChanged(object sender, EventArgs e)
        {
            combobox_fio.Enabled = true;
            combobox_personal_account.Enabled = false;
            date_сalendar.Enabled = false;
            select_type = 2;
        }

        private void Radiobutton_all_CheckedChanged(object sender, EventArgs e)
        {
            combobox_fio.Enabled = false;
            combobox_personal_account.Enabled = false;
            date_сalendar.Enabled = false;
            select_type = 3;
        }

        private void DatabaseJournalAllReg_Load(object sender, EventArgs e)
        {
            combobox_fio.Enabled = false;
            date_сalendar.Enabled = true;
            combobox_personal_account.Enabled = false;
            select_type = 0;
            GetPersonalAccount();
            GetFIO();
        }

        private void Radiobutton_date_obhoda_CheckedChanged(object sender, EventArgs e)
        {
            combobox_fio.Enabled = false;
            date_сalendar.Enabled = true;
            combobox_personal_account.Enabled = false;
            select_type = 4;
        }

        private void GetPersonalAccount()
        {
            try
            {
                System.Data.DataTable temp_table = new System.Data.DataTable();
                con.Open();
                string SQLCommand = "select \"Лицевой счет\" from \"Журнал регистраций заявок\" " +
                "group by \"Лицевой счет\"";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table = new System.Data.DataTable();
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                List<string> templist = new List<string>();
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        templist.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_personal_account.DataSource = new BindingSource(templist, null);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void GetFIO()
        {
            try
            {
                System.Data.DataTable temp_table = new System.Data.DataTable();
                con.Open();
                string SQLCommand = "select \"ФИО потребителя\" from \"Журнал регистраций заявок\" " +
                "group by \"ФИО потребителя\"";
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table = new System.Data.DataTable();
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                List<string> templist = new List<string>();
                foreach (DataRow row in temp_table.Rows)
                {
                    try
                    {
                        templist.Add(row[0].ToString());
                    }
                    catch { }
                }
                combobox_fio.DataSource = new BindingSource(templist, null);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void date_select(object sender, DateRangeEventArgs e)
        {
            datetime_show.Value = date_сalendar.SelectionStart;
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

        private void Button_do_select_Click(object sender, EventArgs e)
        {
            string SQLCommand = "select \"Дата подачи заявки\", \"ФИО потребителя\", \"Улица\", \"Дом\", \"Квартира\", \"Вид заявки\", \"Дата обхода\" " +
            "from \"Журнал регистраций заявок\" " +
            "inner join \"Вид заявки\" on \"Журнал регистраций заявок\".\"#Код вида заявки\" = \"Вид заявки\".\"#Код вида заявки\" " +
            "inner join \"Участок\" on \"Журнал регистраций заявок\".\"#Код участка\" = \"Участок\".\"#Код участка\" ";
            make_select(SQLCommand);
        }

        private void make_select(string main_sql)
        {
            string sql_rule = "";
            try
            {
                System.Data.DataTable temp_table = new System.Data.DataTable();
                con.Open();
                switch (select_type)
                {
                    case 0:
                        sql_rule = "where \"Дата подачи заявки\" = '" + datetime_show.Value.ToShortDateString() + "'";
                        break;
                    case 1:
                        sql_rule = "where \"Лицевой счет\" = '" + combobox_personal_account.SelectedItem.ToString() + "'";
                        break;
                    case 2:
                        sql_rule = "where \"ФИО потребителя\" = '" + combobox_fio.SelectedItem + "'";
                        break;
                    case 3:
                        sql_rule = " ";
                        break;
                    case 4:
                        sql_rule = "where \"Дата обхода\" = '" + datetime_show.Value.ToShortDateString() + "'";
                        break;
                    default:
                        MessageBox.Show("Ошибка на этапе формирования условий запроса");
                        break;
                }
                string SQLCommand = main_sql + sql_rule;
                cmd = new NpgsqlCommand(SQLCommand, con);
                temp_table = new System.Data.DataTable();
                temp_table.Load(cmd.ExecuteReader());
                con.Close();
                datagridview.DataSource = temp_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
               
    }
}
