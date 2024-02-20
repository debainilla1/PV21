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
            this.CmbCarreer = new System.Windows.Forms.ComboBox();
            this.BttOtro = new System.Windows.Forms.Button();
            this.LblNameOtro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BttPressMe
            // 
            this.BttPressMe.Location = new System.Drawing.Point(13, 190);
            this.BttPressMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttPressMe.Name = "BttPressMe";
            this.BttPressMe.Size = new System.Drawing.Size(1031, 28);
            this.BttPressMe.TabIndex = 0;
            this.BttPressMe.Text = "Apachurrame";
            this.BttPressMe.UseVisualStyleBackColor = true;
            this.BttPressMe.Click += new System.EventHandler(this.BttPressMe_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(20, 5);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(1029, 22);
            this.TxtName.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(17, 49);
            this.LblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(0, 16);
            this.LblName.TabIndex = 2;
            // 
            // CmbCarreer
            // 
            this.CmbCarreer.FormattingEnabled = true;
            this.CmbCarreer.Items.AddRange(new object[] {
            "Software",
            "Seguridad Informática y Redes",
            "Industrial y Rentabilidad de Negocios",
            "Mecatrónica",
            "Diseño Industrial"});
            this.CmbCarreer.Location = new System.Drawing.Point(19, 92);
            this.CmbCarreer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbCarreer.Name = "CmbCarreer";
            this.CmbCarreer.Size = new System.Drawing.Size(1029, 24);
            this.CmbCarreer.TabIndex = 3;
            // 
            // BttOtro
            // 
            this.BttOtro.Location = new System.Drawing.Point(13, 247);
            this.BttOtro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttOtro.Name = "BttOtro";
            this.BttOtro.Size = new System.Drawing.Size(1031, 28);
            this.BttOtro.TabIndex = 4;
            this.BttOtro.Text = "Otro";
            this.BttOtro.UseVisualStyleBackColor = true;
            this.BttOtro.Click += new System.EventHandler(this.BttClick_Click);
            // 
            // LblNameOtro
            // 
            this.LblNameOtro.AutoSize = true;
            this.LblNameOtro.Location = new System.Drawing.Point(17, 142);
            this.LblNameOtro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNameOtro.Name = "LblNameOtro";
            this.LblNameOtro.Size = new System.Drawing.Size(0, 16);
            this.LblNameOtro.TabIndex = 5;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LblNameOtro);
            this.Controls.Add(this.BttOtro);
            this.Controls.Add(this.CmbCarreer);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BttPressMe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStudent";
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttPressMe;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ComboBox CmbCarreer;
        private System.Windows.Forms.Button BttOtro;
        private System.Windows.Forms.Label LblNameOtro;
    }
}