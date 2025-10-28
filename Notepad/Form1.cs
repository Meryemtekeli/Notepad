using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GelismisNotDefteri
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        private bool isTextChanged = false;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.TextChanged += RichTextBox1_TextChanged;
            this.FormClosing += Form1_FormClosing;

            SetLightTheme();
            UpdateStatusCounts();
            UpdateTitle();
        }

        // ---------------- DOSYA ----------------
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveIfNeeded()) return;
            richTextBox1.Clear();
            currentFilePath = null;
            isTextChanged = false;
            UpdateTitle();
            UpdateStatusCounts();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptSaveIfNeeded()) return;
            openFileDialog1.Filter = "Text Files|*.txt|Rich Text|*.rtf|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = Path.GetExtension(openFileDialog1.FileName).ToLower();
                    if (ext == ".rtf")
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.UTF8);

                    currentFilePath = openFileDialog1.FileName;
                    isTextChanged = false;
                    UpdateTitle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açılamadı: " + ex.Message);
                }
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile(false);
        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile(true);
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void SaveFile(bool saveAs)
        {
            try
            {
                if (saveAs || string.IsNullOrEmpty(currentFilePath))
                {
                    saveFileDialog1.Filter = "Text Files|*.txt|Rich Text|*.rtf|All Files|*.*";
                    if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                    currentFilePath = saveFileDialog1.FileName;
                }

                string ext = Path.GetExtension(currentFilePath).ToLower();
                if (ext == ".rtf")
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                else
                    File.WriteAllText(currentFilePath, richTextBox1.Text, Encoding.UTF8);

                isTextChanged = false;
                UpdateTitle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message);
            }
        }

        // ---------------- DÜZEN ----------------
        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo) richTextBox1.Undo();
        }
        private void ileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İleri (Redo) basit sürümde desteklenmiyor.");
        }
        private void kesToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Cut();
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Copy();
        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox1.Paste();

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aranacak = Interaction.InputBox("Aranacak metni yazın:", "Bul");
            if (string.IsNullOrEmpty(aranacak)) return;

            int index = richTextBox1.Text.IndexOf(aranacak, StringComparison.CurrentCultureIgnoreCase);
            if (index >= 0)
            {
                richTextBox1.Select(index, aranacak.Length);
                richTextBox1.ScrollToCaret();
                richTextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Metin bulunamadı.");
            }
        }

        // ---------------- BİÇİM ----------------
        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont ?? richTextBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.SelectionFont = fontDialog1.Font;
                else
                    richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void yaziRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength > 0)
                    richTextBox1.SelectionColor = colorDialog1.Color;
                else
                    richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        // ---------------- TEMA ----------------
        private void acikTemaToolStripMenuItem_Click(object sender, EventArgs e) => SetLightTheme();
        private void koyuTemaToolStripMenuItem_Click(object sender, EventArgs e) => SetDarkTheme();

        private void SetLightTheme()
        {
            this.BackColor = SystemColors.Control;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ForeColor = Color.Black;
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.ForeColor = Color.Black;
        }

        private void SetDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.BackColor = Color.FromArgb(25, 25, 25);
            richTextBox1.ForeColor = Color.Gainsboro;
            menuStrip1.BackColor = Color.FromArgb(45, 45, 45);
            menuStrip1.ForeColor = Color.Gainsboro;
            statusStrip1.BackColor = Color.FromArgb(45, 45, 45);
            statusStrip1.ForeColor = Color.Gainsboro;
        }

        // ---------------- YARDIM ----------------
        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Gelişmiş Not Defteri\nYapımcı: Sen ❤️\nTarih: " + DateTime.Now.ToShortDateString();
            MessageBox.Show(msg, "Hakkında", MessageBoxButtons.OK);
        }

        // ---------------- DURUM ÇUBUĞU ----------------
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            isTextChanged = true;
            UpdateStatusCounts();
        }

        private void UpdateStatusCounts()
        {
            string text = richTextBox1.Text;
            int charCount = text.Length;
            int wordCount = 0;
            if (!string.IsNullOrWhiteSpace(text))
            {
                wordCount = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            toolStripStatusLabelChars.Text = $"Karakter: {charCount}";
            toolStripStatusLabelWords.Text = $"Kelime: {wordCount}";
        }

        // ---------------- FORM KAPANIŞI ----------------
        private bool PromptSaveIfNeeded()
        {
            if (!isTextChanged) return true;

            var dr = MessageBox.Show("Değişiklikler kaydedilsin mi?", "Kaydet", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                SaveFile(false);
                return !isTextChanged;
            }
            else if (dr == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PromptSaveIfNeeded()) e.Cancel = true;
        }

        private void UpdateTitle()
        {
            string name = string.IsNullOrEmpty(currentFilePath) ? "Yeni Belge" : Path.GetFileName(currentFilePath);
            this.Text = $"{name} - Gelişmiş Not Defteri{(isTextChanged ? " *" : "")}";
        }

        // ---------------- BOŞ EVENTLER (Hata önleme) ----------------
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void toolStripStatusLabelWords_Click(object sender, EventArgs e) { }
        private void toolStripStatusLabelChars_Click(object sender, EventArgs e) { }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void fontDialog1_Apply(object sender, EventArgs e) { }
    }
}
