namespace Session2.GUI
{
    partial class fEMR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_AssetsName = new System.Windows.Forms.Label();
            this.lbl_AssetsSN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbx_OC = new System.Windows.Forms.RichTextBox();
            this.rtbx_DoE = new System.Windows.Forms.RichTextBox();
            this.cbx_Priority = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SendRequest = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Assets:";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(813, 44);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(0, 25);
            this.lbl_Department.TabIndex = 5;
            // 
            // lbl_AssetsName
            // 
            this.lbl_AssetsName.AutoSize = true;
            this.lbl_AssetsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AssetsName.Location = new System.Drawing.Point(438, 44);
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
            this.label3.Location = new System.Drawing.Point(688, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 44);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbx_OC);
            this.groupBox2.Controls.Add(this.rtbx_DoE);
            this.groupBox2.Controls.Add(this.cbx_Priority);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Report";
            // 
            // rtbx_OC
            // 
            this.rtbx_OC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbx_OC.Location = new System.Drawing.Point(118, 262);
            this.rtbx_OC.Name = "rtbx_OC";
            this.rtbx_OC.Size = new System.Drawing.Size(867, 73);
            this.rtbx_OC.TabIndex = 5;
            this.rtbx_OC.Text = "";
            // 
            // rtbx_DoE
            // 
            this.rtbx_DoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbx_DoE.Location = new System.Drawing.Point(118, 140);
            this.rtbx_DoE.Name = "rtbx_DoE";
            this.rtbx_DoE.Size = new System.Drawing.Size(867, 73);
            this.rtbx_DoE.TabIndex = 4;
            this.rtbx_DoE.Text = "";
            // 
            // cbx_Priority
            // 
            this.cbx_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Priority.FormattingEnabled = true;
            this.cbx_Priority.Location = new System.Drawing.Point(118, 53);
            this.cbx_Priority.Name = "cbx_Priority";
            this.cbx_Priority.Size = new System.Drawing.Size(322, 33);
            this.cbx_Priority.TabIndex = 3;
            this.cbx_Priority.SelectedIndexChanged += new System.EventHandler(this.cbx_Priority_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Other Considerations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description of Emergency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Priority:";
            // 
            // btn_SendRequest
            // 
            this.btn_SendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendRequest.Location = new System.Drawing.Point(332, 503);
            this.btn_SendRequest.Name = "btn_SendRequest";
            this.btn_SendRequest.Size = new System.Drawing.Size(171, 42);
            this.btn_SendRequest.TabIndex = 2;
            this.btn_SendRequest.Text = "Send Request";
            this.btn_SendRequest.UseVisualStyleBackColor = true;
            this.btn_SendRequest.Click += new System.EventHandler(this.btn_SendRequest_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(552, 503);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(171, 42);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // fEMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 568);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SendRequest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fEMR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emergency Mainternance Request";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_AssetsName;
        private System.Windows.Forms.Label lbl_AssetsSN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbx_OC;
        private System.Windows.Forms.RichTextBox rtbx_DoE;
        private System.Windows.Forms.ComboBox cbx_Priority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SendRequest;
        private System.Windows.Forms.Button btn_Cancel;
    }
}