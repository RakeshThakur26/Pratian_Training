using StudentResultCalculatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResultWindowsFormsApplication
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1 = int.Parse(txtmarks1.Text);
                int s2 = int.Parse(txtmarks2.Text);
                int s3 = int.Parse(txtmarks3.Text);

                string result = StudentResultCalculatorClassLibrary.StudentResultCalculator.StudentCalculator(s1, s2, s3);

                txtresult.Text = $"The result of {txtname.Text} is {result}";
                if (result.Equals("Fail"))
                    Form1.ActiveForm.BackColor = Color.Red;
                else
                    Form1.ActiveForm.BackColor = Color.LightGreen;
               
            }
            catch (FormatException ex)
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
