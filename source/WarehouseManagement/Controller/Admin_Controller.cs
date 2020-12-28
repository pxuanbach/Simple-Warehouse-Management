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
        Admin_Model model = new Admin_Model();
        AccountPage_Model model02 = new AccountPage_Model();
        public Account getInformation(string username, int UKEY)
        {
            return model02.getInformation(UKEY);
        }

        public DataTable load_on(int Position)
        {
            return model.Load_On(Position);
        }

        public int getNewKey(string Position)
        {
            return model.getNewKey(Position);
        }

        public bool set_Status_Position(string UKEY, string Sta, string Pos)
        {
            return model.set_Status_Position(UKEY, Sta, Pos);
        }

        public List<int> getCountPosition()
        {
            return model.getCountPosition();
        }

        public DataTable Load_Search(string Item, string Value, int Position)   //Đầu vào cần 1 chuỗi tương ứng mã hàng hóa
        {
            if (Item == "Mã Bản Quyền")
                return model.Load_MA(Value, Position);
            else if (Item == "Họ Tên")
                return model.Load_HOTEN(Value, Position);
            else
            {
                return null;
            }
        }

    }
}
