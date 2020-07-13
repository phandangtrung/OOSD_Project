using Final_Project.DAO;
using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI.User
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userName = tbusername.Text;
            string passWord = tbpassword.Text;

            if (AccountDAO.Instance.Login(userName, passWord))
            {
                //Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                Admin_Form admind_form = new Admin_Form();
                admind_form.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu !");
            }
        }
    }
}
