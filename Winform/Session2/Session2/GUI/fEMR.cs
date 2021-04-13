using Session2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2.GUI
{
    public partial class fEMR : Form
    {
        private string assetSN = fEMMUsername.assetSN;
        public long assetID;
        private long prioriryID;
        public fEMR()
        {
            InitializeComponent();
            lbl_AssetsSN.Text = fEMMUsername.assetSN;
            lbl_AssetsName.Text = fEMMUsername.assetName;

            lbl_Department.Text = Connect.db.Assets
                .Where(a => a.AssetSN == fEMMUsername.assetSN)
                .Select(a => a.DepartmentLocation.Department.Name)
                .FirstOrDefault().ToString();

            cbx_Priority.DisplayMember = "Name";
            cbx_Priority.ValueMember = "ID";
            cbx_Priority.DataSource = Connect.db.Priorities.Select(c => c).ToList();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn huỷ bỏ tác vụ này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void cbx_Priority_SelectedIndexChanged(object sender, EventArgs e)
        {

            prioriryID = Convert.ToInt64(cbx_Priority.SelectedValue.ToString());
        }

        private void btn_SendRequest_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(rtbx_DoE.Text) && string.IsNullOrWhiteSpace(rtbx_OC.Text))
            {
                MessageBox.Show("Các trường không được bỏ trống!", "Cảnh Báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    assetID = Convert.ToInt64((from a in Connect.db.Assets where a.AssetSN == assetSN select a.ID).FirstOrDefault().ToString());
                    if (Connect.db.EmergencyMaintenances.Count(x => x.AssetID == assetID && x.EMEndDate == null) == 0)
                    {
                        EmergencyMaintenance em = new EmergencyMaintenance();
                        em.AssetID = assetID;
                        em.PriorityID = prioriryID;
                        em.DescriptionEmergency = rtbx_DoE.Text;
                        em.OtherConsiderations = rtbx_OC.Text;
                        em.EMReportDate = DateTime.Now;
                        Connect.db.EmergencyMaintenances.Add(em);

                        Connect.db.SaveChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Assets is being opened requests", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
