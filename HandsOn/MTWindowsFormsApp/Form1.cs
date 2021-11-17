using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics red = panel1.CreateGraphics();
            Random rnd = new Random();
            //for (int i = 0; i < 1000; i++)
            //{
            //    int x = rnd.Next(panel1.Width);
            //    int y = rnd.Next(panel1.Height);
            //    red.DrawRectangle(Pens.Red, x, y, 20, 20);
            //    Thread.Sleep(100);
            //}
            panel1.BackColor = Color.Yellow;
            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    int x = rnd.Next(panel2.Width);
                    int y = rnd.Next(panel2.Height);
                    red.DrawRectangle(Pens.Red, x, y, 20, 20);
                    Thread.Sleep(100);
                }
            });
            t2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Graphics blue = panel2.CreateGraphics();
            Random rnd = new Random();
            panel2.BackColor = Color.Wheat ;
            Thread t1 = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    int x = rnd.Next(panel2.Width);
                    int y = rnd.Next(panel2.Height);
                    blue.DrawRectangle(Pens.Blue, x, y, 20, 20);
                    Thread.Sleep(100);
                }
            });
            t1.Start();
            
        }
    }
}
