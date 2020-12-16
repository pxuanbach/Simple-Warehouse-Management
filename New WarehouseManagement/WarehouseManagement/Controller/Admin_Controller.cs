using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Model;
using System.Data;
namespace WarehouseManagement.Controller
{
    class Admin_Controller
    {
        Admin_Model admin = new Admin_Model();
        public DataTable load_on (int ukey)
        {
            return admin.Load_On(ukey);
        }
        public bool them_UKEY ( int ukey)
        {
            return admin.Them_UKEY(ukey);
        }
        public bool xoa_useracc ( int ukey)
        {
            return admin.Xoa_USERACC(ukey);
        }
        public bool sua_useracc(string ukey, string value, string OLD_ukey)
        {
            return admin.Sua_USERACC(ukey, value, OLD_ukey);
        }
        public DataTable load_ukey ( int ukey)
        {
            return admin.Load_UKEY(ukey);
        }
        public DataTable load_username ( string username)
        {
            return admin.Load_USERNAME(username);
        }

        public bool Check_UKEY(int UKEY)
        {
            return admin.Check_UKEY(UKEY);
        }
    }
}
