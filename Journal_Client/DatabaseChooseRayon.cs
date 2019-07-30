using System;
using System.Windows.Forms;

namespace Journal_Client
{

    public partial class DatabaseChooseRayon : Form
    {

        public DatabaseChooseRayon()
        {
            InitializeComponent();                                                       // Отображение всех элементов формы
            combobox_district.SelectedIndex = 0;                                         // Выбор первого элемента из списка по стандарту
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            int chosen_district = combobox_district.SelectedIndex;                       // Получение индекса выбранного элемента в списке
            //MessageBox.Show(chosen_district.ToString());                               // Вывод индекса в сообщение
            this.Visible = false;                                                        // Скрытие формы
            DatabaseConnection ConnectionForm = new DatabaseConnection(chosen_district); // Подготовка к вызову новой формы (передача индекса в форму)
            ConnectionForm.Show();                                                       // Вызов формы
        }
    }
}
