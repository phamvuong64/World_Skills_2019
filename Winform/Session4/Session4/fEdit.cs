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
    public partial class fEdit : Form
    {
        private OrderItem item = Connect.db.OrderItems.FirstOrDefault(c => c.ID == fIM.orderItemID);
        public fEdit()
        {
            InitializeComponent();
            

            cbxTransType.DisplayMember = "Name";
            cbxTransType.ValueMember = "ID";
            cbxTransType.DataSource = Connect.db.TransactionTypes.Select(c => c).ToList();
            cbxTransType.SelectedIndex = Convert.ToInt32(item.Order.TransactionTypeID - 1);

            dtpDate.Value = item.Order.Date;

            cbxPartName.DisplayMember = "Name";
            cbxPartName.ValueMember = "ID";
            cbxPartName.DataSource = Connect.db.Parts.Select(c => c).ToList();
            cbxPartName.SelectedIndex = Convert.ToInt32(item.PartID - 1);

            txtBatchNum.Text = item.BatchNumber;
            txtAmount.Text = item.Amount.ToString();

            cbxDestination.DisplayMember = "Name";
            cbxDestination.ValueMember = "ID";
            cbxDestination.DataSource = Connect.db.Warehouses.Select(c => c).ToList();
            cbxDestination.SelectedIndex = Convert.ToInt32(item.Order.DestinationWarehouseID - 1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt64(cbxTransType.SelectedValue.ToString()) == 1)
            {
                cbxSuppliers.Enabled = true;
                cbxSource.Enabled = false;
                cbxSource.DataSource = null;
                lblx.Text = "WareHouse:";

                cbxSuppliers.DisplayMember = "Name";
                cbxSuppliers.ValueMember = "ID";
                cbxSuppliers.DataSource = Connect.db.Suppliers.Select(c => c).ToList();
                cbxSuppliers.SelectedIndex = Convert.ToInt32(item.Order.SupplierID - 1);

                
            }
            else
            {
                cbxSource.Enabled = true;
                cbxSuppliers.Enabled = false;
                cbxSuppliers.DataSource = null;
                lblx.Text = "Destination WareHouse:";

                cbxSource.DisplayMember = "Name";
                cbxSource.ValueMember = "ID";
                cbxSource.DataSource = Connect.db.Warehouses.Select(c => c).ToList();
                cbxSource.SelectedIndex = Convert.ToInt32(item.Order.SourceWarehouseID - 1);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                    try
                    {
                        item.Order.TransactionTypeID = Convert.ToInt64(cbxTransType.SelectedValue);
                        if (Convert.ToInt64(cbxTransType.SelectedValue) == 1)
                        {
                            item.Order.SupplierID = Convert.ToInt64(cbxSuppliers.SelectedValue);
                            item.Order.SourceWarehouseID = null;
                        }
                        else
                        {
                            item.Order.SupplierID = null;
                            item.Order.SourceWarehouseID = Convert.ToInt64(cbxSource.SelectedValue);
                        }
                           
                        item.Order.DestinationWarehouseID = Convert.ToInt64(cbxDestination.SelectedValue);
                        item.Order.Date = dtpDate.Value;

                        long partID = Convert.ToInt64(cbxPartName.SelectedValue);
                        item.PartID = partID;
                        bool? check = Connect.db.Parts.Where(c => c.ID == partID).Select(c => c.BatchNumberHasRequired).FirstOrDefault();
                        if (check == true) item.BatchNumber = txtBatchNum.Text;

                        if (decimal.TryParse(txtAmount.Text, out decimal a))
                        {
                            item.Amount = a;
                        }
                        else MessageBox.Show("Amount không hợp lệ");

                        Connect.db.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công");
                    }

            }
            else
            {
                MessageBox.Show("Amount không được bỏ trống");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn huỷ tác vụ này", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) Hide();
        }
    }
}
