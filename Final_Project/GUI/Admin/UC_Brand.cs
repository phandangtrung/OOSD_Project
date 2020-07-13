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
using Final_Project.DTO;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Brand : UserControl
    {
        BindingSource brandlist = new BindingSource();
        public UC_Brand()
        {
            InitializeComponent();
            Load();
        }
        new void Load()
        {
            dtgv_brand.DataSource = brandlist;
            LoadlistBrand();
            AddBrand();
            LoadCombox(cb_cate);
        }
        void LoadCombox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadlistBrand()
        {
            brandlist.DataSource = BrandDAO.Instance.GetListBrand();       
        }
        void AddBrand()
        {
            txb_desbr.DataBindings.Add(new Binding("Text", dtgv_brand.DataSource, "Des", true, DataSourceUpdateMode.Never));
            txb_namebrand.DataBindings.Add(new Binding("Text", dtgv_brand.DataSource, "Name", true, DataSourceUpdateMode.Never));
         
           
        }
        private void btn_AddBr_Click(object sender, EventArgs e)
        {
            string des = txb_desbr.Text;
            string name = txb_namebrand.Text;
            int idcate = (cb_cate.SelectedItem as Category).Id;
            if (BrandDAO.Instance.InsertBrand(name, des, idcate))
            { MessageBox.Show("Thêm thành công !"); }
            else { MessageBox.Show("Thêm thất bại !"); }
            LoadlistBrand();
        }

        private void btn_RemoveBr_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgv_brand.CurrentRow.Cells[0].Value.ToString());
            if (BrandDAO.Instance.DeleteBrand(id))
            {
                MessageBox.Show("Xóa thành công !");
                LoadlistBrand();
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }

        }

        private void btn_editbr_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgv_brand.CurrentRow.Cells[0].Value.ToString());
            string des = txb_desbr.Text;
            string name = txb_namebrand.Text;
            int idcate = (cb_cate.SelectedItem as Category).Id;
            if (BrandDAO.Instance.UpdateBrand(name,id,des,idcate))
            { MessageBox.Show("Thêm thành công !"); }
            else { MessageBox.Show("Thêm thất bại !"); }
            LoadlistBrand();
        }
    }
}
