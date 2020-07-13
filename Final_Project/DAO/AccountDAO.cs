using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
         public DataTable GetlistAcc()
        {
            return MyDB.Instance.ExcuteQuery("Select FirstN  'Họ',LastN 'Tên',USERNAME 'Tên đăng nhập', Pos 'Quyền' ,a.IDEm 'Mã nhân viên' from Employee as e,Account as a where a.IDEm=e.IDEm");
        }
        public bool InsertAccount(string username, int pos, int idem)
        {
            string query = string.Format(" EXEC USP_INSERTACCOUNT @idem= {0}, @username =N'{1}', @pos= {2}", idem, username, pos);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool RemoveAccount( int idem)
        {
            string query = string.Format(" DELETE dbo.Account where idem = {0}", idem);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(int id,string username, int pos)
        {
            string query = string.Format("UPDATE dbo.Account SET UserName = N'{1}',Pos = {2}  WHERE idem = {0}", id, username,pos);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = MyDB.Instance.ExcuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = MyDB.Instance.ExcuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
    }
}
