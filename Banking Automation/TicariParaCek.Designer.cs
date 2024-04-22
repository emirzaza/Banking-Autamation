
namespace Nesne1._0
{
    partial class TicariParaCek
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
            this.btnCekticari = new System.Windows.Forms.Button();
            this.txtticariparacekmiktar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtticariparacekhesapno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCekticari);
            this.groupBox1.Controls.Add(this.txtticariparacekmiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(45, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "💲💸";
            // 
            // btnCekticari
            // 
            this.btnCekticari.Location = new System.Drawing.Point(77, 155);
            this.btnCekticari.Name = "btnCekticari";
            this.btnCekticari.Size = new System.Drawing.Size(136, 32);
            this.btnCekticari.TabIndex = 13;
            this.btnCekticari.Text = "Tamamdır👍";
            this.btnCekticari.UseVisualStyleBackColor = true;
            this.btnCekticari.Click += new System.EventHandler(this.btnCekticari_Click);
            // 
            // txtticariparacekmiktar
            // 
            this.txtticariparacekmiktar.Location = new System.Drawing.Point(44, 85);
            this.txtticariparacekmiktar.Mask = "000";
            this.txtticariparacekmiktar.Name = "txtticariparacekmiktar";
            this.txtticariparacekmiktar.Size = new System.Drawing.Size(212, 22);
            this.txtticariparacekmiktar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Çekmek istediğiniz tutarı giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Para Çekmek İstediğiniz Hesap Numarasını giriniz";
            // 
            // txtticariparacekhesapno
            // 
            this.txtticariparacekhesapno.Location = new System.Drawing.Point(45, 112);
            this.txtticariparacekhesapno.Name = "txtticariparacekhesapno";
            this.txtticariparacekhesapno.Size = new System.Drawing.Size(302, 22);
            this.txtticariparacekhesapno.TabIndex = 14;
            // 
            // TicariParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.txtticariparacekhesapno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TicariParaCek";
            this.Text = "TicariParaCek";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCekticari;
        private System.Windows.Forms.MaskedTextBox txtticariparacekmiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtticariparacekhesapno;
    }
}