namespace Session2.GUI
{
    partial class fEMMAdmin
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
            this.btn_ManageRequest = new System.Windows.Forms.Button();
            this.dgvEMM = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMM)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ManageRequest
            // 
            this.btn_ManageRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageRequest.Location = new System.Drawing.Point(12, 618);
            this.btn_ManageRequest.Name = "btn_ManageRequest";
            this.btn_ManageRequest.Size = new System.Drawing.Size(221, 42);
            this.btn_ManageRequest.TabIndex = 5;
            this.btn_ManageRequest.Text = "Manage Request\r\n";
            this.btn_ManageRequest.UseVisualStyleBackColor = true;
            this.btn_ManageRequest.Click += new System.EventHandler(this.btn_ManageRequest_Click);
            // 
            // dgvEMM
            // 
            this.dgvEMM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colAssetSN,
            this.colAssetName,
            this.colRequestDate,
            this.colEmployeeFullName,
            this.colDepartment});
            this.dgvEMM.Location = new System.Drawing.Point(12, 57);
            this.dgvEMM.Name = "dgvEMM";
            this.dgvEMM.RowTemplate.Height = 24;
            this.dgvEMM.Size = new System.Drawing.Size(1051, 538);
            this.dgvEMM.TabIndex = 4;
            // colID
            // 
            this.colID.HeaderText = "Column1";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colAssetSN
            // 
            this.colAssetSN.HeaderText = "Asset SN";
            this.colAssetSN.Name = "colAssetSN";
            // 
            // colAssetName
            // 
            this.colAssetName.HeaderText = "Asset Name";
            this.colAssetName.Name = "colAssetName";
            // 
            // colRequestDate
            // 
            this.colRequestDate.HeaderText = "Request Date";
            this.colRequestDate.Name = "colRequestDate";
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.HeaderText = "Employee Full Name";
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            // 
            // colDepartment
            // 
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Assets Requesting EM:";
            // 
            // fEMMAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 675);
            this.Controls.Add(this.btn_ManageRequest);
            this.Controls.Add(this.dgvEMM);
            this.Controls.Add(this.label1);
            this.Name = "fEMMAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Mainternance Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ManageRequest;
        private System.Windows.Forms.DataGridView dgvEMM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
    }
}