using FlightManagement.BLL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    public partial class CargoForm : Form
    {
        private readonly ICargoService _cargoService;
        int cargoId = 0;
        public CargoForm(ICargoService _cargoService)
        {
            InitializeComponent();
            this._cargoService = _cargoService;
            LoadAllCargo();
            txtCargoItem.Focus();
        }

        private void LoadAllCargo()
        {
            try
            {
                List<Cargo> cargos = _cargoService.GetAllCargo();
                if (cargos.Count > 0)
                {
                    dgvCargo.Rows.Clear();
                    for (int i = 0; i < cargos.Count; i++)
                    {
                        dgvCargo.Rows.Add();
                        dgvCargo.Rows[i].Cells["SN"].Value = i + 1;
                        dgvCargo.Rows[i].Cells["Id"].Value = cargos[i].Id.ToString();
                        dgvCargo.Rows[i].Cells["CargoItem"].Value = cargos[i].CargoItem.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSaveCargo_Click(object sender, EventArgs e)
        {
            try
            {
                string cargoItem = txtCargoItem.Text.Trim();
                if (cargoItem == "")
                {
                    MessageBox.Show("Cargo Item is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cargo cargo = new Cargo
                    {
                        CargoItem = cargoItem
                    };
                    if (btnSaveCargo.Text == "Save")
                    {
                        int cargoSucc = _cargoService.SaveUpdateCargo(cargo);
                        if (cargoSucc > 0)
                        {
                            MessageBox.Show("Cargo item saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        cargo.Id = cargoId;
                        int cargoSucc = _cargoService.SaveUpdateCargo(cargo);
                        if (cargoSucc > 0)
                        {
                            MessageBox.Show("Cargo item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    CargoClearance();
                    LoadAllCargo();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void CargoClearance()
        {
            txtCargoItem.Clear();
            btnSaveCargo.Text = "Save";
            btnDeleteCargo.Enabled = false;
        }

        private void btnDeleteCargo_Click(object sender, EventArgs e)
        {
            try
            {
                int delSucc = _cargoService.DeleteCargo(cargoId);
                if (delSucc > 0)
                {
                    MessageBox.Show("Cargo item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargoClearance();
                    LoadAllCargo();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnCancelCargo_Click(object sender, EventArgs e)
        {
            try
            {
                CargoClearance();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cargoId = Convert.ToInt32(dgvCargo.CurrentRow.Cells["Id"].Value.ToString());
                txtCargoItem.Text = dgvCargo.CurrentRow.Cells["CargoItem"].Value.ToString();
                btnSaveCargo.Text = "Update";
                btnDeleteCargo.Enabled = true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void txtSearchCargo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Cargo> cargos = _cargoService.GetCargoById(txtSearchCargo.Text.Trim());
                dgvCargo.Rows.Clear();
                for (int i = 0; i < cargos.Count; i++)
                {
                    dgvCargo.Rows.Add();
                    dgvCargo.Rows[i].Cells["SN"].Value = i + 1;
                    dgvCargo.Rows[i].Cells["Id"].Value = cargos[i].Id.ToString();
                    dgvCargo.Rows[i].Cells["CargoItem"].Value = cargos[i].CargoItem.ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
