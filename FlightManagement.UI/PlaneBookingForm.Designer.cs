namespace FlightManagement.UI
{
    partial class PlaneBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddlPlaneType = new System.Windows.Forms.ComboBox();
            this.btnCancelPlane = new System.Windows.Forms.Button();
            this.btnDeletePlane = new System.Windows.Forms.Button();
            this.txtPlaneName = new System.Windows.Forms.TextBox();
            this.txtBookFor = new System.Windows.Forms.TextBox();
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.btnSavePlane = new System.Windows.Forms.Button();
            this.lblBookFor = new System.Windows.Forms.Label();
            this.lblPlaneType = new System.Windows.Forms.Label();
            this.lblBookPlane = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlaneDetails = new System.Windows.Forms.Label();
            this.lblSearchPlane = new System.Windows.Forms.Label();
            this.txtSearchPlane = new System.Windows.Forms.TextBox();
            this.dgvPlane = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCustName);
            this.panel2.Controls.Add(this.lblCustName);
            this.panel2.Controls.Add(this.ddlPlaneType);
            this.panel2.Controls.Add(this.btnCancelPlane);
            this.panel2.Controls.Add(this.btnDeletePlane);
            this.panel2.Controls.Add(this.txtPlaneName);
            this.panel2.Controls.Add(this.txtBookFor);
            this.panel2.Controls.Add(this.lblPlaneName);
            this.panel2.Controls.Add(this.btnSavePlane);
            this.panel2.Controls.Add(this.lblBookFor);
            this.panel2.Controls.Add(this.lblPlaneType);
            this.panel2.Controls.Add(this.lblBookPlane);
            this.panel2.Location = new System.Drawing.Point(11, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 196);
            this.panel2.TabIndex = 5;
            // 
            // ddlPlaneType
            // 
            this.ddlPlaneType.FormattingEnabled = true;
            this.ddlPlaneType.Items.AddRange(new object[] {
            "Select Plane Type",
            "Cargo",
            "Passenger",
            "Both"});
            this.ddlPlaneType.Location = new System.Drawing.Point(405, 32);
            this.ddlPlaneType.Name = "ddlPlaneType";
            this.ddlPlaneType.Size = new System.Drawing.Size(224, 21);
            this.ddlPlaneType.TabIndex = 0;
            // 
            // btnCancelPlane
            // 
            this.btnCancelPlane.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelPlane.Location = new System.Drawing.Point(277, 153);
            this.btnCancelPlane.Name = "btnCancelPlane";
            this.btnCancelPlane.Size = new System.Drawing.Size(88, 30);
            this.btnCancelPlane.TabIndex = 8;
            this.btnCancelPlane.Text = "Cancel";
            this.btnCancelPlane.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlane
            // 
            this.btnDeletePlane.Enabled = false;
            this.btnDeletePlane.Location = new System.Drawing.Point(173, 153);
            this.btnDeletePlane.Name = "btnDeletePlane";
            this.btnDeletePlane.Size = new System.Drawing.Size(88, 30);
            this.btnDeletePlane.TabIndex = 8;
            this.btnDeletePlane.Text = "Delete";
            this.btnDeletePlane.UseVisualStyleBackColor = true;
            // 
            // txtPlaneName
            // 
            this.txtPlaneName.Location = new System.Drawing.Point(100, 76);
            this.txtPlaneName.Name = "txtPlaneName";
            this.txtPlaneName.Size = new System.Drawing.Size(231, 20);
            this.txtPlaneName.TabIndex = 1;
            // 
            // txtBookFor
            // 
            this.txtBookFor.Location = new System.Drawing.Point(405, 75);
            this.txtBookFor.Name = "txtBookFor";
            this.txtBookFor.Size = new System.Drawing.Size(224, 20);
            this.txtBookFor.TabIndex = 3;
            // 
            // lblPlaneName
            // 
            this.lblPlaneName.AutoSize = true;
            this.lblPlaneName.Location = new System.Drawing.Point(9, 78);
            this.lblPlaneName.Name = "lblPlaneName";
            this.lblPlaneName.Size = new System.Drawing.Size(68, 13);
            this.lblPlaneName.TabIndex = 8;
            this.lblPlaneName.Text = "Plane Name:";
            // 
            // btnSavePlane
            // 
            this.btnSavePlane.Location = new System.Drawing.Point(60, 153);
            this.btnSavePlane.Name = "btnSavePlane";
            this.btnSavePlane.Size = new System.Drawing.Size(88, 30);
            this.btnSavePlane.TabIndex = 9;
            this.btnSavePlane.Text = "Save";
            this.btnSavePlane.UseVisualStyleBackColor = true;
            // 
            // lblBookFor
            // 
            this.lblBookFor.AutoSize = true;
            this.lblBookFor.Location = new System.Drawing.Point(342, 78);
            this.lblBookFor.Name = "lblBookFor";
            this.lblBookFor.Size = new System.Drawing.Size(53, 13);
            this.lblBookFor.TabIndex = 8;
            this.lblBookFor.Text = "Book For:";
            // 
            // lblPlaneType
            // 
            this.lblPlaneType.AutoSize = true;
            this.lblPlaneType.Location = new System.Drawing.Point(337, 35);
            this.lblPlaneType.Name = "lblPlaneType";
            this.lblPlaneType.Size = new System.Drawing.Size(64, 13);
            this.lblPlaneType.TabIndex = 8;
            this.lblPlaneType.Text = "Plane Type:";
            // 
            // lblBookPlane
            // 
            this.lblBookPlane.AutoSize = true;
            this.lblBookPlane.Location = new System.Drawing.Point(226, 6);
            this.lblBookPlane.Name = "lblBookPlane";
            this.lblBookPlane.Size = new System.Drawing.Size(70, 13);
            this.lblBookPlane.TabIndex = 7;
            this.lblBookPlane.Text = "Book a plane";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPlaneDetails);
            this.panel1.Controls.Add(this.lblSearchPlane);
            this.panel1.Controls.Add(this.txtSearchPlane);
            this.panel1.Controls.Add(this.dgvPlane);
            this.panel1.Location = new System.Drawing.Point(11, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 432);
            this.panel1.TabIndex = 4;
            // 
            // lblPlaneDetails
            // 
            this.lblPlaneDetails.AutoSize = true;
            this.lblPlaneDetails.Location = new System.Drawing.Point(217, 34);
            this.lblPlaneDetails.Name = "lblPlaneDetails";
            this.lblPlaneDetails.Size = new System.Drawing.Size(72, 13);
            this.lblPlaneDetails.TabIndex = 7;
            this.lblPlaneDetails.Text = "Plane Details:";
            // 
            // lblSearchPlane
            // 
            this.lblSearchPlane.AutoSize = true;
            this.lblSearchPlane.Location = new System.Drawing.Point(341, 36);
            this.lblSearchPlane.Name = "lblSearchPlane";
            this.lblSearchPlane.Size = new System.Drawing.Size(44, 13);
            this.lblSearchPlane.TabIndex = 6;
            this.lblSearchPlane.Text = "Search:";
            // 
            // txtSearchPlane
            // 
            this.txtSearchPlane.Location = new System.Drawing.Point(390, 33);
            this.txtSearchPlane.Name = "txtSearchPlane";
            this.txtSearchPlane.Size = new System.Drawing.Size(243, 20);
            this.txtSearchPlane.TabIndex = 0;
            // 
            // dgvPlane
            // 
            this.dgvPlane.AllowUserToAddRows = false;
            this.dgvPlane.AllowUserToDeleteRows = false;
            this.dgvPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SN,
            this.PlaneName,
            this.PlaneType,
            this.Capacity,
            this.Passengers});
            this.dgvPlane.Location = new System.Drawing.Point(10, 62);
            this.dgvPlane.Name = "dgvPlane";
            this.dgvPlane.ReadOnly = true;
            this.dgvPlane.RowHeadersVisible = false;
            this.dgvPlane.Size = new System.Drawing.Size(626, 370);
            this.dgvPlane.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SN
            // 
            this.SN.HeaderText = "S.N.";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 50;
            // 
            // PlaneName
            // 
            this.PlaneName.HeaderText = "PlaneName";
            this.PlaneName.Name = "PlaneName";
            this.PlaneName.ReadOnly = true;
            // 
            // PlaneType
            // 
            this.PlaneType.HeaderText = "Plane Type";
            this.PlaneType.Name = "PlaneType";
            this.PlaneType.ReadOnly = true;
            this.PlaneType.Width = 150;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 200;
            // 
            // Passengers
            // 
            this.Passengers.HeaderText = "Passengers";
            this.Passengers.Name = "Passengers";
            this.Passengers.ReadOnly = true;
            this.Passengers.Width = 150;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(100, 32);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(231, 20);
            this.txtCustName.TabIndex = 10;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(9, 36);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(85, 13);
            this.lblCustName.TabIndex = 11;
            this.lblCustName.Text = "Customer Name:";
            // 
            // PlaneBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlaneBookingForm";
            this.Text = "PlaneBookingForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ddlPlaneType;
        private System.Windows.Forms.Button btnCancelPlane;
        private System.Windows.Forms.Button btnDeletePlane;
        private System.Windows.Forms.TextBox txtPlaneName;
        private System.Windows.Forms.TextBox txtBookFor;
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.Button btnSavePlane;
        private System.Windows.Forms.Label lblBookFor;
        private System.Windows.Forms.Label lblPlaneType;
        private System.Windows.Forms.Label lblBookPlane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaneDetails;
        private System.Windows.Forms.Label lblSearchPlane;
        private System.Windows.Forms.TextBox txtSearchPlane;
        private System.Windows.Forms.DataGridView dgvPlane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passengers;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
    }
}