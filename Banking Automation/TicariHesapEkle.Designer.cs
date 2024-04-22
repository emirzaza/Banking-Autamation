
namespace Nesne1._0
{
    partial class TicariHesapEkle
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
            this.btnIptalTicari = new System.Windows.Forms.Button();
            this.btnOnayTicari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptalTicari
            // 
            this.btnIptalTicari.Location = new System.Drawing.Point(210, 107);
            this.btnIptalTicari.Name = "btnIptalTicari";
            this.btnIptalTicari.Size = new System.Drawing.Size(102, 43);
            this.btnIptalTicari.TabIndex = 35;
            this.btnIptalTicari.Text = "İptal";
            this.btnIptalTicari.UseVisualStyleBackColor = true;
            this.btnIptalTicari.Click += new System.EventHandler(this.btnIptalTicari_Click);
            // 
            // btnOnayTicari
            // 
            this.btnOnayTicari.Location = new System.Drawing.Point(87, 107);
            this.btnOnayTicari.Name = "btnOnayTicari";
            this.btnOnayTicari.Size = new System.Drawing.Size(102, 43);
            this.btnOnayTicari.TabIndex = 34;
            this.btnOnayTicari.Text = "Onaylıyorum";
            this.btnOnayTicari.UseVisualStyleBackColor = true;
            this.btnOnayTicari.Click += new System.EventHandler(this.btnOnayTicari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hesap açma işlemini onaylıyor musunuz?";
            // 
            // TicariHesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 189);
            this.Controls.Add(this.btnIptalTicari);
            this.Controls.Add(this.btnOnayTicari);
            this.Controls.Add(this.label1);
            this.Name = "TicariHesapEkle";
            this.Text = "TicariHesapEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptalTicari;
        private System.Windows.Forms.Button btnOnayTicari;
        private System.Windows.Forms.Label label1;
    }
}