using FlightManagement.BLL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerService _customerService;
        int custId = 0;
        public CustomerForm(ICustomerService _customerService)
        {
            InitializeComponent();
            this._customerService = _customerService;
            LoadAllCust();
            txtName.Focus();
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string address = txtAddress.Text.Trim();
                string city = txtCity.Text.Trim();
                string country = txtCountry.Text.Trim();
                long contactResult = 0;
                bool contact = long.TryParse(txtContact.Text.Trim(), out contactResult);
                string email = txtEmail.Text.Trim();
                if (name == "" && address == "" && city == "" && country == "" && contactResult == 0 && email == "")
                {
                    MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (name == "")
                    {
                        MessageBox.Show("Customer name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (address == "")
                    {
                        MessageBox.Show("Address is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (city == "")
                    {
                        MessageBox.Show("City is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (country == "")
                    {
                        MessageBox.Show("Country is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (contactResult == 0)
                    {
                        MessageBox.Show("Contact is required and must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (email == "")
                    {
                        MessageBox.Show("Email is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Customer customer = new Customer
                        {
                            Name = name,
                            Address = address,
                            City = city,
                            Country = country,
                            Contact = contactResult,
                            Email = email
                        };
                        if (btnSaveCust.Text == "Save")
                        {
                            int custSucc = _customerService.SaveUpdateCustomer(customer);
                            if (custSucc > 0)
                            {
                                MessageBox.Show("Customer saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            customer.Id = custId;
                            int custSucc = _customerService.SaveUpdateCustomer(customer);
                            if (custSucc > 0)
                            {
                                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        CustomerClearance();
                        LoadAllCust();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void CustomerClearance()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtName.Focus();
            btnSaveCust.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomerClearance();
        }

        private void LoadAllCust()
        {
            try
            {
                List<Customer> customers = _customerService.GetAllCustomers();
                if (customers.Count > 0)
                {
                    dgvCustomer.Rows.Clear();
                    for (int i = 0; i < customers.Count; i++)
                    {
                        dgvCustomer.Rows.Add();
                        dgvCustomer.Rows[i].Cells["SN"].Value = i + 1;
                        dgvCustomer.Rows[i].Cells["Id"].Value = customers[i].Id.ToString();
                        dgvCustomer.Rows[i].Cells["CustomerName"].Value = customers[i].Name.ToString();
                        dgvCustomer.Rows[i].Cells["Address"].Value = customers[i].Address.ToString();
                        dgvCustomer.Rows[i].Cells["City"].Value = customers[i].City.ToString();
                        dgvCustomer.Rows[i].Cells["Country"].Value = customers[i].Country.ToString();
                        dgvCustomer.Rows[i].Cells["Contact"].Value = customers[i].Contact.ToString();
                        dgvCustomer.Rows[i].Cells["Email"].Value = customers[i].Email.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                custId = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["Id"].Value.ToString());
                txtName.Text = dgvCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtAddress.Text = dgvCustomer.CurrentRow.Cells["Address"].Value.ToString();
                txtCity.Text = dgvCustomer.CurrentRow.Cells["City"].Value.ToString();
                txtCountry.Text = dgvCustomer.CurrentRow.Cells["Country"].Value.ToString();
                txtContact.Text = dgvCustomer.CurrentRow.Cells["Contact"].Value.ToString();
                txtEmail.Text = dgvCustomer.CurrentRow.Cells["Email"].Value.ToString();
                btnSaveCust.Text = "Update";
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int delSucc = _customerService.DeleteCustomer(custId);
                if (delSucc > 0)
                {
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CustomerClearance();
                    LoadAllCust();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Customer> customers = _customerService.GetCustomersById(txtSearch.Text.Trim());
                dgvCustomer.Rows.Clear();
                for (int i = 0; i < customers.Count; i++)
                {
                    dgvCustomer.Rows.Add();
                    dgvCustomer.Rows[i].Cells["SN"].Value = i + 1;
                    dgvCustomer.Rows[i].Cells["Id"].Value = customers[i].Id.ToString();
                    dgvCustomer.Rows[i].Cells["CustomerName"].Value = customers[i].Name.ToString();
                    dgvCustomer.Rows[i].Cells["Address"].Value = customers[i].Address.ToString();
                    dgvCustomer.Rows[i].Cells["City"].Value = customers[i].City.ToString();
                    dgvCustomer.Rows[i].Cells["Country"].Value = customers[i].Country.ToString();
                    dgvCustomer.Rows[i].Cells["Contact"].Value = customers[i].Contact.ToString();
                    dgvCustomer.Rows[i].Cells["Email"].Value = customers[i].Email.ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
