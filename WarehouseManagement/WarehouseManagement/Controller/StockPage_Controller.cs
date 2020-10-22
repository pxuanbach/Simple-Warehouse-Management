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
        StockPage_Model stock = new StockPage_Model();
        public DataTable Load_On(string UserName)
        {
            return stock.Load_On(UserName);
        }
        public bool Them_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            return stock.Them_HangHoa(MAHANG, TENHANG, DVT, SOLUONG, DONGIA, NGNHAP, NGSANXUAT, HSD, UKEY);
        }
        public bool Sua_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            return stock.Sua_HangHoa(MAHANG, TENHANG, DVT, SOLUONG, DONGIA, NGNHAP, NGSANXUAT, HSD, UKEY);
        }
        public bool Xoa_HangHoa(string MAHANG)
        {
            return stock.Xoa_HangHoa(MAHANG);
        }
    }
}
