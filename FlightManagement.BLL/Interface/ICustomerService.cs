using FlightManagement.Domain;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public interface ICustomerService
    {
        List<Customer> GetCustomersById(string custId);
        List<Customer> GetAllCustomers();
        int SaveUpdateCustomer(Customer cust);
        int DeleteCustomer(int custId);
    }
}
