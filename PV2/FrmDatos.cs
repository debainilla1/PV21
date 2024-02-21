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
            this.TxtStudent.Text = this.LstStudents.SelectedItem.ToString();
        }
    }
}
