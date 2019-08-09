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

        struct Database
        {
            public string IP;
            public string Port;
            public string DatabaseName;
            public string User;
            public string Password;
        }
        private Database ConData = new Database();

        private string DistrictName = "";

        public DatabaseRegistryArea(string IP)
        {
            InitializeComponent();
            ConData.Port = "5432";
            ConData.DatabaseName = "postgres";
            ConData.User = "root";
            ConData.Password = "Qwerty2";
            ConData.IP = IP;
            switch (ConData.IP)
            {
                case "192.168.85.250":
                    DistrictName = "Гвардейский";
                    break;
                case "192.168.82.250":
                    DistrictName = "Горняцкий";
                    break;
                case "192.168.1.250":
                    DistrictName = "Кировский";
                    break;
                case "192.168.87.250":
                    DistrictName = "Советский";
                    break;
                case "192.168.88.250":
                    DistrictName = "Центральный";
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при передаче IP адреса сервера в программу");
                    break;
            }
            show_streets_for_date();                                                                            // Вызов функции
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
            string conString = "Server=" + /*ConData.IP*/ "192.168.23.100" + ";Port=" + ConData.Port + ";UserID=" + ConData.User + ";Password=" + ConData.Password + ";Database=" + ConData.DatabaseName + ";" ; // Строка подключения к бд
            NpgsqlConnection database = new NpgsqlConnection(conString);                                        // Создание подключения со строкой подключения
            try
            {
                database.Open();                                                                                // Открыли базу данных
                string SQLCommand = "SELECT \"Улица\" FROM \"Улица\" " +                                        // Строка с sql командой
                "INNER JOIN \"Район\" ON \"Улица\".\"#Код района\" = \"Район\".\"#Код района\" " +              // --
                "INNER JOIN \"Участок\" ON \"Улица\".\"#Код улицы\" = \"Участок\".\"#Код улицы\" " +            // --
                "WHERE \"Район\" = '" + DistrictName + "' AND \"Дата обхода\" = '" + chosen_date_sql + "' ";    // --
                //MessageBox.Show(SQLCommand);                                                                  // Вывод команды в окно
                NpgsqlCommand cmd;                                                                              // Создание cmd команды
                cmd = new NpgsqlCommand(SQLCommand, database);                                                  // Присваивание cmd команде sql команду и указание бд 
                DataTable datatable = new DataTable();                                                          // Создание таблицы для приема результата запроса                                                                  // 
                datatable.Load(cmd.ExecuteReader());                                                            // Отправка команды и прием результата в таблицу
                datagridtable_streets.DataSource = datatable;                                                   // Загрузка таблицы с результатами в таблицу на форме
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к локальному серверу.");
            }
            finally
            {
                database.Close();                                                                               // Закрыли базу данных
            }
        }

        private void Button_add_Click(object sender, EventArgs e)                                               // Действие при нажатии на кнопку "Добавить"
        {
            DialogAddStreet AddStreetForm = new DialogAddStreet(datetime_show.Value, DistrictName);             // Создание обьекта формы с передачей даты и названия района
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
                DialogDeleteWalk DeleteWalkForm = new DialogDeleteWalk(datetime_show.Value.ToShortDateString(), datagridtable_streets.CurrentCell.Value.ToString(), ConData.IP); // Создание обьекта формы с передачей данных
                DeleteWalkForm.ShowDialog();                                                                    // Вызов обьекта формы
            }
            catch
            {
                MessageBox.Show("Для удаления выберите какую-либо улицу из таблицы.");
            }
        }

    }
}
