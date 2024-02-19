namespace PV2
{
    partial class FrmStudent
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
            this.BttPressMe = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BttPressMe
            // 
            this.BttPressMe.Location = new System.Drawing.Point(15, 52);
            this.BttPressMe.Name = "BttPressMe";
            this.BttPressMe.Size = new System.Drawing.Size(773, 23);
            this.BttPressMe.TabIndex = 0;
            this.BttPressMe.Text = "Apachurrame";
            this.BttPressMe.UseVisualStyleBackColor = true;
            this.BttPressMe.Click += new System.EventHandler(this.BttPressMe_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(15, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(773, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 36);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(0, 13);
            this.LblName.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(773, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BttPressMe);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttPressMe;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}