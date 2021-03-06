﻿using FlightManagement.BLL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    public partial class CargoForm : Form
    {
        private readonly ICargoService _cargoService;
        private int cargoId = 0;
        public CargoForm(ICargoService _cargoService)
        {
            InitializeComponent();
            this._cargoService = _cargoService;
            LoadAllCargoPlanes();
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
                        dgvCargo.Rows[i].Cells["PlaneName"].Value = cargos[i].PlaneName.ToString();
                        dgvCargo.Rows[i].Cells["CargoItem"].Value = cargos[i].CargoItem.ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadAllCargoPlanes()
        {
            try
            {
                List<Plane> planes = _cargoService.GetAllCargoPlanes();
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

        private void btnSaveCargo_Click(object sender, EventArgs e)
        {
            try
            {
                int planeId = Convert.ToInt32(ddlPlaneName.SelectedValue.ToString());
                string cargoItem = txtCargoItem.Text.Trim();
                if (planeId == 0 && cargoItem == "")
                {
                    MessageBox.Show("All fields are required required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (planeId == 0)
                    {
                        MessageBox.Show("Select a plane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cargoItem == "")
                    {
                        MessageBox.Show("Cargo Item is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Cargo cargo = new Cargo
                        {
                            PlaneId = planeId,
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
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargoClearance()
        {
            txtCargoItem.Clear();
            ddlPlaneName.SelectedIndex = 0;
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
            catch (Exception)
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
            catch (Exception)
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
                    dgvCargo.Rows[i].Cells["PlaneName"].Value = cargos[i].PlaneName.ToString();
                    dgvCargo.Rows[i].Cells["CargoItem"].Value = cargos[i].CargoItem.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvCargo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                cargoId = Convert.ToInt32(dgvCargo.CurrentRow.Cells["Id"].Value.ToString());
                txtCargoItem.Text = dgvCargo.CurrentRow.Cells["CargoItem"].Value.ToString();
                ddlPlaneName.Text = dgvCargo.CurrentRow.Cells["PlaneName"].Value.ToString();
                btnSaveCargo.Text = "Update";
                btnDeleteCargo.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
