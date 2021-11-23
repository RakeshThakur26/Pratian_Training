using SellPhonesStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SellPhonesStore.DataAccess
{
    public class PhoneRepository : IPhoneRepository
    {
        private static SellPhonesStoreDbContext db = new SellPhonesStoreDbContext();
        public List<CustomerOrder> GetAllCustomerOrders()
        {
            var orders = (from o in db.CustomerOrders.Include("customer")
                          select o).ToList();
            return orders;
        }

        private static List<Customer> GetAllCutomers()
        {
            return db.Customers.ToList();
        }

        public List<CustomerOrder> GetCustomerOrders(long customerId)
        {
            var res = db.CustomerOrders.Include("customer").Where(c => c.customer.CustomerId == customerId).ToList();
            return res;
        }

        public long SaveCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer.CustomerId;
        }

        public long SaveOrder(CustomerOrder order)
        {
            db.CustomerOrders.Add(order);
            db.SaveChanges();
           return  order.OrderId;
        }

        public long SavePhone(Phone phone)
        {
            db.Phones.Add(phone);
            db.SaveChanges();
            return phone.PhoneId;
        }

        public long SaveOrderedPhone(OrderedPhone orderPhone, long orderId)
        {
            db.OrderedPhones.Add(orderPhone);
            db.SaveChanges();
            return orderPhone.OrderPhoneId;
        }

        public Customer GetCustomerById(long id)
        {
            return db.Customers.Find(id);
        }

        public Phone GetPhoneById(long pid)
        {
            return db.Phones.Find(pid);
        }
    }
}
