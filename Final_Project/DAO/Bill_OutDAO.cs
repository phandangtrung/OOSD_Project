using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    class Bill_OutDAO
    {
        private static Bill_OutDAO instance;
        public static Bill_OutDAO Instance
        {
            get { if (instance == null) instance = new Bill_OutDAO(); return Bill_OutDAO.instance; }
            private set { Bill_OutDAO.instance = value; }
        }
    }
}
