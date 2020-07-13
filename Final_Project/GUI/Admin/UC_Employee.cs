using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.GUI.Admin;
using Final_Project.DAO;
using System.Globalization;

namespace Final_Project.GUI
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
            Load();
        }
        BindingSource listemploy = new BindingSource();
        void Load()
        {
            LoadListEmploy();
            dtgvEmp.RowTemplate.Height = 25;
            dtgvEmp.DataSource = listemploy;
        }
        void LoadListEmploy()
        {      
           listemploy.DataSource= EmployeeDAO.Instance.GetListEmployee();
        }

        private void btn_AddEm_Click(object sender, EventArgs e)
        {
            string fname = txb_FName.Text;
            string lname = txb_LName.Text;
            DateTime birthday = dtpk_Birth.Value;
            string gender = "Male";
            rb_Female.Checked = true;
            if (rb_Female.Checked)
            {
                gender = "Female";
            }
            string phone = txb_Phone.Text;
            string address = txb_Address.Text;
            int born_year = dtpk_Birth.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (EmployeeDAO.Instance.InsertEmployee( fname, lname, birthday, gender, phone, address))
                {
                    MessageBox.Show("Thêm thành công nhân viên mới", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Error", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif()
        {
            if ((txb_FName.Text.Trim() == "")
                        || (txb_LName.Text.Trim() == "")
                        || (txb_Phone.Text.Trim() == "")
                        || (txb_Phone.Text.Trim() == "")
                        || (txb_Address.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void dtgvEmp_Click(object sender, EventArgs e)
        {
            tbx_id.Text = dtgvEmp.CurrentRow.Cells[0].Value.ToString();
            txb_FName.Text= dtgvEmp.CurrentRow.Cells[1].Value.ToString();
            txb_LName.Text = dtgvEmp.CurrentRow.Cells[2].Value.ToString();
            txb_Address.Text = dtgvEmp.CurrentRow.Cells[5].Value.ToString();
            txb_Phone.Text = dtgvEmp.CurrentRow.Cells[6].Value.ToString();
            dtpk_Birth.Value = (DateTime)dtgvEmp.CurrentRow.Cells[3].Value;
            if ((dtgvEmp.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                rb_Female.Checked = true;
            }
            else
            {
                rb_Male.Checked = true;
            }
        }

        private void btn_RemoveEm_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbx_id.Text);
            if (EmployeeDAO.Instance.DeleteEmployee(id)) 
            {
                MessageBox.Show("Thêm thành công nhân viên mới", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Error", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EditEm_Click(object sender, EventArgs e)
        {
            string id = tbx_id.Text;
            string fname = txb_FName.Text;
            string lname = txb_LName.Text;
            DateTime birthday = dtpk_Birth.Value;
            string gender = "";
            if (rb_Female.Checked == true)
            {
                gender = "Female";
            }
            else
            { gender = "Male"; }
            string phone = txb_Phone.Text;
            string address = txb_Address.Text;
            int born_year = dtpk_Birth.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (EmployeeDAO.Instance.UpdateEmployee(id,fname, lname, birthday, gender, phone, address))
                {
                    MessageBox.Show("Thêm thành công nhân viên mới", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Error", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtgvEmp_DoubleClick(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            ca.Show(this);
        }

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            CreateAccount_Form create = new CreateAccount_Form();
            create.Show(this);
            //create.id = Convert.ToInt32(tbx_id.Text);
        }

        
    }
}
