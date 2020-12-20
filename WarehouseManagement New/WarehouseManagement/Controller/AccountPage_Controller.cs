using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class AccountPage_Controller
    {
        AccountPage_Model UAcc = new AccountPage_Model();
        public string[] GetDataAcc(string username)
        {
            return UAcc.getDataUserAcc(username);
        }
        public DateTime BIRTHDAY (string username)
        {
            return UAcc.birthday(username);
        }
    }
}
