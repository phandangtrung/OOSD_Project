using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    class WarehouseDAO
    {
        private static WarehouseDAO instance;
        public static WarehouseDAO Instance
        {
            get { if (instance == null) instance = new WarehouseDAO(); return WarehouseDAO.instance; }
            private set { WarehouseDAO.instance = value; }
        }
    }
}
