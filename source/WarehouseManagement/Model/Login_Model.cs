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

        public int GetUkey(string Username)
        {
            string sql_select = "Select UKEY from USERACC where USERNAME = '" + Username + "'";
            int re = Process.getNumber(sql_select);
            return re;
        }

        public int getPosition(string UKEY)
        {
            string sql_select = "Select POSITION From USERACC Where UKEY = " + UKEY;
            string pos = Process.getString(sql_select);

            if (pos == "Nhân viên")
                return 2;
            else if (pos == "Quản lý")
                return 1;
            else
                return 0;

        }

        public int getStatus(string UKEY)
        {
            string sql_select = "Select STATUSACC From USERACC Where UKEY = " + UKEY;
            string status = Process.getString(sql_select);

            if (status == "Bình thường")
                return 1;
            else if (status == "Chặn")
                return 0;
            else
                return -1;
        }

        public bool checkUser(string username, string password)
        {
            string pass = Process.Encrypt(password);
            string sql_sel = "Select USERNAME From USERACC Where USERNAME = '" + username + "' and USERPASS = '" + pass + "'";
            bool ck = false;
            if (Process.ExecutiveReader(sql_sel) > 0)
            {
                ck = true;
            }
            return ck;
        }
    }
}
