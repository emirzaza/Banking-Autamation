namespace Nesne1._0
{
    partial class BireyselDokum
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
            this.gridbireyseldokum = new System.Windows.Forms.DataGridView();
            this.txtdokumbireysel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbireyseldokum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridbireyseldokum)).BeginInit();
            this.SuspendLayout();
            // 
            // gridbireyseldokum
            // 
            this.gridbireyseldokum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridbireyseldokum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbireyseldokum.Location = new System.Drawing.Point(55, 73);
            this.gridbireyseldokum.Name = "gridbireyseldokum";
            this.gridbireyseldokum.RowHeadersWidth = 51;
            this.gridbireyseldokum.RowTemplate.Height = 24;
            this.gridbireyseldokum.Size = new System.Drawing.Size(709, 365);
            this.gridbireyseldokum.TabIndex = 0;
            // 
            // txtdokumbireysel
            // 
            this.txtdokumbireysel.Location = new System.Drawing.Point(244, 45);
            this.txtdokumbireysel.Name = "txtdokumbireysel";
            this.txtdokumbireysel.Size = new System.Drawing.Size(315, 22);
            this.txtdokumbireysel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "HESAP HARAKETLERİNİ GÖRMEK İSTEDİĞİNİZ HESAP NUMARASINI GİRİNİZ";
            // 
            // btnbireyseldokum
            // 
            this.btnbireyseldokum.Location = new System.Drawing.Point(571, 45);
            this.btnbireyseldokum.Name = "btnbireyseldokum";
            this.btnbireyseldokum.Size = new System.Drawing.Size(75, 23);
            this.btnbireyseldokum.TabIndex = 3;
            this.btnbireyseldokum.Text = "GÖSTER";
            this.btnbireyseldokum.UseVisualStyleBackColor = true;
            this.btnbireyseldokum.Click += new System.EventHandler(this.btnbireyseldokum_Click);
            // 
            // BireyselDokum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbireyseldokum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdokumbireysel);
            this.Controls.Add(this.gridbireyseldokum);
            this.Name = "BireyselDokum";
            this.Text = "BireyselDokum";
            this.Load += new System.EventHandler(this.BireyselDokum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridbireyseldokum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridbireyseldokum;
        private System.Windows.Forms.TextBox txtdokumbireysel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbireyseldokum;
    }
}