using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    class CompanyDAO
    {
        private static CompanyDAO instance;
        public static CompanyDAO Instance
        {
            get { if (instance == null) instance = new CompanyDAO(); return CompanyDAO.instance; }
            private set { CompanyDAO.instance = value; }
        }
    }
}
