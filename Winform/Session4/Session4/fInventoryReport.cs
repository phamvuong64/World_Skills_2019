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
    public partial class fInventoryReport : Form
    {
        public fInventoryReport()
        {
            InitializeComponent();

            cbxWarehouse.DataSource = Connect.db.Warehouses.Select(c => c).ToList();
            cbxWarehouse.DisplayMember = "Name";
            cbxWarehouse.ValueMember = "ID";
            long warehouseID = Convert.ToInt64(cbxWarehouse.SelectedValue);
            var list = Connect.db.OrderItems
                .Where(c => c.Order.SourceWarehouseID == warehouseID)
                .GroupBy(c => c.PartID).ToList();
               
        }

        private void rbtnST_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnRT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnOoS_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
