﻿using System;
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
        public DataTable Load_On(int UKey)   //Đầu vào cần 1 chuỗi tương ứng username
        {
            return model.Load_On(UKey);
        }

        //Function gọi Them_HangHoa từ Model để thêm data vào SQL Server
        public bool Them_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {   //Đầu vào cần thông tin của hàng hóa
            return model.Them_HangHoa(MAHANG, TENHANG, DVT, SOLUONG, DONGIA, NGNHAP, NGSANXUAT, HSD, UKEY);
        }

        //Function gọi Xoa_HangHoa từ Model để xóa 1 hàng trong SQL Server
        public bool Xoa_HangHoa(string MAHANG, int UKEY)
        {
            return model.Xoa_HangHoa(MAHANG, UKEY);
        }

        //Function gọi Sua_HangHoa từ Model để sửa 1 hàng trong SQL Server
        public bool Sua_HangHoa(string TENCOT, string value, string MAHANG)
        {
            //string nhap = NGNHAP.ToString("yyyy-MM-dd HH:mm:ss");
            //string xuat = NGSANXUAT.ToString("yyyy-MM-dd HH:mm:ss");
            //string hsd = HSD.ToString("yyyy-MM-dd HH:mm:ss");

            return model.Sua_HangHoa(TENCOT, value, MAHANG);
        }
        public DataTable Load_MA(string MAHANG, int UKey)   //Đầu vào cần 1 chuỗi tương ứng mã hàng hóa
        {
            return model.Load_MA(MAHANG, UKey);
        }
        public DataTable Load_TENHANG(string MAHANG, int UKey)   //Đầu vào cần 1 chuỗi tương ứng mã hàng hóa
        {
            return model.Load_TENHANG(MAHANG, UKey);
        }
        public DataTable Load_NGAYNHAP(string NGNHAP, int UKey)   //Đầu vào cần 1 chuỗi tương ứng mã hàng hóa
        {
            return model.Load_NGAYNHAP(NGNHAP, UKey);
        }

        public bool Check_HangHoa(string MAHANG, int UKEY)
        {
            return model.Check_HangHoa(MAHANG, UKEY);
        }

        public bool Update_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            return model.Update_HangHoa(MAHANG, TENHANG, DVT, SOLUONG, DONGIA, NGNHAP, NGSANXUAT, HSD, UKEY);
        }

    }
}
