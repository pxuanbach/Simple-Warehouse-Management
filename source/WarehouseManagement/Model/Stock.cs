using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class Stock
    {   //MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD 
        public string MAHANG;
        public string TENHANG;
        public string DVT;
        public string SOLUONG;
        public string DONGIA;
        public DateTime NGNHAP;
        public string NGSANXUAT;
        public string HSD;
        private int UKEY;

        public int UKEY1 { get => UKEY; set => UKEY = value; }
    }
}
