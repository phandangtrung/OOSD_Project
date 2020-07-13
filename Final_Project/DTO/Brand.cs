using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Brand
    {
        public Brand(int id, string name, string des,int idcate)
        {
            this.Id = id;
            this.Name = name;
            this.Des = des;
            this.Idcate = idcate;
        }
        public Brand(DataRow row)
        {
            this.Id = (int)row["IDBr"];
            this.Name = row["NameBr"].ToString();
            this.Des = row["DesBr"].ToString();
            this.Idcate = (int)row["IDCate"];
        }
        private int id;
        private int idcate;
        private string des;
        private string name;

        public int Id { get => id; set => id = value; }
        public int Idcate { get => idcate; set => idcate = value; }
        public string Des { get => des; set => des = value; }
        public string Name { get => name; set => name = value; }
    }
}
