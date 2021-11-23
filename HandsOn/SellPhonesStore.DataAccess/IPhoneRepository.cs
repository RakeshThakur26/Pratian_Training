using SellPhonesStore.Entities;
using System.Collections.Generic;

namespace SellPhonesStore.DataAccess
{
    public interface IPhoneRepository
    {
        long SavePhone( Phone phone);
        long SaveCustomer(Customer customer);
        long SaveOrder(CustomerOrder order);
        long SaveOrderedPhone(OrderedPhone orderPhone, long orderId);
        List<CustomerOrder> GetCustomerOrders(long customerId);
        List<CustomerOrder> GetAllCustomerOrders();
        Customer GetCustomerById(long id);
        Phone GetPhoneById(long pid);
    }
}
