using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
                this.LblName.Text = "La caja está vacía";


            }
        }

        private void BttClick_Click(object sender, EventArgs e)
        {
            if (this.CmbCarreer.Text != string.Empty)

            {
                this.LblName.Text = this.CmbCarreer.Text;

            }
            else
            {
                this.LblName.Text = "La caja está vacía";
            }
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            this.CmbCarreer.SelectedIndex = 0;
        }

        private void BttLongitud_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.CmbCarreer.Items.Count.ToString(),"Longitud de combo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information); 
        }
    }
}

