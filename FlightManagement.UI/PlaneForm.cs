using FlightManagement.BLL;
using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlightManagement.UI
{
    public partial class PlaneForm : Form
    {
        private readonly IPlaneService _planeService;
        int planeId = 0;
        public PlaneForm(IPlaneService _planeService)
        {
            InitializeComponent();
            ddlPlaneType.SelectedIndex = 0;
            this._planeService = _planeService;
            LoadAllPlane();
            txtPlaneName.Focus();
        }

        private void LoadAllPlane()
        {
            try
            {
                List<Plane> planes = _planeService.GetAllPlanes();
                if (planes.Count > 0)
                {
                    dgvPlane.Rows.Clear();
                    for (int i = 0; i < planes.Count; i++)
                    {
                        dgvPlane.Rows.Add();
                        dgvPlane.Rows[i].Cells["SN"].Value = i + 1;
                        dgvPlane.Rows[i].Cells["Id"].Value = planes[i].Id.ToString();
                        dgvPlane.Rows[i].Cells["PlaneName"].Value = planes[i].PlaneName.ToString();
                        dgvPlane.Rows[i].Cells["PlaneType"].Value = planes[i].PlaneType.ToString();
                        dgvPlane.Rows[i].Cells["Capacity"].Value = planes[i].Capacity.ToString();
                        dgvPlane.Rows[i].Cells["Passengers"].Value = planes[i].PassengerNumber.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSavePlane_Click(object sender, EventArgs e)
        {
            try
            {
                int planeCapacity = 0, passengersNum = 0;
                string planeName = txtPlaneName.Text.Trim();
                string planeType = ddlPlaneType.SelectedItem.ToString();
                int.TryParse(txtMaxCapacity.Text.Trim(), out planeCapacity);
                int.TryParse(txtPassNumber.Text.Trim(), out passengersNum);
                if (planeName == "" && planeType == "Select Plane Type" && planeCapacity == 0 && passengersNum == 0)
                {
                    MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (planeName == "")
                    {
                        MessageBox.Show("Plane name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (planeType == "Select Plane Type")
                    {
                        MessageBox.Show("Select a plane type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (planeCapacity == 0)
                    {
                        MessageBox.Show("Plane Capacity is required and must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (passengersNum == 0)
                    {
                        MessageBox.Show("Number of passengers is required and must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Plane plane = new Plane
                        {
                            PlaneName = planeName,
                            PlaneType = planeType,
                            Capacity = planeCapacity,
                            PassengerNumber = passengersNum
                        };
                        if (btnSavePlane.Text == "Save")
                        {
                            int planeSucc = _planeService.SaveUpdatePlane(plane);
                            if (planeSucc > 0)
                            {
                                MessageBox.Show("Plane data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            plane.Id = planeId;
                            int planeSucc = _planeService.SaveUpdatePlane(plane);
                            if (planeSucc > 0)
                            {
                                MessageBox.Show("Plane data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        PlaneClearance();
                        LoadAllPlane();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void PlaneClearance()
        {
            txtPlaneName.Clear();
            ddlPlaneType.SelectedIndex = 0;
            txtMaxCapacity.Clear();
            txtPassNumber.Clear();
            btnSavePlane.Text = "Save";
            btnDeletePlane.Enabled = false;
        }

        private void btnDeletePlane_Click(object sender, EventArgs e)
        {
            try
            {
                int delSucc = _planeService.DeletePlane(planeId);
                if (delSucc > 0)
                {
                    MessageBox.Show("Plane data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PlaneClearance();
                    LoadAllPlane();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnCancelPlane_Click(object sender, EventArgs e)
        {
            PlaneClearance();
        }

        private void dgvPlane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                planeId = Convert.ToInt32(dgvPlane.CurrentRow.Cells["Id"].Value.ToString());
                txtPlaneName.Text = dgvPlane.CurrentRow.Cells["PlaneName"].Value.ToString();
                ddlPlaneType.Text = dgvPlane.CurrentRow.Cells["PlaneType"].Value.ToString();
                txtMaxCapacity.Text = dgvPlane.CurrentRow.Cells["Capacity"].Value.ToString();
                txtPassNumber.Text = dgvPlane.CurrentRow.Cells["Passengers"].Value.ToString();
                btnSavePlane.Text = "Update";
                btnDeletePlane.Enabled = true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void txtSearchPlane_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Plane> planes = _planeService.GetPlanesById(txtSearchPlane.Text.Trim());
                dgvPlane.Rows.Clear();
                for (int i = 0; i < planes.Count; i++)
                {
                    dgvPlane.Rows.Add();
                    dgvPlane.Rows[i].Cells["SN"].Value = i + 1;
                    dgvPlane.Rows[i].Cells["Id"].Value = planes[i].Id.ToString();
                    dgvPlane.Rows[i].Cells["PlaneName"].Value = planes[i].PlaneName.ToString();
                    dgvPlane.Rows[i].Cells["PlaneType"].Value = planes[i].PlaneType.ToString();
                    dgvPlane.Rows[i].Cells["Capacity"].Value = planes[i].Capacity.ToString();
                    dgvPlane.Rows[i].Cells["Passengers"].Value = planes[i].PassengerNumber.ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
