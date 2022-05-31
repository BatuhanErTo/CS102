using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLes10Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc = textBox1.Text;
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            string polikinlik = comboBox1.SelectedItem.ToString();
            string dateTime = dateTimePicker1.Value.ToShortDateString();
            string saat = comboBox2.SelectedItem.ToString();

            if (!Randevu.VarMi(polikinlik,dateTime,saat))
            {
                Randevu.Ekle(tc, ad, soyad, polikinlik, dateTime, saat);
                MessageBox.Show("Randevu sisteme eklendi");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;   
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = Randevu.Yazdir();
            textBox4.Text = metin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            string klinik = comboBox3.SelectedItem.ToString();
            string tarih = dateTimePicker2.Value.ToShortDateString();
            form2.textBox1.Text = Randevu.Search(klinik, tarih);
            form2.ShowDialog();
            form2 = null;
            this.Show();
        }
    }
}
