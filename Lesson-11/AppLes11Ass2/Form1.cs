using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLes11Ass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color color;
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }
        int[] ucgenCounterX = new int[3];
        int[] ucgenCounterY = new int[3];
        int ucgenCounter = 0;
        int[] lineX = new int[2];
        int[] lineY = new int[2];
        int lineCounter = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Graphics cizimAlani = panel1.CreateGraphics();
                Pen pen = new Pen(color,Convert.ToInt32(numericUpDown1.Value));
                cizimAlani.DrawEllipse(pen,e.X,e.Y,Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
            }
            else if (radioButton2.Checked == true)
            {
                Graphics cizimAlani = panel1.CreateGraphics();
                Pen pen = new Pen(color, Convert.ToInt32(numericUpDown1.Value));
                cizimAlani.DrawRectangle(pen,e.X,e.Y,Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox1.Text));
            }
            else if (radioButton3.Checked == true)
            {
                ucgenCounterX[ucgenCounter] = e.X;
                ucgenCounterY[ucgenCounter] = e.Y;
                ucgenCounter++;
                if (ucgenCounter == 3)
                {
                    ucgenCounter = 0;
                    Graphics cizimAlani = panel1.CreateGraphics();
                    Pen pen = new Pen(color, Convert.ToInt32(numericUpDown1.Value));
                    cizimAlani.DrawLine(pen,ucgenCounterX[0],ucgenCounterY[0],ucgenCounterX[1],ucgenCounterY[1]);
                    cizimAlani.DrawLine(pen, ucgenCounterX[1], ucgenCounterY[1], ucgenCounterX[2], ucgenCounterY[2]);
                    cizimAlani.DrawLine(pen, ucgenCounterX[2], ucgenCounterY[2], ucgenCounterX[0], ucgenCounterY[0]);
                }
            }
            else if (radioButton4.Checked == true)
            {
                lineX[lineCounter] = e.X;
                lineY[lineCounter] = e.Y;
                lineCounter++;
                if (lineCounter == 2)
                {
                    lineCounter = 0;
                    Graphics cizimAlani = panel1.CreateGraphics();
                    Pen pen = new Pen(color, Convert.ToInt32(numericUpDown1.Value));
                    cizimAlani.DrawLine(pen,lineX[0],lineY[0], lineX[1], lineY[1]);
                }
            }
        }
        int x, y;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                x = e.X;
                y = e.Y;
                Graphics cizimAlani = panel1.CreateGraphics();
                Pen pen = new Pen(color,5);
                cizimAlani.DrawEllipse(pen,x,y,3,3);
            }
        }
    }
}
