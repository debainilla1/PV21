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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void BttAdd_Click(object sender, EventArgs e)
        {
            this.LstStudents.Items.Add(this.TxtStudent.Text);

        }

        private void BttDelete_Click(object sender, EventArgs e)
        {
            this.LstStudents.Items.Remove(this.LstStudents.SelectedItem);
        }

        private void LstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstStudents.SelectedItem == null)

            {
                TxtStudent.Text = string.Empty;

            }
            else
            {
                this.TxtStudent.Text = this.LstStudents.SelectedItem.ToString();

            }
        }

        private void TxtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

                    e.Handled = true;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(dateTime.ToString());
        }
    }
    }
    
    
    
