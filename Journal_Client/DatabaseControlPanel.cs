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
    public partial class DatabaseControlPanel : Form
    {
        private string rayon;
        public DatabaseControlPanel(string rayon_received)
        {
            InitializeComponent();
            rayon = rayon_received;
            MessageBox.Show(rayon);
        }

       
    }
}
