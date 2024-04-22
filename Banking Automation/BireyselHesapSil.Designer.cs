
namespace Nesne1._0
{
    partial class BireyselHesapSil
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
            this.btnhesapsilbireyselonay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbireyselhesapsil = new System.Windows.Forms.TextBox();
            this.hesapsilbireyseltablo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hesapsilbireyseltablo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhesapsilbireyselonay
            // 
            this.btnhesapsilbireyselonay.Location = new System.Drawing.Point(94, 138);
            this.btnhesapsilbireyselonay.Name = "btnhesapsilbireyselonay";
            this.btnhesapsilbireyselonay.Size = new System.Drawing.Size(187, 38);
            this.btnhesapsilbireyselonay.TabIndex = 28;
            this.btnhesapsilbireyselonay.Text = "Hesabı Sil";
            this.btnhesapsilbireyselonay.UseVisualStyleBackColor = true;
            this.btnhesapsilbireyselonay.Click += new System.EventHandler(this.btnhesapsilbireyselonay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Silmek istediğiniz hesabın numarasınıı giriniz";
            // 
            // txtbireyselhesapsil
            // 
            this.txtbireyselhesapsil.Location = new System.Drawing.Point(57, 87);
            this.txtbireyselhesapsil.Name = "txtbireyselhesapsil";
            this.txtbireyselhesapsil.Size = new System.Drawing.Size(272, 22);
            this.txtbireyselhesapsil.TabIndex = 29;
            // 
            // hesapsilbireyseltablo
            // 
            this.hesapsilbireyseltablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hesapsilbireyseltablo.Location = new System.Drawing.Point(-1, 628);
            this.hesapsilbireyseltablo.Name = "hesapsilbireyseltablo";
            this.hesapsilbireyseltablo.RowHeadersWidth = 51;
            this.hesapsilbireyseltablo.RowTemplate.Height = 24;
            this.hesapsilbireyseltablo.Size = new System.Drawing.Size(10, 10);
            this.hesapsilbireyseltablo.TabIndex = 30;
            // 
            // BireyselHesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 214);
            this.Controls.Add(this.hesapsilbireyseltablo);
            this.Controls.Add(this.txtbireyselhesapsil);
            this.Controls.Add(this.btnhesapsilbireyselonay);
            this.Controls.Add(this.label1);
            this.Name = "BireyselHesapSil";
            this.Text = "BireyselHesapSil";
            ((System.ComponentModel.ISupportInitialize)(this.hesapsilbireyseltablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhesapsilbireyselonay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbireyselhesapsil;
        private System.Windows.Forms.DataGridView hesapsilbireyseltablo;
    }
}