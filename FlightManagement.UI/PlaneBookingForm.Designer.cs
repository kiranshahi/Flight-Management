﻿namespace FlightManagement.UI
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
            this.dtPArrival = new System.Windows.Forms.DateTimePicker();
            this.dtPDeparture = new System.Windows.Forms.DateTimePicker();
            this.ddlCustName = new System.Windows.Forms.ComboBox();
            this.ddlCargoItem = new System.Windows.Forms.ComboBox();
            this.lblCargoItem = new System.Windows.Forms.Label();
            this.ddlPlaneName = new System.Windows.Forms.ComboBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.ddlPlaneType = new System.Windows.Forms.ComboBox();
            this.btnCancelPlaneBooking = new System.Windows.Forms.Button();
            this.btnDeletePlaneBooking = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.btnSavePlaneBooking = new System.Windows.Forms.Button();
            this.lblPlaneType = new System.Windows.Forms.Label();
            this.lblBookPlane = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.lblSearchBooking = new System.Windows.Forms.Label();
            this.txtSearchBooking = new System.Windows.Forms.TextBox();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passengers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBookedBy = new System.Windows.Forms.Label();
            this.txtBookedBy = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtPArrival);
            this.panel2.Controls.Add(this.dtPDeparture);
            this.panel2.Controls.Add(this.txtBookedBy);
            this.panel2.Controls.Add(this.ddlCustName);
            this.panel2.Controls.Add(this.ddlCargoItem);
            this.panel2.Controls.Add(this.lblCargoItem);
            this.panel2.Controls.Add(this.ddlPlaneName);
            this.panel2.Controls.Add(this.lblArrival);
            this.panel2.Controls.Add(this.lblBookedBy);
            this.panel2.Controls.Add(this.lblDeparture);
            this.panel2.Controls.Add(this.ddlPlaneType);
            this.panel2.Controls.Add(this.btnCancelPlaneBooking);
            this.panel2.Controls.Add(this.btnDeletePlaneBooking);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Controls.Add(this.lblPlaneName);
            this.panel2.Controls.Add(this.btnSavePlaneBooking);
            this.panel2.Controls.Add(this.lblPlaneType);
            this.panel2.Controls.Add(this.lblBookPlane);
            this.panel2.Location = new System.Drawing.Point(11, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 196);
            this.panel2.TabIndex = 0;
            // 
            // dtPArrival
            // 
            this.dtPArrival.Location = new System.Drawing.Point(432, 100);
            this.dtPArrival.Name = "dtPArrival";
            this.dtPArrival.Size = new System.Drawing.Size(200, 20);
            this.dtPArrival.TabIndex = 5;
            // 
            // dtPDeparture
            // 
            this.dtPDeparture.Location = new System.Drawing.Point(100, 99);
            this.dtPDeparture.Name = "dtPDeparture";
            this.dtPDeparture.Size = new System.Drawing.Size(224, 20);
            this.dtPDeparture.TabIndex = 4;
            // 
            // ddlCustName
            // 
            this.ddlCustName.FormattingEnabled = true;
            this.ddlCustName.Items.AddRange(new object[] {
            "Select Customers"});
            this.ddlCustName.Location = new System.Drawing.Point(432, 68);
            this.ddlCustName.Name = "ddlCustName";
            this.ddlCustName.Size = new System.Drawing.Size(200, 21);
            this.ddlCustName.TabIndex = 3;
            // 
            // ddlCargoItem
            // 
            this.ddlCargoItem.FormattingEnabled = true;
            this.ddlCargoItem.Items.AddRange(new object[] {
            "Select Cargo Item"});
            this.ddlCargoItem.Location = new System.Drawing.Point(432, 29);
            this.ddlCargoItem.Name = "ddlCargoItem";
            this.ddlCargoItem.Size = new System.Drawing.Size(201, 21);
            this.ddlCargoItem.TabIndex = 1;
            // 
            // lblCargoItem
            // 
            this.lblCargoItem.AutoSize = true;
            this.lblCargoItem.Location = new System.Drawing.Point(341, 33);
            this.lblCargoItem.Name = "lblCargoItem";
            this.lblCargoItem.Size = new System.Drawing.Size(58, 13);
            this.lblCargoItem.TabIndex = 14;
            this.lblCargoItem.Text = "CargoItem:";
            // 
            // ddlPlaneName
            // 
            this.ddlPlaneName.FormattingEnabled = true;
            this.ddlPlaneName.Items.AddRange(new object[] {
            "Select Planes"});
            this.ddlPlaneName.Location = new System.Drawing.Point(100, 68);
            this.ddlPlaneName.Name = "ddlPlaneName";
            this.ddlPlaneName.Size = new System.Drawing.Size(224, 21);
            this.ddlPlaneName.TabIndex = 2;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(342, 102);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(39, 13);
            this.lblArrival.TabIndex = 8;
            this.lblArrival.Text = "Arrival:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(9, 103);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(57, 13);
            this.lblDeparture.TabIndex = 8;
            this.lblDeparture.Text = "Departure:";
            // 
            // ddlPlaneType
            // 
            this.ddlPlaneType.FormattingEnabled = true;
            this.ddlPlaneType.Items.AddRange(new object[] {
            "Select Plane Type",
            "Cargo",
            "Passenger"});
            this.ddlPlaneType.Location = new System.Drawing.Point(100, 29);
            this.ddlPlaneType.Name = "ddlPlaneType";
            this.ddlPlaneType.Size = new System.Drawing.Size(224, 21);
            this.ddlPlaneType.TabIndex = 0;
            this.ddlPlaneType.SelectedIndexChanged += new System.EventHandler(this.ddlPlaneType_SelectedIndexChanged);
            // 
            // btnCancelPlaneBooking
            // 
            this.btnCancelPlaneBooking.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelPlaneBooking.Location = new System.Drawing.Point(277, 158);
            this.btnCancelPlaneBooking.Name = "btnCancelPlaneBooking";
            this.btnCancelPlaneBooking.Size = new System.Drawing.Size(88, 30);
            this.btnCancelPlaneBooking.TabIndex = 9;
            this.btnCancelPlaneBooking.Text = "Cancel";
            this.btnCancelPlaneBooking.UseVisualStyleBackColor = true;
            this.btnCancelPlaneBooking.Click += new System.EventHandler(this.btnCancelPlaneBooking_Click);
            // 
            // btnDeletePlaneBooking
            // 
            this.btnDeletePlaneBooking.Enabled = false;
            this.btnDeletePlaneBooking.Location = new System.Drawing.Point(173, 158);
            this.btnDeletePlaneBooking.Name = "btnDeletePlaneBooking";
            this.btnDeletePlaneBooking.Size = new System.Drawing.Size(88, 30);
            this.btnDeletePlaneBooking.TabIndex = 8;
            this.btnDeletePlaneBooking.Text = "Delete";
            this.btnDeletePlaneBooking.UseVisualStyleBackColor = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(341, 71);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblPlaneName
            // 
            this.lblPlaneName.AutoSize = true;
            this.lblPlaneName.Location = new System.Drawing.Point(9, 72);
            this.lblPlaneName.Name = "lblPlaneName";
            this.lblPlaneName.Size = new System.Drawing.Size(68, 13);
            this.lblPlaneName.TabIndex = 8;
            this.lblPlaneName.Text = "Plane Name:";
            // 
            // btnSavePlaneBooking
            // 
            this.btnSavePlaneBooking.Location = new System.Drawing.Point(60, 158);
            this.btnSavePlaneBooking.Name = "btnSavePlaneBooking";
            this.btnSavePlaneBooking.Size = new System.Drawing.Size(88, 30);
            this.btnSavePlaneBooking.TabIndex = 7;
            this.btnSavePlaneBooking.Text = "Save";
            this.btnSavePlaneBooking.UseVisualStyleBackColor = true;
            this.btnSavePlaneBooking.Click += new System.EventHandler(this.btnSavePlaneBooking_Click);
            // 
            // lblPlaneType
            // 
            this.lblPlaneType.AutoSize = true;
            this.lblPlaneType.Location = new System.Drawing.Point(9, 34);
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
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(119, 159);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(85, 13);
            this.lblCustName.TabIndex = 11;
            this.lblCustName.Text = "Customer Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBookingDetails);
            this.panel1.Controls.Add(this.lblSearchBooking);
            this.panel1.Controls.Add(this.txtSearchBooking);
            this.panel1.Controls.Add(this.dgvBooking);
            this.panel1.Controls.Add(this.lblCustName);
            this.panel1.Location = new System.Drawing.Point(11, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 432);
            this.panel1.TabIndex = 1;
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Location = new System.Drawing.Point(217, 34);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(84, 13);
            this.lblBookingDetails.TabIndex = 7;
            this.lblBookingDetails.Text = "Booking Details:";
            // 
            // lblSearchBooking
            // 
            this.lblSearchBooking.AutoSize = true;
            this.lblSearchBooking.Location = new System.Drawing.Point(341, 36);
            this.lblSearchBooking.Name = "lblSearchBooking";
            this.lblSearchBooking.Size = new System.Drawing.Size(44, 13);
            this.lblSearchBooking.TabIndex = 6;
            this.lblSearchBooking.Text = "Search:";
            // 
            // txtSearchBooking
            // 
            this.txtSearchBooking.Location = new System.Drawing.Point(390, 33);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.Size = new System.Drawing.Size(243, 20);
            this.txtSearchBooking.TabIndex = 0;
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.AllowUserToDeleteRows = false;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SN,
            this.PlaneName,
            this.PlaneType,
            this.Capacity,
            this.Passengers});
            this.dgvBooking.Location = new System.Drawing.Point(10, 62);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.ReadOnly = true;
            this.dgvBooking.RowHeadersVisible = false;
            this.dgvBooking.Size = new System.Drawing.Size(626, 370);
            this.dgvBooking.TabIndex = 4;
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
            // lblBookedBy
            // 
            this.lblBookedBy.AutoSize = true;
            this.lblBookedBy.Location = new System.Drawing.Point(9, 133);
            this.lblBookedBy.Name = "lblBookedBy";
            this.lblBookedBy.Size = new System.Drawing.Size(62, 13);
            this.lblBookedBy.TabIndex = 8;
            this.lblBookedBy.Text = "Booked By:";
            // 
            // txtBookedBy
            // 
            this.txtBookedBy.Location = new System.Drawing.Point(100, 133);
            this.txtBookedBy.Name = "txtBookedBy";
            this.txtBookedBy.Size = new System.Drawing.Size(224, 20);
            this.txtBookedBy.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ddlPlaneType;
        private System.Windows.Forms.Button btnCancelPlaneBooking;
        private System.Windows.Forms.Button btnDeletePlaneBooking;
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.Button btnSavePlaneBooking;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblPlaneType;
        private System.Windows.Forms.Label lblBookPlane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.Label lblSearchBooking;
        private System.Windows.Forms.TextBox txtSearchBooking;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passengers;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ComboBox ddlCargoItem;
        private System.Windows.Forms.Label lblCargoItem;
        private System.Windows.Forms.ComboBox ddlPlaneName;
        private System.Windows.Forms.ComboBox ddlCustName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DateTimePicker dtPArrival;
        private System.Windows.Forms.DateTimePicker dtPDeparture;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.TextBox txtBookedBy;
        private System.Windows.Forms.Label lblBookedBy;
    }
}