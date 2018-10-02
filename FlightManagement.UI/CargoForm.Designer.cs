namespace FlightManagement.UI
{
    partial class CargoForm
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
            this.ddlPlaneName = new System.Windows.Forms.ComboBox();
            this.lblPlaneName = new System.Windows.Forms.Label();
            this.btnCancelCargo = new System.Windows.Forms.Button();
            this.btnDeleteCargo = new System.Windows.Forms.Button();
            this.txtCargoItem = new System.Windows.Forms.TextBox();
            this.lblCArgoItem = new System.Windows.Forms.Label();
            this.btnSaveCargo = new System.Windows.Forms.Button();
            this.lblAddCargo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCArgoDetails = new System.Windows.Forms.Label();
            this.lblSearchCargo = new System.Windows.Forms.Label();
            this.txtSearchCargo = new System.Windows.Forms.TextBox();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ddlPlaneName);
            this.panel2.Controls.Add(this.lblPlaneName);
            this.panel2.Controls.Add(this.btnCancelCargo);
            this.panel2.Controls.Add(this.btnDeleteCargo);
            this.panel2.Controls.Add(this.txtCargoItem);
            this.panel2.Controls.Add(this.lblCArgoItem);
            this.panel2.Controls.Add(this.btnSaveCargo);
            this.panel2.Controls.Add(this.lblAddCargo);
            this.panel2.Location = new System.Drawing.Point(9, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 150);
            this.panel2.TabIndex = 0;
            // 
            // ddlPlaneName
            // 
            this.ddlPlaneName.FormattingEnabled = true;
            this.ddlPlaneName.Location = new System.Drawing.Point(91, 28);
            this.ddlPlaneName.Name = "ddlPlaneName";
            this.ddlPlaneName.Size = new System.Drawing.Size(372, 21);
            this.ddlPlaneName.TabIndex = 0;
            // 
            // lblPlaneName
            // 
            this.lblPlaneName.AutoSize = true;
            this.lblPlaneName.Location = new System.Drawing.Point(11, 32);
            this.lblPlaneName.Name = "lblPlaneName";
            this.lblPlaneName.Size = new System.Drawing.Size(68, 13);
            this.lblPlaneName.TabIndex = 10;
            this.lblPlaneName.Text = "Plane Name:";
            // 
            // btnCancelCargo
            // 
            this.btnCancelCargo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCargo.Location = new System.Drawing.Point(308, 101);
            this.btnCancelCargo.Name = "btnCancelCargo";
            this.btnCancelCargo.Size = new System.Drawing.Size(88, 30);
            this.btnCancelCargo.TabIndex = 4;
            this.btnCancelCargo.Text = "Cancel";
            this.btnCancelCargo.UseVisualStyleBackColor = true;
            this.btnCancelCargo.Click += new System.EventHandler(this.btnCancelCargo_Click);
            // 
            // btnDeleteCargo
            // 
            this.btnDeleteCargo.Enabled = false;
            this.btnDeleteCargo.Location = new System.Drawing.Point(204, 101);
            this.btnDeleteCargo.Name = "btnDeleteCargo";
            this.btnDeleteCargo.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteCargo.TabIndex = 3;
            this.btnDeleteCargo.Text = "Delete";
            this.btnDeleteCargo.UseVisualStyleBackColor = true;
            this.btnDeleteCargo.Click += new System.EventHandler(this.btnDeleteCargo_Click);
            // 
            // txtCargoItem
            // 
            this.txtCargoItem.Location = new System.Drawing.Point(91, 59);
            this.txtCargoItem.Name = "txtCargoItem";
            this.txtCargoItem.Size = new System.Drawing.Size(372, 20);
            this.txtCargoItem.TabIndex = 1;
            // 
            // lblCArgoItem
            // 
            this.lblCArgoItem.AutoSize = true;
            this.lblCArgoItem.Location = new System.Drawing.Point(11, 62);
            this.lblCArgoItem.Name = "lblCArgoItem";
            this.lblCArgoItem.Size = new System.Drawing.Size(61, 13);
            this.lblCArgoItem.TabIndex = 8;
            this.lblCArgoItem.Text = "Cargo Item:";
            // 
            // btnSaveCargo
            // 
            this.btnSaveCargo.Location = new System.Drawing.Point(91, 101);
            this.btnSaveCargo.Name = "btnSaveCargo";
            this.btnSaveCargo.Size = new System.Drawing.Size(88, 30);
            this.btnSaveCargo.TabIndex = 2;
            this.btnSaveCargo.Text = "Save";
            this.btnSaveCargo.UseVisualStyleBackColor = true;
            this.btnSaveCargo.Click += new System.EventHandler(this.btnSaveCargo_Click);
            // 
            // lblAddCargo
            // 
            this.lblAddCargo.AutoSize = true;
            this.lblAddCargo.Location = new System.Drawing.Point(188, 4);
            this.lblAddCargo.Name = "lblAddCargo";
            this.lblAddCargo.Size = new System.Drawing.Size(97, 13);
            this.lblAddCargo.TabIndex = 7;
            this.lblAddCargo.Text = "Add/Update Cargo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCArgoDetails);
            this.panel1.Controls.Add(this.lblSearchCargo);
            this.panel1.Controls.Add(this.txtSearchCargo);
            this.panel1.Controls.Add(this.dgvCargo);
            this.panel1.Location = new System.Drawing.Point(9, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 432);
            this.panel1.TabIndex = 1;
            // 
            // lblCArgoDetails
            // 
            this.lblCArgoDetails.AutoSize = true;
            this.lblCArgoDetails.Location = new System.Drawing.Point(127, 9);
            this.lblCArgoDetails.Name = "lblCArgoDetails";
            this.lblCArgoDetails.Size = new System.Drawing.Size(73, 13);
            this.lblCArgoDetails.TabIndex = 7;
            this.lblCArgoDetails.Text = "Cargo Details:";
            // 
            // lblSearchCargo
            // 
            this.lblSearchCargo.AutoSize = true;
            this.lblSearchCargo.Location = new System.Drawing.Point(171, 36);
            this.lblSearchCargo.Name = "lblSearchCargo";
            this.lblSearchCargo.Size = new System.Drawing.Size(44, 13);
            this.lblSearchCargo.TabIndex = 6;
            this.lblSearchCargo.Text = "Search:";
            // 
            // txtSearchCargo
            // 
            this.txtSearchCargo.Location = new System.Drawing.Point(220, 33);
            this.txtSearchCargo.Name = "txtSearchCargo";
            this.txtSearchCargo.Size = new System.Drawing.Size(243, 20);
            this.txtSearchCargo.TabIndex = 0;
            this.txtSearchCargo.TextChanged += new System.EventHandler(this.txtSearchCargo_TextChanged);
            // 
            // dgvCargo
            // 
            this.dgvCargo.AllowUserToAddRows = false;
            this.dgvCargo.AllowUserToDeleteRows = false;
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SN,
            this.PlaneName,
            this.CargoItem});
            this.dgvCargo.Location = new System.Drawing.Point(10, 62);
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.ReadOnly = true;
            this.dgvCargo.RowHeadersVisible = false;
            this.dgvCargo.Size = new System.Drawing.Size(453, 370);
            this.dgvCargo.TabIndex = 4;
            this.dgvCargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargo_CellContentClick);
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
            this.PlaneName.Width = 150;
            // 
            // CargoItem
            // 
            this.CargoItem.HeaderText = "CargoItem";
            this.CargoItem.Name = "CargoItem";
            this.CargoItem.ReadOnly = true;
            this.CargoItem.Width = 350;
            // 
            // CargoForm
            // 
            this.AcceptButton = this.btnSaveCargo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelCargo;
            this.ClientSize = new System.Drawing.Size(487, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CargoForm";
            this.Text = "CargoForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelCargo;
        private System.Windows.Forms.Button btnDeleteCargo;
        private System.Windows.Forms.TextBox txtCargoItem;
        private System.Windows.Forms.Label lblCArgoItem;
        private System.Windows.Forms.Button btnSaveCargo;
        private System.Windows.Forms.Label lblAddCargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCArgoDetails;
        private System.Windows.Forms.Label lblSearchCargo;
        private System.Windows.Forms.TextBox txtSearchCargo;
        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.ComboBox ddlPlaneName;
        private System.Windows.Forms.Label lblPlaneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargoItem;
    }
}