
namespace Nesne1._0
{
    partial class TicariHesapSil
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
            this.btnHesapSilOnayTicari = new System.Windows.Forms.Button();
            this.txtticarihesapsil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticarihesapsiltablo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ticarihesapsiltablo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapSilOnayTicari
            // 
            this.btnHesapSilOnayTicari.Location = new System.Drawing.Point(102, 127);
            this.btnHesapSilOnayTicari.Name = "btnHesapSilOnayTicari";
            this.btnHesapSilOnayTicari.Size = new System.Drawing.Size(187, 38);
            this.btnHesapSilOnayTicari.TabIndex = 31;
            this.btnHesapSilOnayTicari.Text = "Hesabı Sil";
            this.btnHesapSilOnayTicari.UseVisualStyleBackColor = true;
            this.btnHesapSilOnayTicari.Click += new System.EventHandler(this.btnHesapSilOnayTicari_Click);
            // 
            // txtticarihesapsil
            // 
            this.txtticarihesapsil.Location = new System.Drawing.Point(60, 81);
            this.txtticarihesapsil.Name = "txtticarihesapsil";
            this.txtticarihesapsil.Size = new System.Drawing.Size(272, 22);
            this.txtticarihesapsil.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Silmek istediğiniz hesabın numarasınıı giriniz";
            // 
            // ticarihesapsiltablo
            // 
            this.ticarihesapsiltablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticarihesapsiltablo.Location = new System.Drawing.Point(3, 631);
            this.ticarihesapsiltablo.Name = "ticarihesapsiltablo";
            this.ticarihesapsiltablo.RowHeadersWidth = 51;
            this.ticarihesapsiltablo.RowTemplate.Height = 24;
            this.ticarihesapsiltablo.Size = new System.Drawing.Size(10, 10);
            this.ticarihesapsiltablo.TabIndex = 34;
            // 
            // TicariHesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 181);
            this.Controls.Add(this.ticarihesapsiltablo);
            this.Controls.Add(this.txtticarihesapsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapSilOnayTicari);
            this.Name = "TicariHesapSil";
            this.Text = "TicariHesapSil";
            ((System.ComponentModel.ISupportInitialize)(this.ticarihesapsiltablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapSilOnayTicari;
        private System.Windows.Forms.TextBox txtticarihesapsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ticarihesapsiltablo;
    }
}