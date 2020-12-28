using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class HoaDon
    {
        List<CTHD> listCTHD;
        int maHD;
        string tenDoiTac;
        string lienHe;
        DateTime thoiGian;
        string giaTri;
        int maNguoiThem;
        string tenNguoiThem;

        public HoaDon()
        {

        }

        public HoaDon(HoaDon a)
        {
            this.listCTHD = a.ListCTHD;
            maHD = a.MaHD;
            tenDoiTac = a.TenDoiTac;
            lienHe = a.LienHe;
            thoiGian = a.ThoiGian;
            giaTri = a.GiaTri;
            maNguoiThem = a.MaNguoiThem;
            tenNguoiThem = a.TenNguoiThem;
        }

        public int MaHD { get => maHD; set => maHD = value; }
        public string TenDoiTac { get => tenDoiTac; set => tenDoiTac = value; }
        public string LienHe { get => lienHe; set => lienHe = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string GiaTri { get => giaTri; set => giaTri = value; }
        public int MaNguoiThem { get => maNguoiThem; set => maNguoiThem = value; }
        public string TenNguoiThem { get => tenNguoiThem; set => tenNguoiThem = value; }
        public List<CTHD> ListCTHD { get => listCTHD; set => listCTHD = value; }
    }
}
