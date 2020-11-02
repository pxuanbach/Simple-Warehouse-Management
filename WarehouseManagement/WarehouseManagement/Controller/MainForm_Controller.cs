using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Model;
using System.Data;

namespace WarehouseManagement.Controller
{
    class MainForm_Controller
    {
<<<<<<< HEAD
        MainForm_Model main = new MainForm_Model();
        public int GetUkey(string username)
        {
            return main.GetUkey(username);
        }

=======
        MainForm_Model stock = new MainForm_Model();
        public DataTable Load_On(string UserName )
        {
            return stock.Load_On(UserName);
        }
>>>>>>> 61490cb407cfa930126de606ff9f6f69b19bc86e
    }
}
