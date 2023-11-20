namespace arama_örneği_777
{
    partial class Form1
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
            this.lbAdlar = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAdlar
            // 
            this.lbAdlar.FormattingEnabled = true;
            this.lbAdlar.Items.AddRange(new object[] {
            "Elifsu",
            "Ayhan",
            "Nesrin",
            "İlayda",
            "Kerim",
            "Senanur ",
            "Melisa",
            "Berk",
            "Ali",
            "Yezdanur",
            "Kaan",
            "Melek ",
            "Berk",
            "Melisa",
            "Kaan",
            "Melisa",
            "İlayda",
            "Elifsu",
            "Ayhan"});
            this.lbAdlar.Location = new System.Drawing.Point(37, 72);
            this.lbAdlar.Name = "lbAdlar";
            this.lbAdlar.Size = new System.Drawing.Size(175, 303);
            this.lbAdlar.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(244, 186);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(178, 56);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(37, 27);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(175, 20);
            this.txtAranan.TabIndex = 2;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(241, 291);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(64, 16);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = ".....kişi var";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 392);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lbAdlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAdlar;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblSonuc;
    }
}

