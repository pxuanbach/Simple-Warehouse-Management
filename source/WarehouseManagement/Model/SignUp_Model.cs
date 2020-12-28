using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Model
{
    class SignUp_Model
    {
        public string getUsername(string UKEY)
        {
            string sql_sel = "Select USERNAME From USERACC Where UKEY = " + UKEY;
            return Process.getString(sql_sel);
        }

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

        public bool checkUkeyExist(string UKEY)
        {
            string sql_select = "Select UKEY From USERACC Where UKEY = " + UKEY;
            bool ck = false;
            if (Process.ExecutiveReader(sql_select) > 0)
            {
                ck = true;
            }
            return ck;
        }

        public bool SignUpAccount(string HOTEN, string SDT, string USERNAME, string USERPASS, int UKEY)
        {
            string pass = Process.Encrypt(USERPASS);
            string sql_update = "UPDATE USERACC " +
                "SET USERNAME = '"+ USERNAME +"', USERPASS = '"+ pass + "', " +
                "HOTEN = N'"+ HOTEN + "', SDT = " + SDT + ", GIOITINH = N'Khác', " +
                "EMAIL = '', BIRTHDAY = '"+ DateTime.Now.ToString("yyyy/MM/dd") +"' WHERE UKEY = " + UKEY;
            bool ck = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                ck = true;
            }
            return ck;
        }
    }
}
