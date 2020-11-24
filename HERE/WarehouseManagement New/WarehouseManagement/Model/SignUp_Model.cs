using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Model
{
    class SignUp_Model
    {
        public bool CheckUserExist(string USERNAME)
        {
            Login_Model ck = new Login_Model();
            return ck.checkUserExist(USERNAME);
        }

        public bool CheckRePassword(string pass, string re_pass)
        {
            bool ck = false;
            if (pass == re_pass)
            {
                ck = true;
            }
            return ck;
        }

        public bool SignUpAccount(string HOTEN, string SDT, string USERNAME, string USERPASS, int UKEY)
        {
            string sql_insert = "insert USERACC values (" + UKEY + ", '" + USERNAME + "', '"
                + USERPASS + "', '" + HOTEN + "', '" + SDT + "',null,null,null,null)";
            bool ck = false;
            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                ck = true;
            }
            return ck;
        }
    }
}
