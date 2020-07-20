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
    public partial class DatabaseRegistryArea : Form
    {

        private NpgsqlCommand cmd;
        private NpgsqlConnection con;
        private string district;

        public DatabaseRegistryArea(string district_received, NpgsqlConnection con_received)
        {
            InitializeComponent();
            con = con_received;
            district = district_received;
            show_streets_for_date();
        }

        private void date_changed(object sender, DateRangeEventArgs e)                                          // Действие при выборе даты
        {
            show_streets_for_date();                                                                            // Вызов функции
        }

        private void show_streets_for_date()                                                                    // Выводит улицы по выбранной дате
        {
            DateTime chosen_date = Calendar.SelectionRange.Start;                                               // Создание переменной типа 'дата' и берется выбранной значение из календаря 
            datetime_show.Value = chosen_date;                                                                  // Выбранная дата ставится в элемент datetime_show для удобного отображения
            string chosen_date_sql = Calendar.SelectionRange.Start.ToShortDateString();                         // Создается строка с выбранной датой в форме 'краткой даты'
            try
            {
                con.Open();                                                                                     // Открыли базу данных
                string SQLCommand = "SELECT \"Улица\" FROM \"Улица\" " +                                        // Строка с sql командой
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +              // --
                "INNER JOIN \"Участок\" ON \"Улица\".\"#Код улицы\" = \"Участок\".\"#Код улицы\" " +            // --
                "WHERE \"Район\" = '" + district + "' AND \"Дата обхода\" = '" + chosen_date_sql + "' ";        // --
                cmd = new NpgsqlCommand(SQLCommand, con);                                                       // Присваивание cmd команде sql команду и указание бд 
                DataTable datatable = new DataTable();                                                          // Создание таблицы для приема результата запроса                                                                  // 
                datatable.Load(cmd.ExecuteReader());
                con.Close();
                datagridtable_streets.DataSource = datatable;                                                   // Загрузка таблицы с результатами в таблицу на форме
            }
            catch
            {
                MessageBox.Show("Ошибка поиска улиц по району и дате обхода.");
            }
            finally
            {
                con.Close();                                                                               // Закрыли базу данных
            }
        }

        private void Button_add_Click(object sender, EventArgs e)                                               // Действие при нажатии на кнопку "Добавить"
        {
            DialogAddStreet AddStreetForm = new DialogAddStreet(datetime_show.Value, district);             // Создание обьекта формы с передачей даты и названия района
            AddStreetForm.ShowDialog();                                                                         // Вызов обьекта формы
        }

        private void RefreshTable(object sender, EventArgs e)                                                   // Действия при обновлении таблицы
        {
            show_streets_for_date();                                                                            // Вызов функции
        }

        private void Button_delete_Click(object sender, EventArgs e)                                            // Действие при нажатии на кнопку удалить
        {
            try
            {
                DialogDeleteWalk DeleteWalkForm = new DialogDeleteWalk(datetime_show.Value.ToShortDateString(), datagridtable_streets.CurrentCell.Value.ToString(), con); // Создание обьекта формы с передачей данных
                DeleteWalkForm.ShowDialog();                                                                    // Вызов обьекта формы
            }
            catch
            {
                MessageBox.Show("Для удаления выберите какую-либо улицу из таблицы.");
            }
        }

    }
}
