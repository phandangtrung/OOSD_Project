using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.DAO;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Account : UserControl
    {
        BindingSource accountlist = new BindingSource();
        public UC_Account()
        {
            InitializeComponent();

            loadlistaccount();
        }
        void loadlistaccount()
        {
            dtgvAccount.DataSource = AccountDAO.Instance.GetlistAcc();
        }
      

        private void dtgvAccount_Click(object sender, EventArgs e)
        {
            txb_idem.Text = dtgvAccount.CurrentRow.Cells[4].Value.ToString();
            txb_username.Text = dtgvAccount.CurrentRow.Cells[2].Value.ToString();
            txb_name.Text = dtgvAccount.CurrentRow.Cells[1].Value.ToString();
            string pos = dtgvAccount.CurrentRow.Cells[3].Value.ToString();
            if (pos =="1")
            {
                rbAdmin.Checked = true;
            }
            else
            {
                if (pos == "2")
                {
                   rb_sale.Checked = true;
                }
                else
                {
                   rb_ware.Checked = true;
                }
            }
        }

        private void btn_updateAcc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txb_idem.Text);
            string username = txb_username.Text;
            int pos = 0;
            if (rbAdmin.Checked == true)
            {
                pos = 1;
            }
            else
            {
                if (rb_sale.Checked == true)
                {
                    pos = 2;
                }
                else
                {
                    pos = 3;
                }
            }
            if (AccountDAO.Instance.UpdateAccount(id,username,pos))
            {
                MessageBox.Show("Thêm thành tài khoản mới", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaccount();
            }
            else
            {
                MessageBox.Show("Error", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_RemoveAcc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txb_idem.Text);
            if (AccountDAO.Instance.RemoveAccount(id))
            {
                MessageBox.Show("Thêm thành tài khoản mới", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaccount();
            }
            else
            {
                MessageBox.Show("Error", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
