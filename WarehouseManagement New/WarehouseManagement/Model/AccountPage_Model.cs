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
            string sql_sel = "update USERACC set USERPASS = '" + newpass + "' where USERPASS = '" + oldpass + "' and USERNAME = '" + account + "'";
            bool ck = false;
            if (Process.ExecutiveReader(sql_sel) > 0)
            {
                ck = true;
            }
            return ck;
        }
    }
}
