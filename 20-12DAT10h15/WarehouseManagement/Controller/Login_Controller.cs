using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class Login_Controller
    {
        Login_Model login = new Login_Model();
        public bool checkExistUsername(string username)
        {
            return login.checkUserExist(username);
        }
        public bool checkUser(string username, string password)
        {
            return login.checkUser(username, password);
        }
        public bool checkAdmin(string adname, string adpass)
        {
            return login.checkAdmin(adname, adpass);
        }
        public bool CheckVietKey(string chucodau)
        {
            return Process.CheckVietKey(chucodau);
        }
    }
}
