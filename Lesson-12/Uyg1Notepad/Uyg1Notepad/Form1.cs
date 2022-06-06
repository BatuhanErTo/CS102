using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg1Notepad
{
    public partial class Form1 : Form
    {
        bool acikDosyaVarMi = false;
        bool degisiklikVarMi = false;
        string acikDosyaAdi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acikDosyaVarMi == false)
            {
                if (degisiklikVarMi == false)
                {
                    createFile();
                }
                else
                {
                    DialogResult click1 = MessageBox.Show("Kaydedilsin mi?", "Notepad", MessageBoxButtons.YesNoCancel); 
                    if (click1 == DialogResult.Yes)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        DialogResult click2 = saveFileDialog.ShowDialog();
                        if (click2 == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.PlainText);
                            createFile();
                        }
                    }
                    else if (click1 == DialogResult.No)
                    {
                        createFile();
                    }
                }
            }
            else
            {
                if (degisiklikVarMi == false)
                {
                    createFile();
                }
                else
                {
                    DialogResult click1 = MessageBox.Show("Kaydedilsin mi?", "Notepad", MessageBoxButtons.YesNoCancel);
                    if (click1 == DialogResult.Yes)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        DialogResult click2 = saveFileDialog.ShowDialog();
                        if (click2 == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                            createFile();
                        }
                    }
                    else if (click1 == DialogResult.No)
                    {
                        createFile();
                    }
                }
            }
        }

        public void createFile()
        {
           acikDosyaVarMi = false;
           degisiklikVarMi = false;
           richTextBox1.Clear();
        }

        public void dosyaAcmaIslemleri()
        {
            OpenFileDialog od = new OpenFileDialog();
            DialogResult basilan=od.ShowDialog();
            if (basilan == DialogResult.OK)
            {
                acikDosyaAdi = od.FileName;
                richTextBox1.LoadFile(acikDosyaAdi, RichTextBoxStreamType.PlainText);
                acikDosyaVarMi = true;
                degisiklikVarMi = false;
            }
        }
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acikDosyaVarMi == false)
            {
                if (degisiklikVarMi == false)
                {
                    dosyaAcmaIslemleri();
                }
                else
                {
                    DialogResult basilan = MessageBox.Show("Kaydedilsin mi?", "Notepad", MessageBoxButtons.YesNoCancel);
                    if (basilan == DialogResult.No)
                        dosyaAcmaIslemleri();
                    else if (basilan == DialogResult.Yes)
                    {
                        SaveFileDialog sd = new SaveFileDialog();
                        DialogResult basilan2 = sd.ShowDialog();
                        if (basilan2 == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(sd.FileName, RichTextBoxStreamType.PlainText);
                            dosyaAcmaIslemleri();
                        }
                    }

                }
            }//if acikdosyaVarmi
            else
            {
                if (degisiklikVarMi == false)
                    dosyaAcmaIslemleri();
                else
                {
                   DialogResult basilan=MessageBox.Show("Kaydedilsin mi?", "Notepad", MessageBoxButtons.YesNoCancel);
                    if (basilan == DialogResult.No)
                        dosyaAcmaIslemleri();
                    else if (basilan == DialogResult.Yes)
                    {
                        richTextBox1.SaveFile(acikDosyaAdi, RichTextBoxStreamType.PlainText);
                        dosyaAcmaIslemleri();
                    }
                }
            }
        }
        public void saveIslemleri()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            degisiklikVarMi = true;
        }
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acikDosyaVarMi == false)
            {
                if (degisiklikVarMi == false)
                {
                    saveIslemleri();
                }
                else
                {
                    saveIslemleri();
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (degisiklikVarMi == false)
                {
                    richTextBox1.SaveFile(acikDosyaAdi, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.SaveFile(acikDosyaAdi, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            degisiklikVarMi = true;
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sözcükKaydırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sözcükKaydırToolStripMenuItem.Checked = !sözcükKaydırToolStripMenuItem.Checked;
            richTextBox1.WordWrap = sözcükKaydırToolStripMenuItem.Checked;
        }

        private void durumÇubuğuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumÇubuğuToolStripMenuItem.Checked = !durumÇubuğuToolStripMenuItem.Checked;
            statusStrip1.Visible = durumÇubuğuToolStripMenuItem.Checked;
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acikDosyaVarMi == false)
            {
                if (degisiklikVarMi == false)
                {
                    saveIslemleri();
                }
                else
                {
                    saveIslemleri();
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (degisiklikVarMi == false)
                {
                    saveIslemleri();
                }
                else
                {
                    saveIslemleri();
                }
            }
        }
    }
}
