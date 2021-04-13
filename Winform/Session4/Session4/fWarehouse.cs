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
    public partial class fWarehouse : Form
    {
        public fWarehouse()
        {
            InitializeComponent();

            cbxSource.DisplayMember = "Name";
            cbxSource.ValueMember = "ID";
            cbxSource.DataSource = Connect.db.Warehouses.Select(c => c).ToList();

            cbxDestination.DisplayMember = "Name";
            cbxDestination.ValueMember = "ID";
            cbxDestination.DataSource = Connect.db.Warehouses.Select(c => c).ToList();
            
        }

        private void cbxSource_SelectedIndexChanged(object sender, EventArgs e)
        {

            long sourceID = Convert.ToInt64(cbxSource.SelectedValue);
            cbxPartName.DisplayMember = "Name";
            cbxPartName.ValueMember = "ID";
            cbxPartName.DataSource = Connect.db.OrderItems.Where(c => c.Order.SourceWarehouseID == sourceID).Select(c => c.Part).Distinct().ToList();
                

        }

        private void cbxPartName_SelectedIndexChanged(object sender, EventArgs e)
        {

                long partID = Convert.ToInt64(cbxPartName.SelectedValue);
                cbxBatchNum.DataSource = Connect.db.OrderItems.Where(c => c.PartID == partID).Select(c => c.BatchNumber).Distinct().ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool checkBatch = false;
            for (int i = 0; i < dgvListPart.Rows.Count; i++)
            {
                if (dgvListPart.Rows[i].Cells[2].Value.ToString()==cbxBatchNum.Text)
                {
                    checkBatch = true;
                }
            }

            if (checkBatch == false)
            {
                decimal a;
                if (decimal.TryParse(txtAmount.Text, out a) && a >= 0)
                {
                    dgvListPart.Rows.Add();
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[1].Value = cbxPartName.Text;
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[2].Value = cbxBatchNum.Text; 
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[3].Value = txtAmount.Text;
                    dgvListPart.Rows[dgvListPart.Rows.Count - 1].Cells[4].Value = "Remove";
                }
                else
                {
                    MessageBox.Show("Amount không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("BatchNumber đã tồn tại");
            }



        }

        private void dgvListPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                dgvListPart.Rows.RemoveAt(e.RowIndex);
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvListPart.Rows.Count > 0)
            {
                if (cbxSource.Text != cbxDestination.Text)
                {
                    Order order = new Order();
                    order.TransactionTypeID = 2;
                    order.SourceWarehouseID = Convert.ToInt64(cbxSource.SelectedValue);
                    order.DestinationWarehouseID = Convert.ToInt64(cbxDestination.SelectedValue);
                    order.Date = dtpDate.Value;
                    Connect.db.Orders.Add(order);
                    Connect.db.SaveChanges();

                    long orderID = Connect.db.Orders.OrderByDescending(c => c.ID).FirstOrDefault().ID;
                    for (int i = 0; i < dgvListPart.Rows.Count; i++)
                    {
                        OrderItem item = new OrderItem();
                        item.OrderID = orderID;
                        string partName = dgvListPart.Rows[i].Cells[1].Value.ToString();
                        item.PartID = Connect.db.Parts.Where(p => p.Name == partName).FirstOrDefault().ID;
                        item.BatchNumber = dgvListPart.Rows[i].Cells[2].Value.ToString();
                        item.Amount = Convert.ToDecimal(dgvListPart.Rows[i].Cells[3].Value.ToString());
                        Connect.db.OrderItems.Add(item);
                        Connect.db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Source Warehouse và Destination Warehouse phải khác nhau");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần thêm ít nhất một Part Name");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn huỷ bỏ tác vụ này?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                Hide();
            }
        }
    }
}
