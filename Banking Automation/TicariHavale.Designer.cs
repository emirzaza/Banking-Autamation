
namespace Nesne1._0
{
    partial class TicariHavale
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTicariHavale = new System.Windows.Forms.Button();
            this.txtticarihavalealıcıhesapno = new System.Windows.Forms.MaskedTextBox();
            this.txtticarihavalemiktar = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtticarihavalevericino = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTicariHavale);
            this.groupBox1.Controls.Add(this.txtticarihavalealıcıhesapno);
            this.groupBox1.Controls.Add(this.txtticarihavalemiktar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(52, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 301);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "💸💲";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alıcı Hesap No";
            // 
            // btnTicariHavale
            // 
            this.btnTicariHavale.Location = new System.Drawing.Point(81, 237);
            this.btnTicariHavale.Name = "btnTicariHavale";
            this.btnTicariHavale.Size = new System.Drawing.Size(162, 32);
            this.btnTicariHavale.TabIndex = 16;
            this.btnTicariHavale.Text = "Tamamdır👍";
            this.btnTicariHavale.UseVisualStyleBackColor = true;
            this.btnTicariHavale.Click += new System.EventHandler(this.btnTicariHavale_Click);
            // 
            // txtticarihavalealıcıhesapno
            // 
            this.txtticarihavalealıcıhesapno.Location = new System.Drawing.Point(23, 73);
            this.txtticarihavalealıcıhesapno.Mask = "00000000000000000000000000";
            this.txtticarihavalealıcıhesapno.Name = "txtticarihavalealıcıhesapno";
            this.txtticarihavalealıcıhesapno.Size = new System.Drawing.Size(278, 22);
            this.txtticarihavalealıcıhesapno.TabIndex = 17;
            // 
            // txtticarihavalemiktar
            // 
            this.txtticarihavalemiktar.Location = new System.Drawing.Point(23, 171);
            this.txtticarihavalemiktar.Mask = "000";
            this.txtticarihavalemiktar.Name = "txtticarihavalemiktar";
            this.txtticarihavalemiktar.Size = new System.Drawing.Size(278, 22);
            this.txtticarihavalemiktar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Havale Miktarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "kullanmak istediğiniz hesap numarasınız giriniz";
            // 
            // txtticarihavalevericino
            // 
            this.txtticarihavalevericino.Location = new System.Drawing.Point(52, 74);
            this.txtticarihavalevericino.Name = "txtticarihavalevericino";
            this.txtticarihavalevericino.Size = new System.Drawing.Size(325, 22);
            this.txtticarihavalevericino.TabIndex = 22;
            // 
            // TicariHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.txtticarihavalevericino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TicariHavale";
            this.Text = "TicariHavale";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTicariHavale;
        private System.Windows.Forms.MaskedTextBox txtticarihavalealıcıhesapno;
        private System.Windows.Forms.MaskedTextBox txtticarihavalemiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtticarihavalevericino;
    }
}