
namespace Nesne1._0
{
    partial class BireyselParaCek
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.txtbireyselparacekmiktar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbireyselparacekhesapno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "hesabınızı seçiniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCek);
            this.groupBox1.Controls.Add(this.txtbireyselparacekmiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(47, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "💲💸";
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(77, 155);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(136, 32);
            this.btnCek.TabIndex = 13;
            this.btnCek.Text = "Tamamdır👍";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // txtbireyselparacekmiktar
            // 
            this.txtbireyselparacekmiktar.Location = new System.Drawing.Point(44, 85);
            this.txtbireyselparacekmiktar.Mask = "000";
            this.txtbireyselparacekmiktar.Name = "txtbireyselparacekmiktar";
            this.txtbireyselparacekmiktar.Size = new System.Drawing.Size(212, 22);
            this.txtbireyselparacekmiktar.TabIndex = 12;
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
            // txtbireyselparacekhesapno
            // 
            this.txtbireyselparacekhesapno.Location = new System.Drawing.Point(47, 53);
            this.txtbireyselparacekhesapno.Name = "txtbireyselparacekhesapno";
            this.txtbireyselparacekhesapno.Size = new System.Drawing.Size(308, 22);
            this.txtbireyselparacekhesapno.TabIndex = 9;
            // 
            // BireyselParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 357);
            this.Controls.Add(this.txtbireyselparacekhesapno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BireyselParaCek";
            this.Text = "ParaCek";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.MaskedTextBox txtbireyselparacekmiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbireyselparacekhesapno;
    }
}