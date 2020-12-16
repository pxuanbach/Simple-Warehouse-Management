using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class History_Controller
    {
        History_Model model = new History_Model();

        public DataTable Load_On_User(int Ukey, string dd, string MM, string yyyy, int Type)   //Đầu vào cần 1 mã Ukey 
        {
            return model.Load_On_User(Ukey, dd, MM, yyyy, Type);
        }

        public DataTable Load_On_Admin(string dd, string MM, string yyyy, int Type)
        {
            return model.Load_On_Admin(dd, MM, yyyy, Type);
        }

        public List<CTHD> GetCTHDs(int MAHD, int UKEY)
        {
            return model.GetCTHDs(MAHD, UKEY);
        }
    }
}
