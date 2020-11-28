using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Model
{
    class Login_Model
    {
        public bool checkUserExist(string username)
        {
            string sql_sel = "Select USERNAME From USERACC Where USERNAME = '" + username + "'";
            bool ck = false;
            if (Process.ExecutiveReader(sql_sel) > 0)
            {
                ck = true;
            }
            return ck;
        }

        public bool checkUser(string username, string password)
        {
            string sql_sel = "Select USERNAME From USERACC Where USERNAME = '" + username + "' and USERPASS = '" + password + "'";
            bool ck = false;
            if (Process.ExecutiveReader(sql_sel) > 0)
            {
                ck = true;
            }
            return ck;
        }
        public bool checkAdmin(string username, string password)
        {
            string sql_sel = "Select UKEY From USERACC Where USERNAME = '" + username + "' and USERPASS = '" + password + "'";
            bool ck = false;
            if (Process.GetUkey(sql_sel) == 19521334)
            {
                ck = true;
            }
            return ck;
        }
    }
}
