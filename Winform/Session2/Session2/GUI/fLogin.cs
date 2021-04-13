using Session2.DAL;
using Session2.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// user:  josefa - 1234
/// admin: lyn  - 1234
/// </summary>

namespace Session2
{
    public partial class fLogin : Form
    {
        public static int Type;
        public static long id;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbx_username.Text) && string.IsNullOrWhiteSpace(tbx_password.Text))
            {
                MessageBox.Show("The fields must not be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                var result = Connect.db.Employees.SingleOrDefault(x => x.Username == tbx_username.Text && x.Password == tbx_password.Text);
                if(result != null)
                {
                    var Type = result.isAdmin == true ? 1 : 0;
                    
                    switch (Type)
                    {
                      
                        case 0:
                            id = result.ID;
                            fEMMUsername EMMU = new fEMMUsername();
                            this.Hide();
                            EMMU.ShowDialog();
                            tbx_username.Text = "";
                            tbx_password.Text = "";
                            this.Show();
                            break;
                        case 1:
                            id = result.ID;
                            fEMMAdmin EMMA = new fEMMAdmin();
                            this.Hide();
                            EMMA.ShowDialog();
                            tbx_username.Text = "";
                            tbx_password.Text = "";
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông Báo");
                    tbx_username.Focus();
                }
                
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát?","Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
