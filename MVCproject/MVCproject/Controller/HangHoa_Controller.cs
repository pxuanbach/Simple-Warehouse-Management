using MVCproject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCproject.Controller
{
    class HangHoa_Controller
    {
        HangHoa_Model hangHoa = new HangHoa_Model();
        public bool Them_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            return hangHoa.Them_HangHoa(MAHANG, TENHANG, DVT, SOLUONG, DONGIA, NGNHAP, NGSANXUAT, HSD, UKEY);
        }
    }
}
