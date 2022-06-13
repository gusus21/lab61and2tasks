using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 3);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Сектор еліпса
            Rectangle rect = new Rectangle(100, 400, 200, 100);
            float startAngle = 0.0F;
            float sweepAngle = 60.0F;
            //g.DrawEllipse(pen, rect); // Показує що це справді сектор
            g.DrawPie(pen, rect, startAngle, sweepAngle);

            // Зафарбований трикутник
            Point[] trianglePoints =
             {
                 new Point(100, 50),
                 new Point(60, 150),
                 new Point(200, 150)
             };
            g.FillPolygon(brush, trianglePoints);

            // Ромб
            Point[] rhombPoints =
            {
                new Point(600, 500),
                new Point(550, 600),
                new Point(600, 700),
                new Point(650, 600)
             };
            g.DrawPolygon(pen, rhombPoints);

            // Прямокутник
            g.DrawRectangle(pen, 450, 250, 200, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 3);
            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            SolidBrush greenBrush = new SolidBrush(Color.Green);

            g.FillRectangle(brownBrush, 500, 700, 50, 75);

            Point[] trianglePoints1 =
             {
                 new Point(375, 700),
                 new Point(525, 600),
                 new Point(675, 700)
             };
            g.FillPolygon(greenBrush, trianglePoints1);
            Point[] trianglePoints2 =
             {
                 new Point(425, 625),
                 new Point(525, 525),
                 new Point(625, 625)
             };
            g.FillPolygon(greenBrush, trianglePoints2);
            Point[] trianglePoints3 =
             {
                 new Point(475, 550),
                 new Point(525, 450),
                 new Point(575, 550)
             };
            g.FillPolygon(greenBrush, trianglePoints3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
