using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class fIM : Form
    {
        public static long orderItemID;
        public fIM()
        {
            InitializeComponent();
            loadGDV();
        }
        private void loadGDV()
        {
            var list = Connect.db.OrderItems
                .Select(c => new
                {
                    id = c.ID,
                    partName = c.Part.Name,
                    tranType = c.Order.TransactionType.Name,
                    date = c.Order.Date,
                    amount = c.Amount,sourceID = c.Order.SourceWarehouseID,
                    source = Connect.db.Warehouses.Where(w=> w.ID == c.Order.SourceWarehouseID).FirstOrDefault().Name,
                    destination = Connect.db.Warehouses.Where(w => w.ID == c.Order.DestinationWarehouseID).FirstOrDefault().Name,
                    levelType = c.Order.TransactionType.Name == "Purchase Order" ? 1 : 2

                }).OrderBy(c => c.date).ThenBy(c => c.levelType).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                dgvIM.Rows.Add();
                dgvIM.Rows[i].Cells["colID"].Value = list[i].id;
                dgvIM.Rows[i].Cells["colPartName"].Value = list[i].partName;
                dgvIM.Rows[i].Cells["colType"].Value = list[i].tranType;
                dgvIM.Rows[i].Cells["colDate"].Value = list[i].date.ToShortDateString();
                dgvIM.Rows[i].Cells["colAmount"].Value = list[i].amount;
                dgvIM.Rows[i].Cells["colSource"].Value = list[i].source;
                dgvIM.Rows[i].Cells["colDestination"].Value = list[i].destination;
                dgvIM.Rows[i].Cells["colAction1"].Value = "Edit";
                dgvIM.Rows[i].Cells["colAction2"].Value = "Remove";

                if (dgvIM.Rows[i].Cells["colType"].Value.ToString() == "Purchase Order")
                {
                    dgvIM.Rows[i].Cells["colAmount"].Style.BackColor = Color.Green;
                }

            }

        }


        private void dgvIM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 8 && MessageBox.Show("Xoá bản ghi này có thể làm dữ liệu bị thay đổi.\nBạn vẫn muốn tiếp tục?", "Thông Báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    long id = Convert.ToInt64(dgvIM.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var rl = Connect.db.OrderItems.SingleOrDefault(c => c.ID == id);
                    Connect.db.OrderItems.Remove(rl);
                    Connect.db.SaveChanges();
                    dgvIM.Rows.Clear();
                    loadGDV();
                }

                if(e.ColumnIndex == 7)
                {
                    if (dgvIM.Rows[e.RowIndex].Cells[2].Value.ToString() == "Purchase Order")
                    {
                        orderItemID = Convert.ToInt64(dgvIM.Rows[e.RowIndex].Cells[0].Value);
                        fEdit fm = new fEdit();
                        fm.ShowDialog();
                        dgvIM.Rows.Clear();
                        loadGDV();
                        dgvIM.Rows[e.RowIndex].Selected = true;
                    }
                    else
                    {
                        orderItemID = Convert.ToInt64(dgvIM.Rows[e.RowIndex].Cells[0].Value);
                        fEdit fm = new fEdit();
                        fm.ShowDialog();
                        dgvIM.Rows.Clear();
                        loadGDV();
                        dgvIM.Rows[e.RowIndex].Selected = true;
                    }
                }
            }
        }

        private void msPurchaseOrders_Click(object sender, EventArgs e)
        {
            fPurchase fm = new fPurchase();
            Hide();
            fm.ShowDialog();
            dgvIM.Rows.Clear();
            loadGDV();
            Show();
        }

        private void msWarehouse_Click(object sender, EventArgs e)
        {
            fWarehouse fm = new fWarehouse();
            Hide();
            fm.ShowDialog();
            dgvIM.Rows.Clear();
            loadGDV();
            Show();
        }

        private void msInventoryReport_Click(object sender, EventArgs e)
        {
            fInventoryReport fm = new fInventoryReport();
            Hide();
            fm.ShowDialog();
            Show();
        }
    }
}
