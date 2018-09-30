using FlightManagement.Domain;
using System.Collections.Generic;

namespace FlightManagement.DAL
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
        int SaveUpdateCustomer(Customer cust);
        int DeleteCustomer(int custId);
    }
}
