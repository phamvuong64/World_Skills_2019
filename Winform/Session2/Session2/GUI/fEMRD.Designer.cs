namespace Session2.GUI
{
    partial class fEMRD
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_ComletedOn = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.rtbx_TechnicianNote = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_AssetsName = new System.Windows.Forms.Label();
            this.lbl_AssetsSN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_ListPart = new System.Windows.Forms.DataGridView();
            this.btn_AddtoList = new System.Windows.Forms.Button();
            this.tbx_Amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_PartName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListPart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(542, 678);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(171, 42);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(322, 678);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(171, 42);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Send Request";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_ComletedOn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtp_StartDate);
            this.groupBox2.Controls.Add(this.rtbx_TechnicianNote);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assets EM Report";
            // 
            // dtp_ComletedOn
            // 
            this.dtp_ComletedOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ComletedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ComletedOn.Location = new System.Drawing.Point(629, 56);
            this.dtp_ComletedOn.Name = "dtp_ComletedOn";
            this.dtp_ComletedOn.Size = new System.Drawing.Size(189, 30);
            this.dtp_ComletedOn.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Completed On:";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDate.Location = new System.Drawing.Point(129, 56);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(189, 30);
            this.dtp_StartDate.TabIndex = 5;
            // 
            // rtbx_TechnicianNote
            // 
            this.rtbx_TechnicianNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbx_TechnicianNote.Location = new System.Drawing.Point(129, 140);
            this.rtbx_TechnicianNote.Name = "rtbx_TechnicianNote";
            this.rtbx_TechnicianNote.Size = new System.Drawing.Size(859, 73);
            this.rtbx_TechnicianNote.TabIndex = 4;
            this.rtbx_TechnicianNote.Text = "";
            this.rtbx_TechnicianNote.MouseLeave += new System.EventHandler(this.rtbx_TechnicianNote_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Technician Note:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Department);
            this.groupBox1.Controls.Add(this.lbl_AssetsName);
            this.groupBox1.Controls.Add(this.lbl_AssetsSN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Assets:";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(805, 44);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(0, 25);
            this.lbl_Department.TabIndex = 5;
            // 
            // lbl_AssetsName
            // 
            this.lbl_AssetsName.AutoSize = true;
            this.lbl_AssetsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssetsName.Location = new System.Drawing.Point(430, 44);
            this.lbl_AssetsName.Name = "lbl_AssetsName";
            this.lbl_AssetsName.Size = new System.Drawing.Size(0, 25);
            this.lbl_AssetsName.TabIndex = 4;
            // 
            // lbl_AssetsSN
            // 
            this.lbl_AssetsSN.AutoSize = true;
            this.lbl_AssetsSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssetsSN.Location = new System.Drawing.Point(124, 44);
            this.lbl_AssetsSN.Name = "lbl_AssetsSN";
            this.lbl_AssetsSN.Size = new System.Drawing.Size(0, 25);
            this.lbl_AssetsSN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assets Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assets SN:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_ListPart);
            this.groupBox3.Controls.Add(this.btn_AddtoList);
            this.groupBox3.Controls.Add(this.tbx_Amount);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbx_PartName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(997, 289);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement Parts";
            // 
            // dgv_ListPart
            // 
            this.dgv_ListPart.AllowUserToAddRows = false;
            this.dgv_ListPart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ListPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPartName,
            this.colAmount,
            this.colAction});
            this.dgv_ListPart.Location = new System.Drawing.Point(6, 103);
            this.dgv_ListPart.Name = "dgv_ListPart";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ListPart.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListPart.RowTemplate.Height = 24;
            this.dgv_ListPart.Size = new System.Drawing.Size(976, 150);
            this.dgv_ListPart.TabIndex = 8;
            this.dgv_ListPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListPart_CellClick);
            // 
            // btn_AddtoList
            // 
            this.btn_AddtoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddtoList.Location = new System.Drawing.Point(817, 44);
            this.btn_AddtoList.Name = "btn_AddtoList";
            this.btn_AddtoList.Size = new System.Drawing.Size(171, 42);
            this.btn_AddtoList.TabIndex = 7;
            this.btn_AddtoList.Text = "+ Add to list";
            this.btn_AddtoList.UseVisualStyleBackColor = true;
            this.btn_AddtoList.Click += new System.EventHandler(this.btn_AddtoList_Click);
            // 
            // tbx_Amount
            // 
            this.tbx_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Amount.Location = new System.Drawing.Point(617, 56);
            this.tbx_Amount.Name = "tbx_Amount";
            this.tbx_Amount.Size = new System.Drawing.Size(188, 30);
            this.tbx_Amount.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(525, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Amount:";
            // 
            // cbx_PartName
            // 
            this.cbx_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PartName.FormattingEnabled = true;
            this.cbx_PartName.Location = new System.Drawing.Point(128, 58);
            this.cbx_PartName.Name = "cbx_PartName";
            this.cbx_PartName.Size = new System.Drawing.Size(378, 30);
            this.cbx_PartName.TabIndex = 3;
            this.cbx_PartName.SelectedIndexChanged += new System.EventHandler(this.cbx_PartName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Part Name:";
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            this.colID.Width = 63;
            // 
            // colPartName
            // 
            this.colPartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPartName.FillWeight = 157.7585F;
            this.colPartName.HeaderText = "Part Name";
            this.colPartName.Name = "colPartName";
            // 
            // colAmount
            // 
            this.colAmount.FillWeight = 68.52792F;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 117;
            // 
            // colAction
            // 
            this.colAction.FillWeight = 73.71365F;
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Width = 79;
            // 
            // fEMRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fEMRD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Mainternance Management Details";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_ComletedOn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.RichTextBox rtbx_TechnicianNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_AssetsName;
        private System.Windows.Forms.Label lbl_AssetsSN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_ListPart;
        private System.Windows.Forms.Button btn_AddtoList;
        private System.Windows.Forms.TextBox tbx_Amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_PartName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewLinkColumn colAction;
    }
}