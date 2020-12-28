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
        AccountPage_Model model = new AccountPage_Model();

        public Account getInformation(int UKEY)
        {
            return model.getInformation(UKEY);
        }

        public bool changeUserPass(string oldpass, string newpass, string account)
        {
            return model.changeUserPass(oldpass, newpass, account);
        }

        public bool saveInfomation(Account acc, int UKEY)
        {
            return model.saveInfomation(acc, UKEY);
        }
    }
}
