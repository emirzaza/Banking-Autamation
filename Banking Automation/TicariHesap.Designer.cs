
namespace Nesne1._0
{
    partial class TicariHesap
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
            this.menuStripNavbar = new System.Windows.Forms.MenuStrip();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticariDökümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHesapEkleTicari = new System.Windows.Forms.Button();
            this.btnHesapSilTicari = new System.Windows.Forms.Button();
            this.btnhesapgösterticari = new System.Windows.Forms.Button();
            this.ticarianasayfa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticarianasayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripNavbar
            // 
            this.menuStripNavbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripNavbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem,
            this.işlemToolStripMenuItem,
            this.havaleToolStripMenuItem,
            this.ticariDökümToolStripMenuItem});
            this.menuStripNavbar.Location = new System.Drawing.Point(0, 0);
            this.menuStripNavbar.Name = "menuStripNavbar";
            this.menuStripNavbar.Padding = new System.Windows.Forms.Padding(300, 2, 0, 2);
            this.menuStripNavbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripNavbar.Size = new System.Drawing.Size(800, 25);
            this.menuStripNavbar.TabIndex = 1;
            this.menuStripNavbar.Text = "Navbar";
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.hesapToolStripMenuItem.Text = "Hesap";
            // 
            // işlemToolStripMenuItem
            // 
            this.işlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekToolStripMenuItem,
            this.paraYatırToolStripMenuItem});
            this.işlemToolStripMenuItem.Name = "işlemToolStripMenuItem";
            this.işlemToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.işlemToolStripMenuItem.Text = "İşlem";
            // 
            // paraÇekToolStripMenuItem
            // 
            this.paraÇekToolStripMenuItem.Name = "paraÇekToolStripMenuItem";
            this.paraÇekToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.paraÇekToolStripMenuItem.Text = "Para Çek";
            this.paraÇekToolStripMenuItem.Click += new System.EventHandler(this.paraÇekToolStripMenuItem_Click);
            // 
            // paraYatırToolStripMenuItem
            // 
            this.paraYatırToolStripMenuItem.Name = "paraYatırToolStripMenuItem";
            this.paraYatırToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.paraYatırToolStripMenuItem.Text = "Para Yatır";
            this.paraYatırToolStripMenuItem.Click += new System.EventHandler(this.paraYatırToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.havaleToolStripMenuItem.Text = "Havale";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // ticariDökümToolStripMenuItem
            // 
            this.ticariDökümToolStripMenuItem.Name = "ticariDökümToolStripMenuItem";
            this.ticariDökümToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.ticariDökümToolStripMenuItem.Text = "Ticari Döküm";
            this.ticariDökümToolStripMenuItem.Click += new System.EventHandler(this.ticariDökümToolStripMenuItem_Click);
            // 
            // btnHesapEkleTicari
            // 
            this.btnHesapEkleTicari.Location = new System.Drawing.Point(155, 312);
            this.btnHesapEkleTicari.Name = "btnHesapEkleTicari";
            this.btnHesapEkleTicari.Size = new System.Drawing.Size(196, 43);
            this.btnHesapEkleTicari.TabIndex = 12;
            this.btnHesapEkleTicari.Text = "Hesap Ekle";
            this.btnHesapEkleTicari.UseVisualStyleBackColor = true;
            this.btnHesapEkleTicari.Click += new System.EventHandler(this.btnHesapEkleTicari_Click);
            // 
            // btnHesapSilTicari
            // 
            this.btnHesapSilTicari.Location = new System.Drawing.Point(420, 312);
            this.btnHesapSilTicari.Name = "btnHesapSilTicari";
            this.btnHesapSilTicari.Size = new System.Drawing.Size(203, 43);
            this.btnHesapSilTicari.TabIndex = 11;
            this.btnHesapSilTicari.Text = "Hesap Sil";
            this.btnHesapSilTicari.UseVisualStyleBackColor = true;
            this.btnHesapSilTicari.Click += new System.EventHandler(this.btnHesapSilTicari_Click);
            // 
            // btnhesapgösterticari
            // 
            this.btnhesapgösterticari.Location = new System.Drawing.Point(135, 61);
            this.btnhesapgösterticari.Name = "btnhesapgösterticari";
            this.btnhesapgösterticari.Size = new System.Drawing.Size(497, 23);
            this.btnhesapgösterticari.TabIndex = 15;
            this.btnhesapgösterticari.Text = "HESAPLARINIZI LİSTELEMEK İÇİN TIKLAYINIZ";
            this.btnhesapgösterticari.UseVisualStyleBackColor = true;
            this.btnhesapgösterticari.Click += new System.EventHandler(this.btnhesapgösterticari_Click);
            // 
            // ticarianasayfa
            // 
            this.ticarianasayfa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ticarianasayfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticarianasayfa.Location = new System.Drawing.Point(0, 90);
            this.ticarianasayfa.Name = "ticarianasayfa";
            this.ticarianasayfa.RowHeadersWidth = 51;
            this.ticarianasayfa.RowTemplate.Height = 24;
            this.ticarianasayfa.Size = new System.Drawing.Size(800, 150);
            this.ticarianasayfa.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(329, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // TicariHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhesapgösterticari);
            this.Controls.Add(this.ticarianasayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapEkleTicari);
            this.Controls.Add(this.btnHesapSilTicari);
            this.Controls.Add(this.menuStripNavbar);
            this.Name = "TicariHesap";
            this.Text = "TicariBankaDokumu";
            this.menuStripNavbar.ResumeLayout(false);
            this.menuStripNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticarianasayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripNavbar;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
        private System.Windows.Forms.Button btnHesapEkleTicari;
        private System.Windows.Forms.Button btnHesapSilTicari;
        private System.Windows.Forms.Button btnhesapgösterticari;
        private System.Windows.Forms.DataGridView ticarianasayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ticariDökümToolStripMenuItem;
    }
}