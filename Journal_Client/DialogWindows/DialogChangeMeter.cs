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
    public partial class DialogChangeMeter : Form
    {
        public DialogChangeMeter()
        {
            InitializeComponent();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_apply_Click(object sender, EventArgs e)
        {

        }
    }
}
