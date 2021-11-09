using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentResultCalculatorLibrary;

namespace StudentResultWindowsFormsApp
{
    public partial class StudentResultCalculator : Form
    {
        public StudentResultCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = int.Parse(txtmark1.Text);
                int s2 = int.Parse(txtmarks3.Text);
                int s3 = int.Parse(textBox4.Text);

                string result = StudentCalculatorClass.StudentCalculator(s1, s2, s3);

                txtresult.Text = $"The result of {txtname.Text} is {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numeric data..");
            }
            catch (InvalidMarksException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
