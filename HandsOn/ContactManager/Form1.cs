using ContactManager.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Form1 : Form
    {
		private ContactRepository repo = null;
		private DataSet ds = null;
		public Form1()
		{
			repo = new ContactRepository();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ds = repo.GetContacts();
			dataGridView1.DataSource = ds;
			dataGridView1.DataMember = "Contacts";
		}

		private void button1_Click_1(object sender, EventArgs e)
        {
			repo.SaveChanges(ds);
			MessageBox.Show("Changes saved");
		}

        private void button3_Click(object sender, EventArgs e)
        {
			
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
