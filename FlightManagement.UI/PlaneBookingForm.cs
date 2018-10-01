using FlightManagement.BLL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    public partial class PlaneBookingForm : Form
    {
        private readonly IPlaneBookService _planeBookService;
        private readonly IPlaneService _planeService;
        private readonly ICargoService _cargoService;
        private readonly ICustomerService _customerService;
        int bookId = 0;
        public PlaneBookingForm(IPlaneBookService _planeBookService, IPlaneService _planeService, ICargoService _cargoService, ICustomerService _customerService)
        {
            InitializeComponent();
            this._planeBookService = _planeBookService;
            this._planeService = _planeService;
            this._cargoService = _cargoService;
            this._customerService = _customerService;
            ddlPlaneType.SelectedIndex = 0;
            ddlPlaneName.SelectedIndex = 0;
            ddlCargoItem.SelectedIndex = 0;
            ddlCustName.SelectedIndex = 0;
        }

        private void ddlPlaneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlPlaneType.SelectedIndex == 0)
                {
                    ddlCustName.Enabled = false;
                    ddlCargoItem.Enabled = false;
                    ddlPlaneName.Enabled = false;
                    ddlPlaneName.SelectedIndex = 0;
                    ddlCargoItem.SelectedIndex = 0;
                    ddlCustName.SelectedIndex = 0;
                    btnSavePlaneBooking.Enabled = false;
                }
                else
                {
                    GetPlaneByPlaneType(ddlPlaneType.SelectedItem.ToString());
                    if (ddlPlaneType.Text == "Cargo")
                    {
                        btnSavePlaneBooking.Enabled = true;
                        ddlPlaneName.Enabled = true;
                        ddlCargoItem.Enabled = true;
                        ddlCustName.Enabled = false;
                        lblDeparture.Text = "Book For:";
                        dtPArrival.Enabled = false;
                        List<Cargo> cargos = _cargoService.GetAllCargo();
                        cargos.Insert(0, new Cargo()
                        {
                            CargoItem = "Select Cargo Item"
                        });
                        ddlCargoItem.DataSource = cargos;
                        ddlCargoItem.DisplayMember = "CargoItem";
                        ddlCargoItem.ValueMember = "Id";
                    }
                    else
                    {
                        btnSavePlaneBooking.Enabled = true;
                        ddlPlaneName.Enabled = true;
                        ddlCustName.Enabled = true;
                        ddlCargoItem.Enabled = false;
                        lblDeparture.Text = "Departure:";
                        dtPArrival.Enabled = true;
                        List<Customer> customers = _customerService.GetAllCustomers();
                        customers.Insert(0, new Customer()
                        {
                            Name = "Select Customers"
                        });
                        ddlCustName.DataSource = customers;
                        ddlCustName.DisplayMember = "Name";
                        ddlCustName.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void GetPlaneByPlaneType(string planeType)
        {
            try
            {
                List<Plane> planes = _planeService.GetPlanesByPlaneType(planeType);
                planes.Insert(0, new Plane()
                {
                    PlaneName = "Select Planes"
                });
                ddlPlaneName.DataSource = planes;
                ddlPlaneName.DisplayMember = "PlaneName";
                ddlPlaneName.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSavePlaneBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int planeId = 0, custId = 0, cargoId = 0;
                string bookedBy = txtBookedBy.Text.Trim();
                int.TryParse(ddlPlaneName.SelectedValue.ToString(), out planeId);
                DateTime departure = dtPDeparture.Value;
                DateTime arrival = dtPArrival.Value;
                if (ddlPlaneType.Text == "Cargo")
                {
                    int.TryParse(ddlCargoItem.SelectedValue.ToString(), out cargoId);
                    if (bookedBy == "" && planeId == 0 && cargoId == 0)
                    {
                        MessageBox.Show("Enter booked by and select plane and cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (bookedBy == "")
                        {
                            MessageBox.Show("Booked by field is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (planeId == 0)
                        {
                            MessageBox.Show("Select a plane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (cargoId == 0)
                        {
                            MessageBox.Show("Select a cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            PlaneBook planeBook = new PlaneBook
                            {
                                BookedBy = bookedBy,
                                PlaneId = planeId,
                                CargoId = cargoId,
                                Departure = departure
                            };
                            if (btnSavePlaneBooking.Text == "Save")
                            {
                                int bookSucc = _planeBookService.SaveUpdateBookingCargo(planeBook);
                                if (bookSucc > 0)
                                {
                                    MessageBox.Show("Plane booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BookingClearance();
                                }
                            }
                            else
                            {
                                planeBook.Id = bookId;
                                int bookSucc = _planeBookService.SaveUpdateBookingCargo(planeBook);
                                if (bookSucc > 0)
                                {
                                    MessageBox.Show("Plane booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BookingClearance();
                                }
                            }
                        }
                    }
                }
                else
                {
                    int.TryParse(ddlCustName.SelectedValue.ToString(), out custId);
                    if (bookedBy == "" && planeId == 0 && custId == 0)
                    {
                        MessageBox.Show("Select plane and customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (bookedBy == "")
                        {
                            MessageBox.Show("Booked by field is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (planeId == 0)
                        {
                            MessageBox.Show("Select a plane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (custId == 0)
                        {
                            MessageBox.Show("Select a customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            PlaneBook planeBook = new PlaneBook
                            {
                                BookedBy = bookedBy,
                                PlaneId = planeId,
                                CustomerId = custId,
                                Departure = departure,
                                Arrival = arrival
                            };
                            if (btnSavePlaneBooking.Text == "Save")
                            {
                                int bookSucc = _planeBookService.SaveUpdateBookingCust(planeBook);
                                if (bookSucc > 0)
                                {
                                    MessageBox.Show("Plane booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BookingClearance();
                                }
                            }
                            else
                            {
                                planeBook.Id = bookId;
                                int bookSucc = _planeBookService.SaveUpdateBookingCust(planeBook);
                                if (bookSucc > 0)
                                {
                                    MessageBox.Show("Plane booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    BookingClearance();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void BookingClearance()
        {
            ddlPlaneType.SelectedIndex = 0;
            txtBookedBy.Clear();
        }

        private void btnCancelPlaneBooking_Click(object sender, EventArgs e)
        {
            BookingClearance();
        }
    }
}
