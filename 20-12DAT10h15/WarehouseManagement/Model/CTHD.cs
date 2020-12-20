using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class CTHD
    {
        string MA_HANG;
        string TEN_HANG;
        string NG_NHAP;
        int DON_GIA;
        int SL;

        public string MAHANG { get => MA_HANG; set => MA_HANG = value; }
        public string TENHANG { get => TEN_HANG; set => TEN_HANG = value; }
        public int DONGIA { get => DON_GIA; set => DON_GIA = value; }
        public int SOLUONG { get => SL; set => SL = value; }
        public string NGNHAP { get => NG_NHAP; set => NG_NHAP = value; }
    }
}
