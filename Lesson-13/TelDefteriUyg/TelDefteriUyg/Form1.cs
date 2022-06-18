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
    }
}
