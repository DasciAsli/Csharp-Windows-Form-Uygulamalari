
namespace MenuStripUygulamasi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maceraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esaretinBedeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gladyatörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amelieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzüklerinEfendisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felektenBirGeceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.maceraToolStripMenuItem,
            this.komediToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esaretinBedeliToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            this.aksiyonToolStripMenuItem.Click += new System.EventHandler(this.aksiyonToolStripMenuItem_Click);
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amelieToolStripMenuItem,
            this.theNotebookToolStripMenuItem});
            this.romantikToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.romantikToolStripMenuItem.Text = "Romantik";
            // 
            // maceraToolStripMenuItem
            // 
            this.maceraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gladyatörToolStripMenuItem,
            this.yüzüklerinEfendisiToolStripMenuItem});
            this.maceraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maceraToolStripMenuItem.Name = "maceraToolStripMenuItem";
            this.maceraToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.maceraToolStripMenuItem.Text = "Macera";
            // 
            // esaretinBedeliToolStripMenuItem
            // 
            this.esaretinBedeliToolStripMenuItem.Name = "esaretinBedeliToolStripMenuItem";
            this.esaretinBedeliToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.esaretinBedeliToolStripMenuItem.Text = "Esaretin Bedeli ";
            this.esaretinBedeliToolStripMenuItem.Click += new System.EventHandler(this.esaretinBedeliToolStripMenuItem_Click);
            // 
            // gladyatörToolStripMenuItem
            // 
            this.gladyatörToolStripMenuItem.Name = "gladyatörToolStripMenuItem";
            this.gladyatörToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.gladyatörToolStripMenuItem.Text = "Gladyatör";
            this.gladyatörToolStripMenuItem.Click += new System.EventHandler(this.gladyatörToolStripMenuItem_Click);
            // 
            // amelieToolStripMenuItem
            // 
            this.amelieToolStripMenuItem.Name = "amelieToolStripMenuItem";
            this.amelieToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.amelieToolStripMenuItem.Text = "Amelie";
            this.amelieToolStripMenuItem.Click += new System.EventHandler(this.amelieToolStripMenuItem_Click);
            // 
            // yüzüklerinEfendisiToolStripMenuItem
            // 
            this.yüzüklerinEfendisiToolStripMenuItem.Name = "yüzüklerinEfendisiToolStripMenuItem";
            this.yüzüklerinEfendisiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.yüzüklerinEfendisiToolStripMenuItem.Text = "Yüzüklerin Efendisi";
            this.yüzüklerinEfendisiToolStripMenuItem.Click += new System.EventHandler(this.yüzüklerinEfendisiToolStripMenuItem_Click);
            // 
            // komediToolStripMenuItem
            // 
            this.komediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felektenBirGeceToolStripMenuItem});
            this.komediToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.komediToolStripMenuItem.Name = "komediToolStripMenuItem";
            this.komediToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.komediToolStripMenuItem.Text = "Komedi";
            // 
            // felektenBirGeceToolStripMenuItem
            // 
            this.felektenBirGeceToolStripMenuItem.Name = "felektenBirGeceToolStripMenuItem";
            this.felektenBirGeceToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.felektenBirGeceToolStripMenuItem.Text = "Felekten Bir Gece";
            this.felektenBirGeceToolStripMenuItem.Click += new System.EventHandler(this.felektenBirGeceToolStripMenuItem_Click);
            // 
            // theNotebookToolStripMenuItem
            // 
            this.theNotebookToolStripMenuItem.Name = "theNotebookToolStripMenuItem";
            this.theNotebookToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.theNotebookToolStripMenuItem.Text = "The Notebook";
            this.theNotebookToolStripMenuItem.Click += new System.EventHandler(this.theNotebookToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(196, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 226);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maceraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esaretinBedeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amelieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theNotebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gladyatörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzüklerinEfendisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felektenBirGeceToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

