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

        public Account getInformation(string username)
        {
            return UAcc.getInformation(username);
        }

        public bool changeUserPass(string oldpass, string newpass, string account)
        {
            return UAcc.changeUserPass(oldpass, newpass, account);
        }
    }
}
