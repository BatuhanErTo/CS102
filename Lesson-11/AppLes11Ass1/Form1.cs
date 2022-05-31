using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLes11Ass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Blue,2.4f);
            cizimAlani.DrawRectangle(kalem, 20, 20, 20, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.Pink, 5.9f);
            cizimAlani.DrawLine(kalem, 20, 31,100,100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics cizimAlani = panel1.CreateGraphics();
            Pen kalem = new Pen(Color.CornflowerBlue,4);
            cizimAlani.DrawEllipse(kalem, 50, 50, 80, 70);
        }

        int[] x  = new int[2];
        int[] y = new int[2];
        int index1 = 0;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x[index1] = e.X; y[index1] = e.Y;
            index1++;
            if (index1 == 2)
            {
                index1 = 0;
                Graphics cizimAlani = panel2.CreateGraphics();
                Pen pen = new Pen(Color.Pink, 2f);
                cizimAlani.DrawLine(pen,x[0],y[0],x[1],y[1]);
            }
        }
    }
}
