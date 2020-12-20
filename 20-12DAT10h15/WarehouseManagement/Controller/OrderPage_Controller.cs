using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class OrderPage_Controller
    {
        OrderPage_Model model = new OrderPage_Model();

        //Function gọi Load_On từ Model để load data từ SQL Server lên datagridview của StockPage
        public DataTable Load_On(int UKey)   //Đầu vào cần 1 ukey
        {
            return model.Load_On(UKey);
        }

        public DataTable Load_On_CTHD(int UKey, int MAHD)   //Đầu vào cần 1 ukey
        {
            return model.Load_On_CTHD(UKey, MAHD);
        }

        public bool Check_HangHoa(string MAHANG, string TENHANG, int DONGIA, int UKEY)
        {
            return model.Check_HangHoa(MAHANG, TENHANG, DONGIA, UKEY);
        }

        public string splitPoint(string str)
        {
            return Process.splitPoint(str);
        }

        public bool Check_SoLuong_HangHoa(List<CTHD> a, string MAHANG, int UKEY, int So_Luong)
        {
            return model.Check_SoLuong_HangHoa(a, MAHANG, UKEY, So_Luong);
        }

        public bool Update_SoLuong_HangHoa(string MAHANG, int UKEY, int SOLUONG, char CHAR)
        {
            return model.Update_SoLuong_HangHoa(MAHANG, UKEY, SOLUONG, CHAR);
        }

        public DataTable Load_Search(string Item, string Value, int UKey, int Position)   //Đầu vào cần 1 chuỗi tương ứng mã hàng hóa
        {
            if (Item == "Mã Hàng")
                return model.Load_MA(Value, UKey, Position);
            else if (Item == "Tên Hàng")
                return model.Load_TENHANG(Value, UKey, Position);
            else if (Item == "Ngày Nhập")
                return model.Load_NGNHAP(Value, UKey, Position);
            else
            {
                return null;
            }
        }

        public bool Add_Order(string TENDOITAC, DateTime THOIGIAN, int UKEY)
        {
            return model.Add_Order(TENDOITAC, THOIGIAN, UKEY);
        }

        public bool Update_Order(int MAHD, string TRIGIA)
        {
            return model.Update_Order(MAHD, TRIGIA);
        }

        public int Get_MAHOADON()
        {
            return model.Get_MAHOADON();
        }

        public List<CTHD> GetCTHDs(int MAHD, int UKEY)
        {
            return model.GetCTHDs(MAHD, UKEY);
        }

        public bool Add_CTHD(int MAHD, string MAHANG, int SOLUONG, int UKEY)
        {
            return model.Add_CTHD(MAHD, MAHANG, SOLUONG, UKEY);
        }

        //true tức là hàng hóa đã có trong list<CTHD> và đã được + số lượng vào
        public bool Sum_SOLUONG(List<CTHD> a, string MAHANG, int SOLUONG)
        {
            return model.Sum_SOLUONG(a, MAHANG, SOLUONG);
        }

        public int Sum_DONGIA(List<CTHD> a)
        {
            return model.Sum_DONGIA(a);
        }

        public void Delete_CTHD(int MAHD, int UKEY)
        {
            model.Delete_CTHD(MAHD, UKEY);
        }
    }
}
