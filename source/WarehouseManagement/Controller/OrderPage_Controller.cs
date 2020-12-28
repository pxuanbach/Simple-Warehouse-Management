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
        public DataTable Load_On(int UKey, int Position)   //Đầu vào cần 1 ukey
        {
            return model.Load_On(UKey, Position);
        }

        public bool Check_HangHoa(string MAHANG, string TENHANG, int DONGIA, int UKEY, int POSITION)
        {
            return model.Check_HangHoa(MAHANG, TENHANG, DONGIA, UKEY, POSITION);
        }

        public string splitPoint(string str)
        {
            return Process.splitPoint(str);
        }

        public bool Check_SoLuong_HangHoa(List<CTHD> a, string MAHANG, int UKEY, int So_Luong, int Position)
        {
            return model.Check_SoLuong_HangHoa(a, MAHANG, UKEY, So_Luong, Position);
        }

        public bool Update_SoLuong_HangHoa(string MAHANG, int SOLUONG, char CHAR)
        {
            return model.Update_SoLuong_HangHoa(MAHANG, SOLUONG, CHAR);
        }

        public DataTable Load_Search(string Item, string Value, int UKey)   //Đầu vào cần 1 chuỗi tương ứng mã hàng hóa
        {
            if (Item == "Mã Hàng")
                return model.Load_MA(Value, UKey);
            else if (Item == "Tên Hàng")
                return model.Load_TENHANG(Value, UKey);
            else if (Item == "Ngày Nhập")
                return model.Load_NGNHAP(Value, UKey);
            else
            {
                return null;
            }
        }

        public int Add_Order(string TENDOITAC, string LIENHE, DateTime THOIGIAN, int UKEY)
        {
            return model.Add_Order(TENDOITAC, LIENHE, THOIGIAN, UKEY);
        }

        public bool Update_Order(int MAHD, string value, string thuocTinh)
        {
            return model.Update_Order(MAHD, value, thuocTinh);
        }

        public int Get_MAHOADON()
        {
            return model.get_MAHOADON();
        }

        public List<CTHD> GetCTHDs(int MAHD)
        {
            return model.GetCTHDs(MAHD);
        }

        public bool Add_CTHD(int MAHD, string MAHANG, int SOLUONG)
        {
            return model.Add_CTHD(MAHD, MAHANG, SOLUONG);
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

        public void Delete_CTHD(int MAHD)
        {
            model.Delete_CTHD(MAHD);
        }

        public string getName(int UKEY)
        {
            return model.getName(UKEY);
        }

        public bool Delete_HoaDon(int MAHD)
        {
            return model.Delete_HoaDon(MAHD);
        }
    }
}
