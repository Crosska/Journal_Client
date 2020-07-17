using System;
using System.Windows.Forms;

namespace Journal_Client
{
    public partial class DatabaseConnection : Form
    {

        private string ServerIP = "";                 // Глобальная переменная для IP адреса

        public DatabaseConnection(int chosen_district_received)
        {
            InitializeComponent();
            switch (chosen_district_received)         // Свич на название района
            {
                case 0:
                    ServerIP = "192.168.85.250";      // Гвардейский
                    break;
                case 1:
                    ServerIP = "192.168.82.250";      // Горняцкий
                    break;
                case 2:
                    ServerIP = "192.168.1.250";       // Кировский
                    break;
                case 3:
                    ServerIP = "192.168.87.250";      // Советский
                    break;
                case 4:
                    ServerIP = "192.168.88.250";      // Центральный
                    break;
                default:
                    MessageBox.Show("Ошибка при определении IP адреса по названию района");
                    break;
            }
            timer_fake_progress.Interval = 400;       // 0,4 секунды
            timer_fake_progress.Enabled = true;       // Запуск таймера
            timer_fake_progress.Tick += timer_Tick;   // Добавление обработчика события "Каждый тик" на таймер
            progress_bar.Minimum = 0;                 // Установка минимального значения прогресс-бара
            progress_bar.Maximum = 100;               // Установка максимального значения прогресс-бара
        }

        void timer_Tick(object sender, EventArgs e) // Действие при каждом "тике" таймера
        {
            progress_bar.Value += 20;                 // Добавление прогресс бару 20 единиц
            if (progress_bar.Value == 100)            // Действия при заполнении прогресс-бара (когда значение бара = 100)
            {
                timer_fake_progress.Stop();           // Остановка таймера
                this.Visible = false;                 // Скрытие формы
                //WorkerWorkspace ControlForm = new WorkerWorkspace(ServerIP); // Создание обьекта формы и передача в него IP
                //ControlForm.Show();                   // Показ формы
            }
        }

        private void form_closed(object sender, FormClosedEventArgs e) // Действие при закрытии формы
        {
            Application.Exit();                       // Закрытие всего приложения
        }
    }
  
}

