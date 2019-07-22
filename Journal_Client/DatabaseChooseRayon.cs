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

    public partial class DatabaseChooseRayon : Form
    {

        public DatabaseChooseRayon()
        {
            InitializeComponent();
            combobox_district.SelectedIndex = 0;
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            int chosen_district = combobox_district.SelectedIndex;
            //MessageBox.Show(chosen_district.ToString());
            this.Visible = false;
            DatabaseConnection ConnectionForm = new DatabaseConnection(chosen_district);
            ConnectionForm.Show();
        }
    }
}
