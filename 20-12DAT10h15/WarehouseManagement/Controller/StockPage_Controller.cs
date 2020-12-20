using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Model;
using System.Data;

namespace WarehouseManagement.Controller
{
    class StockPage_Controller
    {
        //Tạo 1 đối tượng StockPage_Model
        StockPage_Model model = new StockPage_Model();

        //Function gọi Load_On từ Model để load data từ SQL Server lên datagridview của StockPage
        public DataTable Load_On(int UKey, int n, int Position)   //Đầu vào cần 1 chuỗi tương ứng username
        {
            if (n == 0)
                return model.Load_On_01(UKey, Position);
            else if (n == 1)
                return model.Load_On_02(UKey, Position);
            else
                return null;
        }

        //Function gọi Them_HangHoa từ Model để thêm data vào SQL Server
        public bool Them_HangHoa(string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, string NGSANXUAT, string HSD, int UKEY)
        {   //Đầu vào cần thông tin của hàng hóa
            return model.Them_HangHoa(TENHANG, DVT, SOLUONG, DONGIA, NGNHAP, NGSANXUAT, HSD, UKEY);
        }

        //Function gọi Xoa_HangHoa từ Model để xóa 1 hàng trong SQL Server
        public bool Xoa_HangHoa(string MAHANG, int UKEY)
        {
            return model.Xoa_HangHoa(MAHANG, UKEY);
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

        public bool Check_HangHoa_In_CTHD(string MAHANG, int UKEY)
        {
            return model.Check_HangHoa_In_CTHD(MAHANG, UKEY);
        }

        public bool Update_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, string NGSANXUAT, string HSD, int UKEY)
        {
            return model.Update_HangHoa(MAHANG, TENHANG, DVT, SOLUONG, DONGIA, NGSANXUAT, HSD, UKEY);
        }

    }
}
