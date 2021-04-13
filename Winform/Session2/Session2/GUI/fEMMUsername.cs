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
    public partial class fEMMUsername : Form
    {
        private long emloyeeID = fLogin.id;

        public static string assetSN;
        public static string assetName;

        public fEMMUsername()
        {
            InitializeComponent();
            btn_SendEMR.Enabled = false;
            Load_dgvEMM();
        }

        private void Load_dgvEMM()
        {

            dgvEMM.DataSource = Connect.db.EmergencyMaintenances
                .Where(c => c.Asset.Employee.ID == fLogin.id)
                .Select(c => new
                {

                    AssetSN = c.Asset.AssetSN,
                    AssetName = c.Asset.AssetName,
                    EndDate = c.EMEndDate,
                    Number = c.ChangedParts.Count(p => p.EmergencyMaintenanceID == c.ID)
                }).ToList();

            dgvEMM.Columns[2].HeaderText = "Last Cloed EM";
            dgvEMM.Columns[3].HeaderText = "Number of EMs";

        }


        private void dgvEMM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                assetSN = dgvEMM.Rows[e.RowIndex].Cells[0].Value.ToString();
                assetName = dgvEMM.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (assetSN != "")
                {
                    btn_SendEMR.Enabled = true;
                }
                else
                {
                    btn_SendEMR.Enabled = false;
                }

                if (Convert.ToString(dgvEMM.Rows[e.RowIndex].Cells[2].Value) == string.Empty)
                {
                    dgvEMM.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
                }
            }
        }

        private void btn_SendEMR_Click(object sender, EventArgs e)
        {
            if (dgvEMM.SelectedCells.Count > 0)
            {
                fEMR fEMR = new fEMR();
                Hide();
                fEMR.ShowDialog();
                Load_dgvEMM();
                Show();
            }
            else MessageBox.Show("Bạn cần chọn 1 yêu cầu để tiếp tục");

        }

        private void fEMMUsername_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvEMM.Rows.Count; i++)
            {
                if (Convert.ToString(dgvEMM.Rows[i].Cells[2].Value) == string.Empty)
                {
                    dgvEMM.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
