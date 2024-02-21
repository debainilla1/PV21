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
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BttDelete);
            this.Controls.Add(this.BttAdd);
            this.Controls.Add(this.TxtStudent);
            this.Controls.Add(this.LstStudents);
            this.Controls.Add(this.LblStudent);
            this.Name = "FrmDatos";
            this.Text = "FrmDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStudent;
        private System.Windows.Forms.ListBox LstStudents;
        private System.Windows.Forms.TextBox TxtStudent;
        private System.Windows.Forms.Button BttAdd;
        private System.Windows.Forms.Button BttDelete;
    }
}