using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    class BrandDAO
    {
        private static BrandDAO instance;
        public static BrandDAO Instance
        {
            get { if (instance == null) instance = new BrandDAO(); return BrandDAO.instance; }
            private set { BrandDAO.instance = value; }
        }
        public List<Brand> GetListBrand()
        {
            List<Brand> list = new List<Brand>();
            string query = " Select * from Brand";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Brand brand = new Brand(item);
                list.Add(brand);
            }
            return list;
        }

        public bool InsertBrand(string name, string des, int idcate)
        {

            string query = string.Format("INSERT dbo.Brand ( Namebr , Desbr, IDcate )VALUES  ( N'{0}', N'{1}',{2})", name, des,idcate);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateBrand(string name, int id, string des,int idcate)
        {
            string query = string.Format("UPDATE dbo.Brand SET idcate = {3} ,namebr= N'{0}', desbr = N'{2}' WHERE idbr = {1}", name, id, des,idcate);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteBrand(int id)
        {
            string query = string.Format("Delete dbo.Brand where IDbr = {0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteBrandByIDCate(int id)
        {
            string query = string.Format("Delete dbo.Brand where IDcate = {0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "SELECT*FROM CATEGORY where idcate=" + id;
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
    }
}
