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
    public partial class DialogDeleteWalk : Form
    {
        public DialogDeleteWalk(string date, string street)
        {
            InitializeComponent();
            label_date.Text = date;
            label_street.Text = street;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
