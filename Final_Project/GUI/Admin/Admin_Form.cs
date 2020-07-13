using Final_Project.DTO;
using Final_Project.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI
{
    public partial class Admin_Form : Form
    {
        //private Account loginAccount;

        //public Account LoginAccount
        //{
        //    get { return loginAccount; }
        //    set
        //    {
        //        loginAccount = value;
        //        Changeaccount(loginAccount.Pos);
        //    }
        //}

        public Admin_Form()
        {
            InitializeComponent();
        }
        void Changeaccount(int type)
        {
            
        }
        private void btn_Em_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Employee uc = new UC_Employee();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Category uc = new UC_Category();
            //uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Account uc = new UC_Account();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Brand uc = new UC_Brand();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }
    }
}
