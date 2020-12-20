using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Model
{
    class AccountPage_Model
    {
        public Account getInformation(string username)
        {
            Account acc = new Account();
            string sql_sel_info  = "Select HOTEN, SDT, BIRTHDAY, GIOITINH, EMAIL, POSITION  From USERACC Where USERNAME = '" + username + "'";
            acc = Process.getInfo(sql_sel_info);
            return acc;
        }


        public bool changeUserPass(string oldpass, string newpass, string account)
        {
            string sql_update = "update USERACC set USERPASS = '" + newpass + "' where USERPASS = '" + oldpass + "' and USERNAME = '" + account + "'";
            bool ck = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                ck = true;
            }
            return ck;
        }

        public bool saveInfomation(Account acc, int UKEY)
        {
            string sql_update = "Update USERACC set SDT = " + acc.Phone1 + ", BIRTHDAY = '" + acc.Birthday1 + "', "
                + "GIOITINH = N'" + acc.Gender1 + "', EMAIL = '" + acc.Email1 + "' Where UKEY = " + UKEY;
            bool ck = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                ck = true;
            }
            return ck;
        }
    }
}
