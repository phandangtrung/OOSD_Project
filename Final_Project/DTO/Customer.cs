using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Customer
    {
        public Customer(int id, string fname, string lname, DateTime birthday, string gender, string phone)
        {
            this.Id = id;
            this.Fname = fname;
            this.Lname = lname;
            this.Brithday = birthday;
            this.Gender = gender;
            this.Phone = phone;
        }
        public Customer(DataRow row)
        {
            this.Id = (Int32)row["IDCus"];
            this.Fname = row["FirstN"].ToString();
            this.Lname = row["LastN"].ToString();
            this.Gender = row["Gender"].ToString();
            this.Phone = row["Phone"].ToString();
            this.Brithday = (DateTime)row["Birthday"];
        }

        private int id;
        private string fname;
        private string lname;
        private DateTime brithday;
        private string gender;
        private String phone;

        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public DateTime Brithday { get => brithday; set => brithday = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
