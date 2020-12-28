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
        Login_Model model = new Login_Model();
        public bool checkExistUsername(string username)
        {
            return model.checkUserExist(username);
        }
        public bool checkUser(string username, string password)
        {
            return model.checkUser(username, password);
        }
        public bool CheckVietKey(string chucodau)
        {
            return Process.CheckVietKey(chucodau);
        }

        public int getPosition(string UKEY)
        {
            return model.getPosition(UKEY);
        }

        public int getStatus(string UKEY)
        {
            return model.getStatus(UKEY);
        }

        public int GetUkey(string Username)
        {
            return model.GetUkey(Username);
        }
    }
}
