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
        private int bookId = 0;
        private string customerName = string.Empty;
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
            LoadAllBookingsCurrentDate();
        }

        private void LoadAllBookingsCurrentDate()
        {
            try
            {
                List<PlaneBook> planeBooks = _planeBookService.GetAllBookingCurrentDate(dtPBookedDate.Value.ToShortDateString());
                if (planeBooks.Count > 0)
                {
                    dgvBooking.Rows.Clear();
                    for (int i = 0; i < planeBooks.Count; i++)
                    {
                        dgvBooking.Rows.Add();
                        dgvBooking.Rows[i].Cells["SN"].Value = i + 1;
                        dgvBooking.Rows[i].Cells["Id"].Value = planeBooks[i].Id.ToString();
                        dgvBooking.Rows[i].Cells["ClientName"].Value = planeBooks[i].BookedBy.ToString();
                        dgvBooking.Rows[i].Cells["PlaneName"].Value = planeBooks[i].PlaneList.PlaneName.ToString();
                        dgvBooking.Rows[i].Cells["PlaneType"].Value = planeBooks[i].PlaneList.PlaneType.ToString();
                        dgvBooking.Rows[i].Cells["CargoItem"].Value = Convert.ToString(planeBooks[i].CargoList.CargoItem);
                        dgvBooking.Rows[i].Cells["Departure"].Value = planeBooks[i].Departure.ToString();
                        dgvBooking.Rows[i].Cells["Arrival"].Value = planeBooks[i].Arrival.ToString();
                        dgvBooking.Rows[i].Cells["CustomerName"].Value = Convert.ToString(planeBooks[i].CustomerList.Name);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadAllBookings()
        {
            try
            {
                List<PlaneBook> planeBooks = _planeBookService.GetAllBooking();
                if (planeBooks.Count > 0)
                {
                    dgvBooking.Rows.Clear();
                    for (int i = 0; i < planeBooks.Count; i++)
                    {
                        dgvBooking.Rows.Add();
                        dgvBooking.Rows[i].Cells["SN"].Value = i + 1;
                        dgvBooking.Rows[i].Cells["Id"].Value = planeBooks[i].Id.ToString();
                        dgvBooking.Rows[i].Cells["ClientName"].Value = planeBooks[i].BookedBy.ToString();
                        dgvBooking.Rows[i].Cells["PlaneName"].Value = planeBooks[i].PlaneList.PlaneName.ToString();
                        dgvBooking.Rows[i].Cells["PlaneType"].Value = planeBooks[i].PlaneList.PlaneType.ToString();
                        dgvBooking.Rows[i].Cells["CargoItem"].Value = Convert.ToString(planeBooks[i].CargoList.CargoItem);
                        dgvBooking.Rows[i].Cells["Departure"].Value = planeBooks[i].Departure.ToString();
                        dgvBooking.Rows[i].Cells["Arrival"].Value = planeBooks[i].Arrival.ToString();
                        dgvBooking.Rows[i].Cells["CustomerName"].Value = Convert.ToString(planeBooks[i].CustomerList.Name);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
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
                    btnSavePlaneBooking.Text = "Save";
                    btnSavePlaneBooking.Enabled = false;
                }
                else
                {
                    if (btnSavePlaneBooking.Text == "Save")
                    {
                        GetPlaneByPlaneType(ddlPlaneType.SelectedItem.ToString());
                    }
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
                            Id = 0,
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
                            Id = 0,
                            Name = "Select Customers"
                        });
                        ddlCustName.DataSource = customers;
                        ddlCustName.DisplayMember = "Name";
                        ddlCustName.ValueMember = "Id";
                    }
                }
            }
            catch (Exception)
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
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSavePlaneBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = 0, cargoId = 0;
                string bookedBy = txtBookedBy.Text.Trim();
                int.TryParse(ddlPlaneName.SelectedValue.ToString(), out int planeId);
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
                                    LoadAllBookingsCurrentDate();
                                    BookingClearance();
                                }
                                else if (bookSucc == 0)
                                {
                                    MessageBox.Show("Plane already booked for this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                planeBook.Id = bookId;
                                int bookSucc = _planeBookService.SaveUpdateBookingCargo(planeBook);
                                if (bookSucc > 0)
                                {
                                    MessageBox.Show("Plane booking updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadAllBookingsCurrentDate();
                                    BookingClearance();
                                }
                                else if (bookSucc == 0)
                                {
                                    MessageBox.Show("Plane already booked for this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    LoadAllBookingsCurrentDate();
                                }
                                else if (bookSucc == 0)
                                {
                                    MessageBox.Show("Plane already booked for this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                    LoadAllBookingsCurrentDate();
                                }
                                else if (bookSucc == 0)
                                {
                                    MessageBox.Show("Plane already booked for this time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BookingClearance()
        {
            try
            {
                ddlPlaneType.Enabled = true;
                ddlPlaneType.SelectedIndex = 0;
                txtBookedBy.Clear();
                btnSavePlaneBooking.Text = "Save";
                btnDeletePlaneBooking.Enabled = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancelPlaneBooking_Click(object sender, EventArgs e)
        {
            try
            {
                BookingClearance();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtSearchBooking_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterBooking();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FilterBooking()
        {
            btnSeeEntireBooking.Text = "See Entire Booking";
            List<PlaneBook> planeBooks = _planeBookService.GetBookingByCustName(txtSearchBooking.Text.ToLower().Trim(), dtPBookedDate.Value.ToShortDateString());
            if (planeBooks.Count > 0)
            {
                dgvBooking.Rows.Clear();
                for (int i = 0; i < planeBooks.Count; i++)
                {
                    dgvBooking.Rows.Add();
                    dgvBooking.Rows[i].Cells["SN"].Value = i + 1;
                    dgvBooking.Rows[i].Cells["Id"].Value = planeBooks[i].Id.ToString();
                    dgvBooking.Rows[i].Cells["ClientName"].Value = planeBooks[i].BookedBy.ToString();
                    dgvBooking.Rows[i].Cells["PlaneName"].Value = planeBooks[i].PlaneList.PlaneName.ToString();
                    dgvBooking.Rows[i].Cells["PlaneType"].Value = planeBooks[i].PlaneList.PlaneType.ToString();
                    dgvBooking.Rows[i].Cells["CargoItem"].Value = Convert.ToString(planeBooks[i].CargoList.CargoItem);
                    dgvBooking.Rows[i].Cells["Departure"].Value = planeBooks[i].Departure.ToString();
                    dgvBooking.Rows[i].Cells["Arrival"].Value = planeBooks[i].Arrival.ToString();
                    dgvBooking.Rows[i].Cells["CustomerName"].Value = Convert.ToString(planeBooks[i].CustomerList.Name);
                }
            }
        }

        private void btnSeeEntireBooking_Click(object sender, EventArgs e)
        {
            if (btnSeeEntireBooking.Text == "See Entire Booking")
            {
                txtSearchBooking.Clear();
                LoadAllBookings();
                btnSeeEntireBooking.Text = "See Current Booking";
            }
            else if (btnSeeEntireBooking.Text == "See Current Booking")
            {
                LoadAllBookingsCurrentDate();
                btnSeeEntireBooking.Text = "See Entire Booking";
            }
        }

        private void dtPBookedDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FilterBooking();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnDeletePlaneBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int delSucc = _planeBookService.Cancelbooking(customerName);
                if (delSucc > 0)
                {
                    MessageBox.Show("Booking canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BookingClearance();
                    LoadAllBookings();
                    btnSeeEntireBooking.Text = "See Current Booking";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvBooking_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                ddlPlaneType.Enabled = false;
                ddlPlaneType.Text = dgvBooking.CurrentRow.Cells["PlaneType"].Value.ToString();
                string cargoItem = Convert.ToString(dgvBooking.CurrentRow.Cells["CargoItem"].Value);
                string custName = Convert.ToString(dgvBooking.CurrentRow.Cells["CustomerName"].Value);
                if (cargoItem == "")
                {
                    ddlCargoItem.Enabled = false;
                    ddlCustName.Enabled = true;
                    ddlCustName.Text = custName;
                    dtPArrival.Value = Convert.ToDateTime(dgvBooking.CurrentRow.Cells["Arrival"].Value.ToString());
                }
                else
                {
                    ddlCargoItem.Enabled = true;
                    ddlCustName.Enabled = false;
                    ddlCargoItem.Text = dgvBooking.CurrentRow.Cells["CargoItem"].Value.ToString();
                }
                bookId = Convert.ToInt32(dgvBooking.CurrentRow.Cells["Id"].Value.ToString());
                customerName = dgvBooking.CurrentRow.Cells["ClientName"].Value.ToString();
                ddlPlaneName.Text = dgvBooking.CurrentRow.Cells["PlaneName"].Value.ToString();
                dtPDeparture.Value = Convert.ToDateTime(dgvBooking.CurrentRow.Cells["Departure"].Value.ToString());
                txtBookedBy.Text = dgvBooking.CurrentRow.Cells["ClientName"].Value.ToString();
                btnSavePlaneBooking.Text = "Update";
                btnDeletePlaneBooking.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
