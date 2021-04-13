using Session2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2.GUI
{
    public partial class fEMRD : Form
    {
        private static long partID;
        private static DateTime reportDate;
        public fEMRD()
        {
            InitializeComponent();
            EmergencyMaintenance em = Connect.db.EmergencyMaintenances.FirstOrDefault(x => x.ID == fEMMAdmin.emID);
            lbl_AssetsSN.Text = em.Asset.AssetSN;
            lbl_AssetsName.Text = em.Asset.AssetName;
            lbl_Department.Text = em.Asset.DepartmentLocation.Department.Name;
            reportDate = em.EMReportDate;
            dtp_ComletedOn.Enabled = false;
            btn_Submit.Enabled = false;

            cbx_PartName.DisplayMember = "Name";
            cbx_PartName.ValueMember = "ID";
            cbx_PartName.DataSource = (from p in Connect.db.Parts select p).ToList();

            Load_ListPart();
        }

        private void Load_ListPart()
        {
            var cp = Connect.db.ChangedParts.Where(c => c.EmergencyMaintenanceID == fEMMAdmin.emID).ToList();
            for (int i = 0; i < cp.Count; i++)
            {

                dgv_ListPart.Rows.Add();
                dgv_ListPart.Rows[i].Cells["colID"].Value = cp[i].ID;
                dgv_ListPart.Rows[i].Cells["colPartName"].Value = cp[i].Part.Name;
                dgv_ListPart.Rows[i].Cells["colAmount"].Value = cp[i].Amount;
                dgv_ListPart.Rows[i].Cells["colAction"].Value = "Remove";
            }
        }
        private void rtbx_TechnicianNote_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbx_TechnicianNote.Text))
            {
                dtp_ComletedOn.Enabled = false;
                btn_Submit.Enabled = false;
            }
            else
            {
                dtp_ComletedOn.Enabled = true;
                btn_Submit.Enabled = true;
            }

        }

        private void cbx_PartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            partID = Convert.ToInt64(cbx_PartName.SelectedValue.ToString());

        }

        private void btn_AddtoList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_Amount.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal amount;
                if (decimal.TryParse(tbx_Amount.Text, out amount) && amount > 0)
                {
                    bool check = false;
                    for (int i = 0; i < dgv_ListPart.Rows.Count; i++)
                    {
                        if (cbx_PartName.Text == dgv_ListPart.Rows[i].Cells["colPartName"].Value.ToString())
                        {
                            check = true; 
                        }

                    }
                    if (check == false)
                    {
                        ChangedPart changedPart = new ChangedPart();
                        changedPart.EmergencyMaintenanceID = fEMMAdmin.emID;
                        changedPart.PartID = Connect.db.Parts.FirstOrDefault(x => x.Name == cbx_PartName.Text).ID;
                        changedPart.Amount = amount;
                        Connect.db.ChangedParts.Add(changedPart);
                        Connect.db.SaveChanges();

                        dgv_ListPart.Rows.Clear();
                        Load_ListPart();
                    }
                    else
                    {
                        if (MessageBox.Show("'"+ cbx_PartName.Text + "' Đã tồn tại\nTiếp tục thêm?", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            ChangedPart changedPart = new ChangedPart();
                            changedPart.EmergencyMaintenanceID = fEMMAdmin.emID;
                            changedPart.PartID = Connect.db.Parts.FirstOrDefault(x => x.Name == cbx_PartName.Text).ID;
                            changedPart.Amount = amount;
                            Connect.db.ChangedParts.Add(changedPart);
                            Connect.db.SaveChanges();

                            dgv_ListPart.Rows.Clear();
                            Load_ListPart();
                        }
                    }

                }
                else MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_ListPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {

                long id = Convert.ToInt64(dgv_ListPart.Rows[e.RowIndex].Cells[0].Value.ToString());
                var rl = Connect.db.ChangedParts.SingleOrDefault(c => c.ID == id);
                Connect.db.ChangedParts.Remove(rl);
                Connect.db.SaveChanges();
                dgv_ListPart.Rows.Clear();
                Load_ListPart();
            }
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (reportDate <= dtp_StartDate.Value)
            {
                if (dtp_StartDate.Value.Date < dtp_ComletedOn.Value.Date)
                {
                    try
                    {
                        var itemEdit = Connect.db.EmergencyMaintenances.FirstOrDefault(x => x.ID == fEMMAdmin.emID);
                        itemEdit.EMStartDate = dtp_StartDate.Value;
                        itemEdit.EMEndDate = dtp_ComletedOn.Value;
                        itemEdit.EMTechnicianNote = rtbx_TechnicianNote.Text;
                        Connect.db.SaveChanges();
                        MessageBox.Show("Thành công");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                else MessageBox.Show("ComletedOnDate không thể thực hiện trước  StarDate", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("StarDate không thể thực hiện trước ReportDate", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn huỷ bỏ tác vụ này", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Hide();
            }
        }

    }
}
