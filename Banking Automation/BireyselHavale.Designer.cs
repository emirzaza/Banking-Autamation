
namespace Nesne1._0
{
    partial class BireyselHavale
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBireyselHavale = new System.Windows.Forms.Button();
            this.txtbireyselhavalemiktar = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbireyselhavalealıcı = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbireyselhavalegönderici = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "kullanmak istediğiniz hesabın numarasını giriniz";
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
            // btnBireyselHavale
            // 
            this.btnBireyselHavale.Location = new System.Drawing.Point(81, 237);
            this.btnBireyselHavale.Name = "btnBireyselHavale";
            this.btnBireyselHavale.Size = new System.Drawing.Size(162, 32);
            this.btnBireyselHavale.TabIndex = 16;
            this.btnBireyselHavale.Text = "Tamamdır👍";
            this.btnBireyselHavale.UseVisualStyleBackColor = true;
            this.btnBireyselHavale.Click += new System.EventHandler(this.btnBireyselHavale_Click);
            // 
            // txtbireyselhavalemiktar
            // 
            this.txtbireyselhavalemiktar.Location = new System.Drawing.Point(23, 171);
            this.txtbireyselhavalemiktar.Mask = "000";
            this.txtbireyselhavalemiktar.Name = "txtbireyselhavalemiktar";
            this.txtbireyselhavalemiktar.Size = new System.Drawing.Size(278, 22);
            this.txtbireyselhavalemiktar.TabIndex = 15;
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
            // txtbireyselhavalealıcı
            // 
            this.txtbireyselhavalealıcı.Location = new System.Drawing.Point(23, 73);
            this.txtbireyselhavalealıcı.Mask = "00000000000000000000000000";
            this.txtbireyselhavalealıcı.Name = "txtbireyselhavalealıcı";
            this.txtbireyselhavalealıcı.Size = new System.Drawing.Size(278, 22);
            this.txtbireyselhavalealıcı.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBireyselHavale);
            this.groupBox1.Controls.Add(this.txtbireyselhavalealıcı);
            this.groupBox1.Controls.Add(this.txtbireyselhavalemiktar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(39, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 301);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "💸💲";
            // 
            // txtbireyselhavalegönderici
            // 
            this.txtbireyselhavalegönderici.Location = new System.Drawing.Point(39, 68);
            this.txtbireyselhavalegönderici.Name = "txtbireyselhavalegönderici";
            this.txtbireyselhavalegönderici.Size = new System.Drawing.Size(325, 22);
            this.txtbireyselhavalegönderici.TabIndex = 18;
            // 
            // BireyselHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.txtbireyselhavalegönderici);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BireyselHavale";
            this.Text = "BireyselHavale";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBireyselHavale;
        private System.Windows.Forms.MaskedTextBox txtbireyselhavalemiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtbireyselhavalealıcı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbireyselhavalegönderici;
    }
}