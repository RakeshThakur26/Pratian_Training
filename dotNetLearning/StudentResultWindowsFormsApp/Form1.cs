using StudentResultCalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = int.Parse(textBox2.Text);
                int s2 = int.Parse(textBox3.Text);
                int s3 = int.Parse(textBox4.Text);
                ResultCalculator calculator = new ResultCalculator(new EmailNotification());
                string result = calculator.CalculateResult(s1, s2, s3);
                textBox5.Text = $"The result of {textBox1.Text} is {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only interger numbers");
                
            }
            catch(InvalidMarksException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
