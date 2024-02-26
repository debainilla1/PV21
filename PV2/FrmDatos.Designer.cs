namespace PV2
{
    partial class FrmDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblStudent = new System.Windows.Forms.Label();
            this.LstStudents = new System.Windows.Forms.ListBox();
            this.TxtStudent = new System.Windows.Forms.TextBox();
            this.BttAdd = new System.Windows.Forms.Button();
            this.BttDelete = new System.Windows.Forms.Button();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblAge = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LblStudent
            // 
            this.LblStudent.AutoSize = true;
            this.LblStudent.Location = new System.Drawing.Point(12, 38);
            this.LblStudent.Name = "LblStudent";
            this.LblStudent.Size = new System.Drawing.Size(44, 13);
            this.LblStudent.TabIndex = 0;
            this.LblStudent.Text = "Student";
            // 
            // LstStudents
            // 
            this.LstStudents.FormattingEnabled = true;
            this.LstStudents.Location = new System.Drawing.Point(15, 79);
            this.LstStudents.Name = "LstStudents";
            this.LstStudents.Size = new System.Drawing.Size(502, 186);
            this.LstStudents.TabIndex = 1;
            this.LstStudents.SelectedIndexChanged += new System.EventHandler(this.LstStudents_SelectedIndexChanged);
            // 
            // TxtStudent
            // 
            this.TxtStudent.Location = new System.Drawing.Point(73, 36);
            this.TxtStudent.Name = "TxtStudent";
            this.TxtStudent.Size = new System.Drawing.Size(444, 20);
            this.TxtStudent.TabIndex = 2;
            // 
            // BttAdd
            // 
            this.BttAdd.Location = new System.Drawing.Point(542, 34);
            this.BttAdd.Name = "BttAdd";
            this.BttAdd.Size = new System.Drawing.Size(75, 23);
            this.BttAdd.TabIndex = 3;
            this.BttAdd.Text = "Add";
            this.BttAdd.UseVisualStyleBackColor = true;
            this.BttAdd.Click += new System.EventHandler(this.BttAdd_Click);
            // 
            // BttDelete
            // 
            this.BttDelete.Location = new System.Drawing.Point(653, 33);
            this.BttDelete.Name = "BttDelete";
            this.BttDelete.Size = new System.Drawing.Size(75, 23);
            this.BttDelete.TabIndex = 4;
            this.BttDelete.Text = "Delete";
            this.BttDelete.UseVisualStyleBackColor = true;
            this.BttDelete.Click += new System.EventHandler(this.BttDelete_Click);
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(628, 79);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 20);
            this.TxtAge.TabIndex = 5;
            this.TxtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            this.TxtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAge_KeyPress);
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(555, 85);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(26, 13);
            this.LblAge.TabIndex = 6;
            this.LblAge.Text = "Age";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(542, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.BttDelete);
            this.Controls.Add(this.BttAdd);
            this.Controls.Add(this.TxtStudent);
            this.Controls.Add(this.LstStudents);
            this.Controls.Add(this.LblStudent);
            this.Name = "FrmDatos";
            this.Text = "FrmDatos";
            this.Load += new System.EventHandler(this.FrmDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStudent;
        private System.Windows.Forms.ListBox LstStudents;
        private System.Windows.Forms.TextBox TxtStudent;
        private System.Windows.Forms.Button BttAdd;
        private System.Windows.Forms.Button BttDelete;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}