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
    public partial class fEMMAdmin : Form
    {

        private int rowIndex;
        public static long emID;

        public fEMMAdmin()
        {
            InitializeComponent();
            Load_dgvEMM();
        }

        private void Load_dgvEMM()
        {

            var list =  Connect.db.EmergencyMaintenances
                .Where(c => c.EMEndDate == null) 
                .Select(c => new
                {
                    c.ID,
                    c.Asset.AssetSN,
                    c.Asset.AssetName,
                    RequestDate = c.EMReportDate,
                    FullName = c.Asset.Employee.FirstName + " " + c.Asset.Employee.LastName,
                    DepartmentName = c.Asset.DepartmentLocation.Department.Name,
                    Prio = c.Priority.Name == "Very High" ? 1 : (c.Priority.Name == "High" ? 2 : (c.Priority.Name == "Normal" ? 3 : 4))

                }).OrderBy(c => c.RequestDate).ThenBy(c => c.Prio).ToList();

            for (int i = 0; i < list.Count(); i++)
            {
                dgvEMM.Rows.Add();
                dgvEMM.Rows[i].Cells["colAssetSN"].Value = list[i].AssetSN;
                dgvEMM.Rows[i].Cells["colAssetName"].Value = list[i].AssetName;
                dgvEMM.Rows[i].Cells["colRequestDate"].Value = list[i].RequestDate.ToShortDateString();
                dgvEMM.Rows[i].Cells["colEmployeeFullName"].Value = list[i].FullName;
                dgvEMM.Rows[i].Cells["colDepartment"].Value = list[i].DepartmentName;
                dgvEMM.Rows[i].Cells["colid"].Value = list[i].ID;
            }

        }

        private void btn_ManageRequest_Click(object sender, EventArgs e)
        {
            if(dgvEMM.SelectedCells.Count > 0)
            {
                emID = Convert.ToInt64(dgvEMM.Rows[rowIndex].Cells["colid"].Value);
                fEMRD fEMRD = new fEMRD();
                Hide();
                fEMRD.ShowDialog();
                dgvEMM.Rows.Clear();
                Load_dgvEMM();
                Show();
            }
            else MessageBox.Show("Bạn cần chọn 1 yêu cầu để tiếp tục","Thông Báo");


        }
    }
}
