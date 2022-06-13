using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peopleupdown
{
    public partial class Form1 : Form
    {
        int step = 1;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picPeople.Image = Properties.Resources.people1;
            picPeople.BackColor = Color.Transparent;
            Random XY = new Random();
            int x = XY.Next(225, 226);
            int y = XY.Next(200, 260);
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            step++;
                Point near = new Point(this.ClientSize.Width, this.ClientSize.Height / 2 - 400);
                if (step >= 10)
                {
                    picPeople.Image = Properties.Resources.people2;
                }
                if (step > 10 && step < 15)
                {
                    picPeople.Location = new Point((this.picPeople.Location.X), (this.picPeople.Location.Y + near.Y) / 2);
                    picPeople.Image = Properties.Resources.people3;

                }
                if (step >= 15)
                {
                    picPeople.Location = new Point((this.picPeople.Location.X), (this.picPeople.Location.Y + near.Y) / 2);
                    picPeople.Image = Properties.Resources.people4;
                }
                if (step > 15 && step < 20)
                {
                    picPeople.Location = new Point((this.picPeople.Location.X), (this.picPeople.Location.Y / 2 + 10));
                    picPeople.Image = Properties.Resources.people1;
                }
                if (step>=20)
                {
                     picPeople.Image = Properties.Resources.people3;
                     step = 10;
                }
        }
    }
}
