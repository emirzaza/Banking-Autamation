
namespace Nesne1._0
{
    partial class BireyselHesap
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapSilBireysel = new System.Windows.Forms.Button();
            this.btnHesapEkleBireysel = new System.Windows.Forms.Button();
            this.bireyselanasayfa = new System.Windows.Forms.DataGridView();
            this.btnhesapgösterbireysel = new System.Windows.Forms.Button();
            this.hesapDökümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bireyselanasayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripNavbar
            // 
            this.menuStripNavbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripNavbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem,
            this.işlemToolStripMenuItem,
            this.havaleToolStripMenuItem,
            this.hesapDökümüToolStripMenuItem});
            this.menuStripNavbar.Location = new System.Drawing.Point(0, 0);
            this.menuStripNavbar.Name = "menuStripNavbar";
            this.menuStripNavbar.Padding = new System.Windows.Forms.Padding(300, 2, 0, 2);
            this.menuStripNavbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripNavbar.Size = new System.Drawing.Size(800, 28);
            this.menuStripNavbar.TabIndex = 0;
            this.menuStripNavbar.Text = "Navbar";
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hesapToolStripMenuItem.Text = "Hesap";
            // 
            // işlemToolStripMenuItem
            // 
            this.işlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekToolStripMenuItem,
            this.paraYatırToolStripMenuItem});
            this.işlemToolStripMenuItem.Name = "işlemToolStripMenuItem";
            this.işlemToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
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
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.havaleToolStripMenuItem.Text = "Havale";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(332, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOŞGELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHesapSilBireysel
            // 
            this.btnHesapSilBireysel.Location = new System.Drawing.Point(463, 339);
            this.btnHesapSilBireysel.Name = "btnHesapSilBireysel";
            this.btnHesapSilBireysel.Size = new System.Drawing.Size(201, 43);
            this.btnHesapSilBireysel.TabIndex = 5;
            this.btnHesapSilBireysel.Text = "Hesap Sil";
            this.btnHesapSilBireysel.UseVisualStyleBackColor = true;
            this.btnHesapSilBireysel.Click += new System.EventHandler(this.btnHesapSilBireysel_Click);
            // 
            // btnHesapEkleBireysel
            // 
            this.btnHesapEkleBireysel.Location = new System.Drawing.Point(161, 339);
            this.btnHesapEkleBireysel.Name = "btnHesapEkleBireysel";
            this.btnHesapEkleBireysel.Size = new System.Drawing.Size(201, 43);
            this.btnHesapEkleBireysel.TabIndex = 6;
            this.btnHesapEkleBireysel.Text = "Hesap Ekle";
            this.btnHesapEkleBireysel.UseVisualStyleBackColor = true;
            this.btnHesapEkleBireysel.Click += new System.EventHandler(this.btnHesapEkleBireysel_Click);
            // 
            // bireyselanasayfa
            // 
            this.bireyselanasayfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bireyselanasayfa.Location = new System.Drawing.Point(0, 112);
            this.bireyselanasayfa.Name = "bireyselanasayfa";
            this.bireyselanasayfa.RowHeadersWidth = 51;
            this.bireyselanasayfa.RowTemplate.Height = 24;
            this.bireyselanasayfa.Size = new System.Drawing.Size(800, 150);
            this.bireyselanasayfa.TabIndex = 7;
            this.bireyselanasayfa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bireyselanasayfa_CellContentClick);
            // 
            // btnhesapgösterbireysel
            // 
            this.btnhesapgösterbireysel.Location = new System.Drawing.Point(144, 84);
            this.btnhesapgösterbireysel.Name = "btnhesapgösterbireysel";
            this.btnhesapgösterbireysel.Size = new System.Drawing.Size(497, 23);
            this.btnhesapgösterbireysel.TabIndex = 8;
            this.btnhesapgösterbireysel.Text = "HESAPLARINIZI LİSTELEMEK İÇİN TIKLAYINIZ";
            this.btnhesapgösterbireysel.UseVisualStyleBackColor = true;
            this.btnhesapgösterbireysel.Click += new System.EventHandler(this.btnhesapgösterbireysel_Click);
            // 
            // hesapDökümüToolStripMenuItem
            // 
            this.hesapDökümüToolStripMenuItem.Name = "hesapDökümüToolStripMenuItem";
            this.hesapDökümüToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.hesapDökümüToolStripMenuItem.Text = "HesapDökümü";
            this.hesapDökümüToolStripMenuItem.Click += new System.EventHandler(this.hesapDökümüToolStripMenuItem_Click);
            // 
            // BireyselHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhesapgösterbireysel);
            this.Controls.Add(this.bireyselanasayfa);
            this.Controls.Add(this.btnHesapEkleBireysel);
            this.Controls.Add(this.btnHesapSilBireysel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripNavbar);
            this.MainMenuStrip = this.menuStripNavbar;
            this.Name = "BireyselHesap";
            this.Text = "BireyselHesap";
            this.Load += new System.EventHandler(this.BireyselHesap_Load);
            this.menuStripNavbar.ResumeLayout(false);
            this.menuStripNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bireyselanasayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripNavbar;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapSilBireysel;
        private System.Windows.Forms.Button btnHesapEkleBireysel;
        private System.Windows.Forms.DataGridView bireyselanasayfa;
        private System.Windows.Forms.Button btnhesapgösterbireysel;
        private System.Windows.Forms.ToolStripMenuItem hesapDökümüToolStripMenuItem;
    }
}