namespace Session4
{
    partial class fIM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msPurchaseOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.msWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvIM = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colAction2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIM)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPurchaseOrders,
            this.msWarehouse});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1882, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msPurchaseOrders
            // 
            this.msPurchaseOrders.Name = "msPurchaseOrders";
            this.msPurchaseOrders.ShortcutKeyDisplayString = "Ctrl+P";
            this.msPurchaseOrders.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.msPurchaseOrders.Size = new System.Drawing.Size(286, 32);
            this.msPurchaseOrders.Text = "Purchase Orders Management";
            this.msPurchaseOrders.Click += new System.EventHandler(this.msPurchaseOrders_Click);
            // 
            // msWarehouse
            // 
            this.msWarehouse.Name = "msWarehouse";
            this.msWarehouse.ShortcutKeyDisplayString = "Ctrl+W";
            this.msWarehouse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.msWarehouse.Size = new System.Drawing.Size(242, 32);
            this.msWarehouse.Text = "Warehouse Management";
            this.msWarehouse.Click += new System.EventHandler(this.msWarehouse_Click);
            // 
            // dgvIM
            // 
            this.dgvIM.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvIM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPartName,
            this.colType,
            this.colDate,
            this.colAmount,
            this.colSource,
            this.ColDestination,
            this.colAction1,
            this.colAction2});
            this.dgvIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIM.Location = new System.Drawing.Point(0, 36);
            this.dgvIM.Name = "dgvIM";
            this.dgvIM.RowTemplate.Height = 24;
            this.dgvIM.Size = new System.Drawing.Size(1882, 917);
            this.dgvIM.TabIndex = 1;
            this.dgvIM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIM_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "Column1";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colPartName
            // 
            this.colPartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPartName.HeaderText = "Part Name ";
            this.colPartName.MinimumWidth = 394;
            this.colPartName.Name = "colPartName";
            this.colPartName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.HeaderText = "Transaction Type ";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 150;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 109;
            // 
            // colSource
            // 
            this.colSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSource.HeaderText = "Source";
            this.colSource.Name = "colSource";
            this.colSource.ReadOnly = true;
            // 
            // ColDestination
            // 
            this.ColDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDestination.HeaderText = "Destination ";
            this.ColDestination.Name = "ColDestination";
            this.ColDestination.ReadOnly = true;
            // 
            // colAction1
            // 
            this.colAction1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAction1.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAction1.HeaderText = "Action";
            this.colAction1.Name = "colAction1";
            this.colAction1.Text = "";
            this.colAction1.Width = 73;
            // 
            // colAction2
            // 
            this.colAction2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAction2.HeaderText = "Action";
            this.colAction2.Name = "colAction2";
            this.colAction2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAction2.VisitedLinkColor = System.Drawing.Color.Blue;
            this.colAction2.Width = 73;
            // 
            // fIM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.Controls.Add(this.dgvIM);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msPurchaseOrders;
        private System.Windows.Forms.ToolStripMenuItem msWarehouse;
        private System.Windows.Forms.DataGridView dgvIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDestination;
        private System.Windows.Forms.DataGridViewLinkColumn colAction1;
        private System.Windows.Forms.DataGridViewLinkColumn colAction2;
    }
}

