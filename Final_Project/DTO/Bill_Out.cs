using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Bill_Out
    {
        public Bill_Out(int iDB_O, int iDcus,int iDem,DateTime dateout,int discount,int checkout, float priceOut)
        {
            this.IDB_O = iDB_O;
            this.IDcus = iDcus;
            this.IDem = iDem;
            this.PriceOut = priceOut;
            this.Dateout = dateout;
            this.Discount = discount;
            this.Checkout = checkout;
        }
         public Bill_Out(DataRow row)
        {
            this.IDB_O = (int)row["IDB_O"];
            this.IDcus = (int)row["IDCus"];
            this.IDem = (int)row["IDEm"];
            this.PriceOut = (float)row["PriceOut"];
            this.Dateout = (DateTime)row["Dateout"];
            this.Discount = (int)row["Discount"];
            this.Checkout = (int)row["Checkout"];
        }

        private int iDB_O;
        private int iDcus;
        private int iDem;
        private DateTime dateout;
        private int discount;
        private int checkout;
        private float priceOut;

        public int IDB_O { get => iDB_O; set => iDB_O = value; }
        public int IDcus { get => iDcus; set => iDcus = value; }
        public int IDem { get => iDem; set => iDem = value; }
        public DateTime Dateout { get => dateout; set => dateout = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Checkout { get => checkout; set => checkout = value; }
        public float PriceOut { get => priceOut; set => priceOut = value; }
    }
}
