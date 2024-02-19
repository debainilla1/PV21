using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV2
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void BttPressMe_Click(object sender, EventArgs e)
        {
            // estructuras de control
            if (this.TxtName.Text != string.Empty)
            {
                this.LblName.Text = this.TxtName.Text;
            
            }
            else
            {
                this.LblName.Text = "la caja está vacía";


            }
        }
    }
}

