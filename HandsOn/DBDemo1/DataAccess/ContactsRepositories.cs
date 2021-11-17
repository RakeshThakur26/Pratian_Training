using DBDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DBDemo1.DataAccess
{
    interface IContactRepository
    {
        void SaveContacts(Contact contact);
        void DeleteContact(int contactId);
        void EditContacts(int contactId, string loc);
        List<Contact> GetAllContacts();
        Contact GetContact(int contactId);
        List<Contact> GetContactByLocation(string location);


    }
    class ContactsRepositories : IContactRepository
    {
        static SqlConnection Connect()
        {
            string connstring = ConfigurationManager.ConnectionStrings["contacts"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstring);
            return conn;
        }

        public void SaveContacts(Contact contact)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = $"insert into Contacts values (@id,@fn,@mn,@ln,@g,@l,@m,@e)";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@id", contact.ContactID);
                sql.Parameters.AddWithValue("@fn", contact.FirstName);
                sql.Parameters.AddWithValue("@mn", contact.MiddleName);
                sql.Parameters.AddWithValue("@ln", contact.LastName);
                sql.Parameters.AddWithValue("@g", contact.Gender);
                sql.Parameters.AddWithValue("@l", contact.Location);
                sql.Parameters.AddWithValue("@m", contact.Mobile);
                sql.Parameters.AddWithValue("@e", contact.Email);
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteContact(int contactId)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_deleteContactById";
              
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@id",contactId);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void EditContacts(int contactId, string loc)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = $"Update Contacts set Location='{loc}' where ContactID = @id";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@id", contactId);

                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        
        public Contact GetContact(int contactId)
        {
            Contact contact = null;

            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_getContactById";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@id", contactId);
                
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();
                contact = new Contact();
                contact.ContactID = (int)reader[0];
                contact.FirstName = reader.GetString(1);
                contact.MiddleName = reader.GetString(2);
                contact.LastName = reader.GetString(3);
                contact.Gender = reader.GetString(4);
                contact.Location = reader.GetString(5);
                contact.Mobile = reader.GetString(6);
                contact.Email = reader.GetString(7);

            }
            finally
            {
                conn.Close();
            }
            return contact;
        }

        
        public List<Contact> GetContactByLocation(string location)
        {
            List<Contact> contacts = new List<Contact>();

            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_getContactsByLocation @l";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@l", location);
                sql.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Contact contact = new Contact();

                        contact.ContactID = (int)reader[0];
                        contact.FirstName = reader.GetString(1);
                        contact.MiddleName = reader.GetString(2);
                        contact.LastName = reader.GetString(3);
                        contact.Gender = reader.GetString(4);
                        contact.Location = reader.GetString(5);
                        contact.Mobile = reader.GetString(6);
                        contact.Email = reader.GetString(7);

                        contacts.Add(contact);
                    }
                }

            }
            finally
            {
                conn.Close();
            }
            return contacts;

        }

         public List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();

            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_getContacts";
                SqlCommand sql = new SqlCommand(query, conn);
                SqlDataReader reader = sql.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Contact contact = new Contact();

                        contact.ContactID = (int)reader[0];
                        contact.FirstName = reader.GetString(1);
                        contact.MiddleName = reader.GetString(2);
                        contact.LastName = reader.GetString(3);
                        contact.Gender = reader.GetString(4);
                        contact.Location = reader.GetString(5);
                        contact.Mobile = reader.GetString(6);
                        contact.Email = reader.GetString(7);

                        contacts.Add(contact);
                    }
                }

            }
            finally
            {
                conn.Close();
            }
            return contacts;

        }


    }

}
