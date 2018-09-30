using FlightManagement.BLL;
using FlightManagement.Domain;
using System;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerService _customerService;
        public CustomerForm(ICustomerService _customerService)
        {
            InitializeComponent();
            this._customerService = _customerService;
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string address = txtAddress.Text.Trim();
                string city = txtCity.Text.Trim();
                string country = txtCountry.Text.Trim();
                long contact = long.Parse(txtContact.Text.Trim());
                string email = txtEmail.Text.Trim();
                Customer customer = new Customer
                {
                    Name = name,
                    Address = address,
                    City = city,
                    Country = country,
                    Contact = contact,
                    Email = email
                };
                _customerService.SaveUpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
