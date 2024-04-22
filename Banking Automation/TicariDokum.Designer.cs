namespace Nesne1._0
{
    partial class TicariDokum
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
            this.btnticaridokum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdokumticari = new System.Windows.Forms.TextBox();
            this.gridticaridokum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridticaridokum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnticaridokum
            // 
            this.btnticaridokum.Location = new System.Drawing.Point(565, 46);
            this.btnticaridokum.Name = "btnticaridokum";
            this.btnticaridokum.Size = new System.Drawing.Size(75, 23);
            this.btnticaridokum.TabIndex = 7;
            this.btnticaridokum.Text = "GÖSTER";
            this.btnticaridokum.UseVisualStyleBackColor = true;
            this.btnticaridokum.Click += new System.EventHandler(this.btnticaridokum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "HESAP HARAKETLERİNİ GÖRMEK İSTEDİĞİNİZ HESAP NUMARASINI GİRİNİZ";
            // 
            // txtdokumticari
            // 
            this.txtdokumticari.Location = new System.Drawing.Point(238, 46);
            this.txtdokumticari.Name = "txtdokumticari";
            this.txtdokumticari.Size = new System.Drawing.Size(315, 22);
            this.txtdokumticari.TabIndex = 5;
            // 
            // gridticaridokum
            // 
            this.gridticaridokum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridticaridokum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridticaridokum.Location = new System.Drawing.Point(46, 75);
            this.gridticaridokum.Name = "gridticaridokum";
            this.gridticaridokum.RowHeadersWidth = 51;
            this.gridticaridokum.RowTemplate.Height = 24;
            this.gridticaridokum.Size = new System.Drawing.Size(709, 365);
            this.gridticaridokum.TabIndex = 4;
            // 
            // TicariDokum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnticaridokum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdokumticari);
            this.Controls.Add(this.gridticaridokum);
            this.Name = "TicariDokum";
            this.Text = "TicariDokum";
            ((System.ComponentModel.ISupportInitialize)(this.gridticaridokum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnticaridokum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdokumticari;
        private System.Windows.Forms.DataGridView gridticaridokum;
    }
}