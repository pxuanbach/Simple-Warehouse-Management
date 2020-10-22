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
        MainForm_Model main = new MainForm_Model();
        public int GetUkey(string username)
        {
            return main.GetUkey(username);
        }

    }
}
