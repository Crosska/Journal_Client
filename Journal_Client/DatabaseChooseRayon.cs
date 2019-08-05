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
            this.Visible = false;                                                        // Скрытие формы
            DatabaseConnection ConnectionForm = new DatabaseConnection(combobox_district.SelectedIndex); // Подготовка к вызову новой формы (передача индекса в форму)
            ConnectionForm.Show();                                                       // Вызов формы
        }
    }
}
