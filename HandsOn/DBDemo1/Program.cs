using DBDemo1.DataAccess;
using DBDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            IContactRepository ContactOperation = new ContactsRepositories();
            Contact contact = new Contact();

            while (true)
            {
                Console.WriteLine("1. Enter Contact details\n2. Get Contact by Id\n3. Delete Contact by Id\n4. Edit Contact\n5. Get Contact by Location\n6. Get All Contacts");
                Console.WriteLine("Please select operation");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:  Console.WriteLine("Enter contact Id :");
                            contact.ContactID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter First Name :");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter Middle Name :");
                            contact.MiddleName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name :");
                            contact.LastName = Console.ReadLine();
                            Console.WriteLine("Enter Gender :");
                            contact.Gender = Console.ReadLine();
                            Console.WriteLine("Enter Location :");
                            contact.Location = Console.ReadLine();
                            Console.WriteLine("Enter Mobile :");
                            contact.Mobile = Console.ReadLine();
                            Console.WriteLine("Enter Email :");
                            contact.Email = Console.ReadLine();

                             ContactOperation.SaveContacts(contact);
                             Console.WriteLine("Data Entered Successfully..");
                            break;

                    case 2:
                        Console.WriteLine("Enter Contact id to get data");
                        int id = int.Parse(Console.ReadLine());
                        contact = ContactOperation.GetContact(id);
                        Console.WriteLine(contact.ContactID + ", " + contact.FirstName);

                        break;

                    case 3:
                        Console.WriteLine("Enter Contact id to delete");
                        int deleteid = int.Parse(Console.ReadLine());
                        
                        ContactOperation.DeleteContact(deleteid); 
                        break;

                    case 4:
                        Console.WriteLine("Enter Contact id to edit");
                        int editId = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Enter new location to update");
                        string location = Console.ReadLine();
                                                
                        ContactOperation.EditContacts(editId, location); break;

                    case 5:
                        Console.WriteLine("Enter location");
                        string locationname = Console.ReadLine();

                        List<Contact> contactsList = ContactOperation.GetContactByLocation(locationname); 

                        Console.WriteLine("ID\tFirstName\tLocation");
                        foreach (var item in contactsList)
                        {
                            Console.WriteLine(item.ContactID + "\t" + item.FirstName + "\t" + item.Location);
                        }
                        break;

                    case 6:
                        List<Contact> contacts = ContactOperation.GetAllContacts();

                        Console.WriteLine("ID\tFirstName\tLocation");
                        foreach (var item in contacts)
                        {
                            Console.WriteLine(item.ContactID + "\t" + item.FirstName +"\t" + item.Location);
                        }
                        break;

                }
                Console.WriteLine("*****************************************");

            }

                   

        }

       
    }
}
