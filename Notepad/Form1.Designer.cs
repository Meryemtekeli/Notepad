using System;
using System.Drawing;
using System.Windows.Forms;

namespace GelismisNotDefteri
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farkliKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acikTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koyuTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWords;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelChars;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farkliKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapistirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acikTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koyuTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelChars = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            // 
            // Form ayarları
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Gelişmiş Not Defteri";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.dosyaToolStripMenuItem,
                this.duzenToolStripMenuItem,
                this.bicimToolStripMenuItem,
                this.temaToolStripMenuItem,
                this.yardimToolStripMenuItem
            });
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.yeniToolStripMenuItem,
                this.acToolStripMenuItem,
                this.kaydetToolStripMenuItem,
                this.farkliKaydetToolStripMenuItem,
                this.cikisToolStripMenuItem
            });
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // Menü öğeleri text ve click
            // 
            this.yeniToolStripMenuItem.Text = "Yeni"; this.yeniToolStripMenuItem.Click += new EventHandler(this.yeniToolStripMenuItem_Click);
            this.acToolStripMenuItem.Text = "Aç"; this.acToolStripMenuItem.Click += new EventHandler(this.acToolStripMenuItem_Click);
            this.kaydetToolStripMenuItem.Text = "Kaydet"; this.kaydetToolStripMenuItem.Click += new EventHandler(this.kaydetToolStripMenuItem_Click);
            this.farkliKaydetToolStripMenuItem.Text = "Farklı Kaydet"; this.farkliKaydetToolStripMenuItem.Click += new EventHandler(this.farkliKaydetToolStripMenuItem_Click);
            this.cikisToolStripMenuItem.Text = "Çıkış"; this.cikisToolStripMenuItem.Click += new EventHandler(this.cikisToolStripMenuItem_Click);

            this.duzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.geriAlToolStripMenuItem, this.ileriToolStripMenuItem, this.kesToolStripMenuItem, this.kopyalaToolStripMenuItem, this.yapistirToolStripMenuItem, this.bulToolStripMenuItem
            });
            this.duzenToolStripMenuItem.Text = "Düzen";
            this.geriAlToolStripMenuItem.Text = "Geri Al"; this.geriAlToolStripMenuItem.Click += new EventHandler(this.geriAlToolStripMenuItem_Click);
            this.ileriToolStripMenuItem.Text = "İleri"; this.ileriToolStripMenuItem.Click += new EventHandler(this.ileriToolStripMenuItem_Click);
            this.kesToolStripMenuItem.Text = "Kes"; this.kesToolStripMenuItem.Click += new EventHandler(this.kesToolStripMenuItem_Click);
            this.kopyalaToolStripMenuItem.Text = "Kopyala"; this.kopyalaToolStripMenuItem.Click += new EventHandler(this.kopyalaToolStripMenuItem_Click);
            this.yapistirToolStripMenuItem.Text = "Yapıştır"; this.yapistirToolStripMenuItem.Click += new EventHandler(this.yapistirToolStripMenuItem_Click);
            this.bulToolStripMenuItem.Text = "Bul"; this.bulToolStripMenuItem.Click += new EventHandler(this.bulToolStripMenuItem_Click);

            this.bicimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.yaziTipiToolStripMenuItem, this.yaziRengiToolStripMenuItem });
            this.bicimToolStripMenuItem.Text = "Biçim";
            this.yaziTipiToolStripMenuItem.Text = "Yazı Tipi"; this.yaziTipiToolStripMenuItem.Click += new EventHandler(this.yaziTipiToolStripMenuItem_Click);
            this.yaziRengiToolStripMenuItem.Text = "Yazı Rengi"; this.yaziRengiToolStripMenuItem.Click += new EventHandler(this.yaziRengiToolStripMenuItem_Click);

            this.temaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.acikTemaToolStripMenuItem, this.koyuTemaToolStripMenuItem });
            this.temaToolStripMenuItem.Text = "Tema";
            this.acikTemaToolStripMenuItem.Text = "Açık"; this.acikTemaToolStripMenuItem.Click += new EventHandler(this.acikTemaToolStripMenuItem_Click);
            this.koyuTemaToolStripMenuItem.Text = "Koyu"; this.koyuTemaToolStripMenuItem.Click += new EventHandler(this.koyuTemaToolStripMenuItem_Click);

            this.yardimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.hakkindaToolStripMenuItem });
            this.yardimToolStripMenuItem.Text = "Yardım";
            this.hakkindaToolStripMenuItem.Text = "Hakkında"; this.hakkindaToolStripMenuItem.Click += new EventHandler(this.hakkindaToolStripMenuItem_Click);

            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabelWords, this.toolStripStatusLabelChars });
            this.toolStripStatusLabelWords.Text = "Kelime: 0";
            this.toolStripStatusLabelChars.Text = "Karakter: 0";

            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = DockStyle.Fill;
            this.richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
            this.richTextBox1.BackColor = Color.White;
            this.richTextBox1.ForeColor = Color.Black;
        }
    }
}
