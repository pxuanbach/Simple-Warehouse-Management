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
        SignUp_Model signUp = new SignUp_Model();
        public bool CheckUserExist(string USERNAME)
        {
            return signUp.CheckUserExist(USERNAME);
        }
        public bool CheckRePassword(string pass, string re_pass)
        {
            return signUp.CheckRePassword(pass, re_pass);
        }
        public bool SignUpAccount(string HOTEN, string SDT, string USERNAME, string USERPASS, int UKEY)
        {
            return signUp.SignUpAccount(HOTEN, SDT, USERNAME, USERPASS, UKEY);
        }
    }
}
