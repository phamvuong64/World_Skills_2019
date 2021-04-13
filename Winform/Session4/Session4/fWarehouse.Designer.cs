namespace Session4
{
    partial class fWarehouse
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPartName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvListPart = new System.Windows.Forms.DataGridView();
            this.colD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBatchNum = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(745, 576);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 38);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxDestination
            // 
            this.cbxDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(600, 52);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(334, 33);
            this.cbxDestination.TabIndex = 15;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(596, 25);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(225, 25);
            this.lbl2.TabIndex = 14;
            this.lbl2.Text = "Destination WareHouse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Batch Number:";
            // 
            // cbxPartName
            // 
            this.cbxPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPartName.FormattingEnabled = true;
            this.cbxPartName.Location = new System.Drawing.Point(127, 37);
            this.cbxPartName.Name = "cbxPartName";
            this.cbxPartName.Size = new System.Drawing.Size(448, 33);
            this.cbxPartName.TabIndex = 2;
            this.cbxPartName.SelectedIndexChanged += new System.EventHandler(this.cbxPartName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Part Name:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(1128, 39);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 30);
            this.txtAmount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1036, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Amount:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1302, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add To List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvListPart
            // 
            this.dgvListPart.AllowUserToAddRows = false;
            this.dgvListPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colD,
            this.colPartName,
            this.colBatchNum,
            this.colAmount,
            this.colAction});
            this.dgvListPart.Location = new System.Drawing.Point(16, 86);
            this.dgvListPart.Name = "dgvListPart";
            this.dgvListPart.RowTemplate.Height = 24;
            this.dgvListPart.Size = new System.Drawing.Size(1413, 280);
            this.dgvListPart.TabIndex = 5;
            this.dgvListPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListPart_CellClick);
            // 
            // colD
            // 
            this.colD.HeaderText = "ID";
            this.colD.MinimumWidth = 200;
            this.colD.Name = "colD";
            this.colD.Visible = false;
            this.colD.Width = 300;
            // 
            // colPartName
            // 
            this.colPartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            // 
            // colBatchNum
            // 
            this.colBatchNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBatchNum.HeaderText = "BatchNumber";
            this.colBatchNum.MinimumWidth = 350;
            this.colBatchNum.Name = "colBatchNum";
            this.colBatchNum.Width = 350;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 250;
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 250;
            // 
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAction.HeaderText = "Action";
            this.colAction.MinimumWidth = 250;
            this.colAction.Name = "colAction";
            this.colAction.VisitedLinkColor = System.Drawing.Color.Blue;
            this.colAction.Width = 250;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(572, 576);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 38);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxBatchNum);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgvListPart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxPartName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1446, 389);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts List";
            // 
            // cbxBatchNum
            // 
            this.cbxBatchNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBatchNum.FormattingEnabled = true;
            this.cbxBatchNum.Location = new System.Drawing.Point(784, 36);
            this.cbxBatchNum.Name = "cbxBatchNum";
            this.cbxBatchNum.Size = new System.Drawing.Size(197, 33);
            this.cbxBatchNum.TabIndex = 18;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(88, 112);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(189, 30);
            this.dtpDate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date:";
            // 
            // cbxSource
            // 
            this.cbxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(22, 52);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(334, 33);
            this.cbxSource.TabIndex = 10;
            this.cbxSource.SelectedIndexChanged += new System.EventHandler(this.cbxSource_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(18, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(188, 25);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Source Warehouse:";
            // 
            // fWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 638);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxDestination);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSource);
            this.Controls.Add(this.lbl1);
            this.MaximizeBox = false;
            this.Name = "fWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPartName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvListPart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cbxBatchNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewLinkColumn colAction;
    }
}