using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strzelnica
{
    public partial class Form1 : Form
    {
        int licznik = 0;
        int miss = 0;
        int counter = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Random los = new Random();
            int x = los.Next(this.Width-button1.Width);
            int y = los.Next(this.Height-button1.Height);

            Point p = new Point(x, y);
            button1.Location = p;

            licznik++;
            label1.Text = licznik.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            miss++;
            label2.Text = miss.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            label5.Text = counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Trafionych: "+ label1.Text+"  Nietrafionych: "+ label2.Text );
                counter = 10;
                licznik = 0;
                miss = 0;
                label1.Text = 0.ToString();
                label2.Text = 0.ToString();

                

            }
            label5.Text = counter.ToString();

        }






    }
}
