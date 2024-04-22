
namespace Nesne1._0
{
    partial class BankaDokumu
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
            this.btnDokumanListele = new System.Windows.Forms.Button();
            this.gridbankadokum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridbankadokum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDokumanListele
            // 
            this.btnDokumanListele.Location = new System.Drawing.Point(72, 457);
            this.btnDokumanListele.Name = "btnDokumanListele";
            this.btnDokumanListele.Size = new System.Drawing.Size(341, 46);
            this.btnDokumanListele.TabIndex = 1;
            this.btnDokumanListele.Text = "Listele";
            this.btnDokumanListele.UseVisualStyleBackColor = true;
            this.btnDokumanListele.Click += new System.EventHandler(this.btnDokumanListele_Click);
            // 
            // gridbankadokum
            // 
            this.gridbankadokum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridbankadokum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbankadokum.Location = new System.Drawing.Point(24, 44);
            this.gridbankadokum.Name = "gridbankadokum";
            this.gridbankadokum.RowHeadersWidth = 51;
            this.gridbankadokum.RowTemplate.Height = 24;
            this.gridbankadokum.Size = new System.Drawing.Size(452, 407);
            this.gridbankadokum.TabIndex = 2;
            // 
            // BankaDokumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 539);
            this.Controls.Add(this.gridbankadokum);
            this.Controls.Add(this.btnDokumanListele);
            this.Name = "BankaDokumu";
            this.Text = "BankaDokumu";
            ((System.ComponentModel.ISupportInitialize)(this.gridbankadokum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDokumanListele;
        private System.Windows.Forms.DataGridView gridbankadokum;
    }
}