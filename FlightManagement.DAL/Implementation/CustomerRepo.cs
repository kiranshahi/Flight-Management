using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FlightManagement.DAL
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly IDBO _dBO;
        public CustomerRepo(IDBO _dBO)
        {
            this._dBO = _dBO;
        }

        public int DeleteCustomer(int custId)
        {
            string sqlQuery = "Delete from Customer where Id = @Id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Id", custId)
            };
            return _dBO.IUD(sqlQuery, param, CommandType.Text);
        }

        public List<Customer> GetAllCustomers()
        {
            string sqlQuery = "Select * from Customer";
            DataTable dataTable = _dBO.GetTable(sqlQuery, null, CommandType.Text);
            List<Customer> listCust = new List<Customer>();
            if (dataTable.Rows.Count > 0)
            {
                listCust = dataTable.AsEnumerable().Select(m => new Customer()
                {
                    Id = m.Field<int>("Id"),
                    Name = m.Field<string>("Name"),
                    Address = m.Field<string>("Address"),
                    City = m.Field<string>("City"),
                    Country = m.Field<string>("Country"),
                    Contact = m.Field<long>("Contact"),
                    Email = m.Field<string>("Email"),
                }).ToList();
            }
            return listCust;
        }

        public List<Customer> GetCustomersById(string custId)
        {
            string sqlQuery = "Select * from Customer where Name Like @Name";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Name", custId +"%")
            };
            DataTable dataTable = _dBO.GetTable(sqlQuery, param, CommandType.Text);
            List<Customer> listCust = new List<Customer>();
            if (dataTable.Rows.Count > 0)
            {
                listCust = dataTable.AsEnumerable().Select(m => new Customer()
                {
                    Id = m.Field<int>("Id"),
                    Name = m.Field<string>("Name"),
                    Address = m.Field<string>("Address"),
                    City = m.Field<string>("City"),
                    Country = m.Field<string>("Country"),
                    Contact = m.Field<long>("Contact"),
                    Email = m.Field<string>("Email"),
                }).ToList();
            }
            return listCust;
        }

        public int SaveUpdateCustomer(Customer cust)
        {
            if (cust.Id > 0)
            {
                string sqlQuery2 = "Update Customer set Name = @Name, Address = @Address, City = @City, Country = @Country, Contact = @Contact, Email = @Email where Id = @Id";
                SqlParameter[] param2 = new SqlParameter[]
                {
                new SqlParameter("@Id", cust.Id),
                new SqlParameter("@Name", cust.Name),
                 new SqlParameter("@Address", cust.Address),
                  new SqlParameter("@City", cust.City),
                   new SqlParameter("@Country", cust.Country),
                    new SqlParameter("@Contact", cust.Contact),
                     new SqlParameter("@Email", cust.Email)
                };
                return _dBO.IUD(sqlQuery2, param2, CommandType.Text);
            }
            else
            {
                string sqlQuery = "Insert into Customer(Name, Address, City, Country, Contact, Email) values(@Name, @Address, @City, @Country, @Contact, @Email)";
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@Name", cust.Name),
                 new SqlParameter("@Address", cust.Address),
                  new SqlParameter("@City", cust.City),
                   new SqlParameter("@Country", cust.Country),
                    new SqlParameter("@Contact", cust.Contact),
                     new SqlParameter("@Email", cust.Email)
                };
                return _dBO.IUD(sqlQuery, param, CommandType.Text);
            }
        }
    }
}
