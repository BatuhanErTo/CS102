using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelDefteriUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = DBIslemleri.ulkeleriCek();
            comboBox1.DisplayMember = "UlkeAdi";
            comboBox1.ValueMember = "UlkeID";
            comboBox1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            DataSet ds = DBIslemleri.sehileriCek(id);
            comboBox2.DisplayMember = "Sehir";
            comboBox2.ValueMember = "SehirID";
            comboBox2.DataSource = ds.Tables[0];
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            DataSet arama = DBIslemleri.Arama(ad);
            dataGridView1.DataSource = arama.Tables[0];
            if (arama.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Kayıt yok");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string telefon = textBox3.Text;
            int SehirID = Convert.ToInt32(comboBox2.SelectedValue);
            string adress = textBox4.Text;  
            DBIslemleri.Ekle(ad,soyad,telefon,SehirID,adress);
            MessageBox.Show("Eklendi");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int kisiID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);  
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int kisiID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string tel = textBox8.Text;
                string adress = textBox9.Text;
                DBIslemleri.Guncelle(kisiID, tel, adress);
                MessageBox.Show("Güncellendi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int kisiID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                DBIslemleri.Sil(kisiID);
                MessageBox.Show("Silindi");
            }
        }
    }
}
