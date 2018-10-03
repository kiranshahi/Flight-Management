using FlightManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    public partial class MainForm : Form
    {
        private readonly IPlaneBookService _planeBookService;
        private readonly IPlaneService _planeService;
        private readonly ICargoService _cargoService;
        private readonly ICustomerService _customerService;
        CustomerForm customerForm;
        PlaneForm planeForm;
        CargoForm cargoForm;
        PlaneBookingForm bookingForm;
        public MainForm(IPlaneBookService _planeBookService, IPlaneService _planeService, ICargoService _cargoService, ICustomerService _customerService)
        {
            InitializeComponent();
            this._planeBookService = _planeBookService;
            this._planeService = _planeService;
            this._cargoService = _cargoService;
            this._customerService = _customerService;
            this.customerForm = null;
            this.planeForm = null;
            this.cargoForm = null;
            this.bookingForm = null;
            LoadBookForm();
        }
        
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HideAllChilds();
                if (customerForm == null)
                {
                    customerForm = new CustomerForm(_customerService);
                }
                customerForm.MdiParent = this;
                customerForm.FormBorderStyle = FormBorderStyle.None;
                this.Size = customerForm.Size;
                customerForm.StartPosition = FormStartPosition.Manual;
                customerForm.Show();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void HideAllChilds()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Hide();
            }
        }

        private void planeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HideAllChilds();
                if (planeForm == null)
                {
                    planeForm = new PlaneForm(_planeService);
                }
                planeForm.MdiParent = this;
                planeForm.FormBorderStyle = FormBorderStyle.None;
                this.Size = planeForm.Size;
                planeForm.StartPosition = FormStartPosition.Manual;
                planeForm.Show();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HideAllChilds();
                if (cargoForm == null)
                {
                    cargoForm = new CargoForm(_cargoService);
                }
                cargoForm.MdiParent = this;
                cargoForm.FormBorderStyle = FormBorderStyle.None;
                this.Size = cargoForm.Size;
                cargoForm.StartPosition = FormStartPosition.Manual;
                cargoForm.Show();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HideAllChilds();
                LoadBookForm();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void LoadBookForm()
        {
            if (bookingForm == null)
            {
                bookingForm = new PlaneBookingForm(_planeBookService, _planeService, _cargoService, _customerService);
            }
            bookingForm.MdiParent = this;
            bookingForm.FormBorderStyle = FormBorderStyle.None;
            this.Size = bookingForm.Size;
            bookingForm.StartPosition = FormStartPosition.Manual;
            bookingForm.Show();
        }
    }
}
