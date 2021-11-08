
namespace YordamOrnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxS1 = new System.Windows.Forms.TextBox();
            this.txtBxS2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnHesapla
            // 
            this.bttnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnHesapla.Location = new System.Drawing.Point(50, 176);
            this.bttnHesapla.Name = "bttnHesapla";
            this.bttnHesapla.Size = new System.Drawing.Size(107, 40);
            this.bttnHesapla.TabIndex = 0;
            this.bttnHesapla.Text = "HESAPLA";
            this.bttnHesapla.UseVisualStyleBackColor = true;
            this.bttnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayi1";
            // 
            // txtBxS1
            // 
            this.txtBxS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxS1.Location = new System.Drawing.Point(152, 50);
            this.txtBxS1.Name = "txtBxS1";
            this.txtBxS1.Size = new System.Drawing.Size(100, 26);
            this.txtBxS1.TabIndex = 2;
            // 
            // txtBxS2
            // 
            this.txtBxS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxS2.Location = new System.Drawing.Point(152, 82);
            this.txtBxS2.Name = "txtBxS2";
            this.txtBxS2.Size = new System.Drawing.Size(100, 26);
            this.txtBxS2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayi2";
            // 
            // txtBxSonuc
            // 
            this.txtBxSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxSonuc.Location = new System.Drawing.Point(152, 114);
            this.txtBxSonuc.Name = "txtBxSonuc";
            this.txtBxSonuc.Size = new System.Drawing.Size(100, 26);
            this.txtBxSonuc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(183, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxS2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxS1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxS1;
        private System.Windows.Forms.TextBox txtBxS2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

