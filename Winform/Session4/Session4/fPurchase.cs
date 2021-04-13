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
    public partial class fPurchase : Form
    {
        public fPurchase()
        {
            InitializeComponent();

            cbxSuppliers.DisplayMember = "Name";
            cbxSuppliers.ValueMember = "ID";
            cbxSuppliers.DataSource = Connect.db.Suppliers.Select(c => c).ToList();
            

            cbxWareHouse.DisplayMember = "Name";
            cbxWareHouse.ValueMember = "ID";
            cbxWareHouse.DataSource = Connect.db.Warehouses.Select(c => c).ToList();

            cbxPartName.DisplayMember = "Name";
            cbxPartName.ValueMember = "ID";
            cbxPartName.DataSource = Connect.db.Parts.Select(c => c).ToList();
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool rl = false;
            for (int i = 0; i < dgvListPart.Rows.Count; i++)
            {
                if(txtBatchNum.Text == dgvListPart.Rows[i].Cells[2].Value.ToString())
                {
                    rl = true;
                }
            }
            
            if(!rl)
            {
                decimal a;
                if (decimal.TryParse(txtAmount.Text, out a) && a > 0)
                {
                    dgvListPart.Rows.Add();
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[1].Value = cbxPartName.Text;
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[2].Value = txtBatchNum.Text;
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[3].Value = a;
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[4].Value = "Remove";
                }
                else
                {
                    MessageBox.Show("Amount không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("BatchNumBer đã tồn tại");
            }


        }

        private void dgvListPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex ==4)
            {
                dgvListPart.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (dgvListPart.Rows.Count > 0)
            {
                Order order = new Order();
                order.TransactionTypeID = 1;
                order.SupplierID = Convert.ToInt64(cbxSuppliers.SelectedValue);
                order.DestinationWarehouseID = Convert.ToInt64(cbxWareHouse.SelectedValue);
                order.Date = dtpDate.Value;
                Connect.db.Orders.Add(order);
                Connect.db.SaveChanges();

                long orderID = Connect.db.Orders.OrderByDescending(o => o.ID).FirstOrDefault().ID;
                for (int i = 0; i < dgvListPart.Rows.Count; i++)
                {
                    string partName = dgvListPart.Rows[i].Cells[1].Value.ToString();
                    bool? checkBat = Connect.db.Parts.Where(c => c.Name == partName).Select(c => c.BatchNumberHasRequired).FirstOrDefault();

                    OrderItem item = new OrderItem();
                    item.OrderID = orderID;
                    item.PartID = Connect.db.Parts.Where(p=>p.Name == partName).FirstOrDefault().ID;
                    if (checkBat == true)
                    {
                        item.BatchNumber = dgvListPart.Rows[i].Cells[2].Value.ToString();
                    }
                    item.Amount = Convert.ToDecimal(dgvListPart.Rows[i].Cells[3].Value.ToString());
                    Connect.db.OrderItems.Add(item);
                    Connect.db.SaveChanges();
                }

            }
            else
            {
                MessageBox.Show("Bạn cần thêm vào ít nhất 1 Part Name");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn huỷ bỏ tác vụ này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Hide();
            }
        }
    }

}
