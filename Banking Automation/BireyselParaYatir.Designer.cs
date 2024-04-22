
namespace Nesne1._0
{
    partial class BireyselParaYatir
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
            this.btnBireyselParaCek = new System.Windows.Forms.Button();
            this.txtyatırılanparabireysel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txthesapnoparayatır = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBireyselParaCek);
            this.groupBox1.Controls.Add(this.txtyatırılanparabireysel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "💲💸";
            // 
            // btnBireyselParaCek
            // 
            this.btnBireyselParaCek.Location = new System.Drawing.Point(77, 151);
            this.btnBireyselParaCek.Name = "btnBireyselParaCek";
            this.btnBireyselParaCek.Size = new System.Drawing.Size(136, 32);
            this.btnBireyselParaCek.TabIndex = 13;
            this.btnBireyselParaCek.Text = "Tamamdır👍";
            this.btnBireyselParaCek.UseVisualStyleBackColor = true;
            this.btnBireyselParaCek.Click += new System.EventHandler(this.btnBireyselParaCek_Click);
            // 
            // txtyatırılanparabireysel
            // 
            this.txtyatırılanparabireysel.Location = new System.Drawing.Point(44, 85);
            this.txtyatırılanparabireysel.Mask = "000";
            this.txtyatırılanparabireysel.Name = "txtyatırılanparabireysel";
            this.txtyatırılanparabireysel.Size = new System.Drawing.Size(212, 22);
            this.txtyatırılanparabireysel.TabIndex = 12;
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
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "yatırmak istediğiniz hesap numarasını giriniz";
            // 
            // txthesapnoparayatır
            // 
            this.txthesapnoparayatır.Location = new System.Drawing.Point(49, 65);
            this.txthesapnoparayatır.Name = "txthesapnoparayatır";
            this.txthesapnoparayatır.Size = new System.Drawing.Size(302, 22);
            this.txthesapnoparayatır.TabIndex = 14;
            // 
            // BireyselParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 357);
            this.Controls.Add(this.txthesapnoparayatır);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BireyselParaYatir";
            this.Text = "ParaYatir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBireyselParaCek;
        private System.Windows.Forms.MaskedTextBox txtyatırılanparabireysel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthesapnoparayatır;
    }
}