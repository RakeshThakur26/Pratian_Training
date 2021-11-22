using EFCotactManagement.DataAccessDb1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContactManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact contact = new Contact { FirstName = "Rakesh", MiddleName = "Singh", LastName = "Thakur", Email = "Rakesh@email", Gender = "Male", Location = "Bidar", Mobile = "12345" };
            ContactsModel cm = new ContactsModel();
            cm.Contacts.Add(contact);

            cm.SaveChanges();
            Console.WriteLine("New Contact is added");

            Console.ReadLine();

        }
    }
}
