using FlightManagement.DAL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;

namespace FlightManagement.BLL
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerService(ICustomerRepo _customerRepo)
        {
            this._customerRepo = _customerRepo;
        }

        public int DeleteCustomer(int custId)
        {
            try
            {
                return _customerRepo.DeleteCustomer(custId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            try
            {
                return _customerRepo.GetAllCustomers();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SaveUpdateCustomer(Customer cust)
        {
            try
            {
                return _customerRepo.SaveUpdateCustomer(cust);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
