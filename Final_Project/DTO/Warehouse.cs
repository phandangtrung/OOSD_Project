using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Warehouse
    {
        public Warehouse(int id,int idpro,string address,string quantity)
        {
            this.Id = id;
            this.Idpro = idpro;
            this.Address = address;
            this.Quantity = quantity;
        }
        public Warehouse(DataRow row )
        {
            this.Id = (int)row["IDWa"];
            this.Idpro = (int)row["IDPro"];
            this.Address = row["AddressWa"].ToString();
            this.Quantity = row["Quantity"].ToString();
        }

        private int id;
        private int idpro;
        private string address;
        private string quantity;

        public int Id { get => id; set => id = value; }
        public int Idpro { get => idpro; set => idpro = value; }
        public string Address { get => address; set => address = value; }
        public string Quantity { get => quantity; set => quantity = value; }
    }
}
