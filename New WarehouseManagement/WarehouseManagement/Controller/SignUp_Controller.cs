using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class SignUp_Controller
    {
        SignUp_Model model = new SignUp_Model();
        public bool CheckUserExist(string USERNAME)
        {
            return model.CheckUserExist(USERNAME);
        }
        public bool CheckRePassword(string pass, string re_pass)
        {
            return model.CheckRePassword(pass, re_pass);
        }

        public bool checkUkeyExist(string UKEY)
        {
            return model.checkUkeyExist(UKEY);
        }

        public bool SignUpAccount(string HOTEN, string SDT, string USERNAME, string USERPASS, int UKEY)
        {
            return model.SignUpAccount(HOTEN, SDT, USERNAME, USERPASS, UKEY);
        }

        public bool CheckVietKey(string chucodau)
        {
            return Process.CheckVietKey(chucodau);
        }
    }
}
