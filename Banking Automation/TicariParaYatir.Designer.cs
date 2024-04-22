
namespace Nesne1._0
{
    partial class TicariParaYatir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTicariParayatir = new System.Windows.Forms.Button();
            this.txtticariparayatirmiktar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtticariparayatirhesapno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTicariParayatir);
            this.groupBox1.Controls.Add(this.txtticariparayatirmiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 222);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "💲💸";
            // 
            // btnTicariParayatir
            // 
            this.btnTicariParayatir.Location = new System.Drawing.Point(77, 151);
            this.btnTicariParayatir.Name = "btnTicariParayatir";
            this.btnTicariParayatir.Size = new System.Drawing.Size(136, 32);
            this.btnTicariParayatir.TabIndex = 13;
            this.btnTicariParayatir.Text = "Tamamdır👍";
            this.btnTicariParayatir.UseVisualStyleBackColor = true;
            this.btnTicariParayatir.Click += new System.EventHandler(this.btnTicariParayatir_Click);
            // 
            // txtticariparayatirmiktar
            // 
            this.txtticariparayatirmiktar.Location = new System.Drawing.Point(44, 85);
            this.txtticariparayatirmiktar.Mask = "000";
            this.txtticariparayatirmiktar.Name = "txtticariparayatirmiktar";
            this.txtticariparayatirmiktar.Size = new System.Drawing.Size(212, 22);
            this.txtticariparayatirmiktar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yatırmak istediğiniz tutarı giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "hesabınızı seçiniz";
            // 
            // txtticariparayatirhesapno
            // 
            this.txtticariparayatirhesapno.Location = new System.Drawing.Point(54, 119);
            this.txtticariparayatirhesapno.Name = "txtticariparayatirhesapno";
            this.txtticariparayatirhesapno.Size = new System.Drawing.Size(302, 22);
            this.txtticariparayatirhesapno.TabIndex = 15;
            // 
            // TicariParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.txtticariparayatirhesapno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TicariParaYatir";
            this.Text = "TicariParaYatir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTicariParayatir;
        private System.Windows.Forms.MaskedTextBox txtticariparayatirmiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtticariparayatirhesapno;
    }
}