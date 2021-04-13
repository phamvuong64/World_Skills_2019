namespace Session4
{
    partial class fInventoryReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxWarehouse = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOoS = new System.Windows.Forms.RadioButton();
            this.rbtnRT = new System.Windows.Forms.RadioButton();
            this.rbtnST = new System.Windows.Forms.RadioButton();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurruntStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse";
            // 
            // cbxWarehouse
            // 
            this.cbxWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxWarehouse.FormattingEnabled = true;
            this.cbxWarehouse.Location = new System.Drawing.Point(37, 63);
            this.cbxWarehouse.Name = "cbxWarehouse";
            this.cbxWarehouse.Size = new System.Drawing.Size(385, 33);
            this.cbxWarehouse.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOoS);
            this.groupBox1.Controls.Add(this.rbtnRT);
            this.groupBox1.Controls.Add(this.rbtnST);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(454, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Report";
            // 
            // rbtnOoS
            // 
            this.rbtnOoS.AutoSize = true;
            this.rbtnOoS.Location = new System.Drawing.Point(428, 31);
            this.rbtnOoS.Name = "rbtnOoS";
            this.rbtnOoS.Size = new System.Drawing.Size(146, 29);
            this.rbtnOoS.TabIndex = 2;
            this.rbtnOoS.TabStop = true;
            this.rbtnOoS.Text = "Out of Stock ";
            this.rbtnOoS.UseVisualStyleBackColor = true;
            this.rbtnOoS.CheckedChanged += new System.EventHandler(this.rbtnOoS_CheckedChanged);
            // 
            // rbtnRT
            // 
            this.rbtnRT.AutoSize = true;
            this.rbtnRT.Location = new System.Drawing.Point(209, 31);
            this.rbtnRT.Name = "rbtnRT";
            this.rbtnRT.Size = new System.Drawing.Size(174, 29);
            this.rbtnRT.TabIndex = 1;
            this.rbtnRT.TabStop = true;
            this.rbtnRT.Text = "Received Stock ";
            this.rbtnRT.UseVisualStyleBackColor = true;
            this.rbtnRT.CheckedChanged += new System.EventHandler(this.rbtnRT_CheckedChanged);
            // 
            // rbtnST
            // 
            this.rbtnST.AutoSize = true;
            this.rbtnST.Location = new System.Drawing.Point(6, 31);
            this.rbtnST.Name = "rbtnST";
            this.rbtnST.Size = new System.Drawing.Size(153, 29);
            this.rbtnST.TabIndex = 0;
            this.rbtnST.TabStop = true;
            this.rbtnST.Text = "Currunt Stock";
            this.rbtnST.UseVisualStyleBackColor = true;
            this.rbtnST.CheckedChanged += new System.EventHandler(this.rbtnST_CheckedChanged);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPartName,
            this.colCurruntStock,
            this.colReceivedStock,
            this.colAction});
            this.dgvResult.Location = new System.Drawing.Point(12, 175);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(1041, 370);
            this.dgvResult.TabIndex = 3;
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
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            // 
            // colCurruntStock
            // 
            this.colCurruntStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCurruntStock.HeaderText = "Currunt Stock";
            this.colCurruntStock.MinimumWidth = 200;
            this.colCurruntStock.Name = "colCurruntStock";
            this.colCurruntStock.Width = 200;
            // 
            // colReceivedStock
            // 
            this.colReceivedStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReceivedStock.HeaderText = "Received Stock";
            this.colReceivedStock.MinimumWidth = 200;
            this.colReceivedStock.Name = "colReceivedStock";
            this.colReceivedStock.Width = 200;
            // 
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAction.HeaderText = "Action";
            this.colAction.MinimumWidth = 200;
            this.colAction.Name = "colAction";
            this.colAction.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // fInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxWarehouse);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "fInventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxWarehouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnST;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnOoS;
        private System.Windows.Forms.RadioButton rbtnRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurruntStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
    }
}