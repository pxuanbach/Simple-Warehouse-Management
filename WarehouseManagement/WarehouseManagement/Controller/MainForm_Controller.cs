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
        MainForm_Model stock = new MainForm_Model();
        public DataTable Load_On(string UserName )
        {
            return stock.Load_On(UserName);
        }
    }
}
