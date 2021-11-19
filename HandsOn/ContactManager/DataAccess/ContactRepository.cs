using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace ContactManager.DataAccess
{
    class ContactRepository
    {
        private SqlDataAdapter adapter = null;
        static SqlConnection Connect()
        {
            
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-TD5N63QB;Initial Catalog=MyContactsDb;Integrated Security=True");
            return conn;
        }
        public DataSet GetContacts()
        {
            SqlConnection conn = Connect();
            string query = "select * from Contacts";
             adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Contacts");
            return ds;

        }

        public void SaveChanges(DataSet ds)
        {
            SqlCommandBuilder sql = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Contacts");
        }
        public void DeleteContact(DataSet ds)
        {
            SqlCommandBuilder sql = new SqlCommandBuilder(adapter);
            
        }
    }
}
