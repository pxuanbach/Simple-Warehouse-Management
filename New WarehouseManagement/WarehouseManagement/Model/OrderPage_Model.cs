using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WarehouseManagement.Model
{
    class OrderPage_Model
    {
        //Function có chức năng load data từ SQL Server
        public DataTable Load_On(int Ukey)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DONGIA,NGNHAP, SOLUONG from HANGHOA where SOLUONG <> 0 and UKEY = " + Ukey;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        public DataTable Load_On_CTHD(int Ukey, int MAHD)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select HANGHOA.TENHANG, DONGIA, CTHD.MAHANG, CTHD.SOLUONG From HANGHOA " +
                "inner join CTHD on CTHD.MAHANG = HANGHOA.MAHANG " +
                "Where HANGHOA.UKEY = CTHD.UKEY and CTHD.MAHOADON = "+ MAHD + " and CTHD.UKEY = " + Ukey;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        //Function có chức năng kiểm tra xem thông tin hàng hóa đúng với trong database hay không
        public bool Check_HangHoa(string MAHANG, string TENHANG, int DONGIA, int UKEY)
        {
            string sql_select = "Select * From HANGHOA Where UKEY = " + UKEY +
                " and MAHANG = '" + MAHANG + "' and TENHANG = N'" + TENHANG + "' " +
                "and DONGIA = " + DONGIA;
            bool re = false;
            if (Process.ExecutiveReader(sql_select) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Check_SoLuong_HangHoa(List<CTHD> a ,string MAHANG, int UKEY, int So_Luong)
        {
            string sql_select = "Select SOLUONG From HANGHOA Where UKEY = " + UKEY + "and MAHANG = '" + MAHANG + "'";
            bool re = false;
            int n = Process.GetNumber(sql_select);
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].MAHANG == MAHANG)
                {
                    So_Luong += a[i].SOLUONG;
                }
            }
            if (n >= So_Luong)   //Nếu số lượng hàng có sẵn lớn hơn hoặc bằng số lượng hàng yêu cầu thì hàm trả về true
                re = true;
            return re;
        }

        public bool Update_SoLuong_HangHoa(string MAHANG, int UKEY, int SOLUONG, char CHAR)
        {
            string sql_update = "UPDATE HANGHOA SET SOLUONG = SOLUONG " + CHAR + " " + SOLUONG + 
                " WHERE MAHANG = '" + MAHANG + "' AND UKEY = " + UKEY;
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }

        //Function có chức năng thêm 1 hóa đơn vào database
        public bool Add_Order(string TENDOITAC, DateTime THOIGIAN, int UKEY)
        {
            string sql_insert = "insert HOADON(TENDOITAC, THOIGIAN, UKEY) values (N'" + TENDOITAC + "', '" + THOIGIAN + "', " + UKEY + ")";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Update_Order(int MAHD, string TRIGIA)
        {
            string sql_update = "update HOADON set TRIGIA = " + TRIGIA + " where MAHOADON = " + MAHD;
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }

        public int Get_MAHOADON()
        {
            string sql_select = "SELECT max(MAHOADON) From HOADON";
            int n = Process.GetNumber(sql_select);
            return n;
        }

        public List<CTHD> GetCTHDs(int MAHD, int UKEY)
        {
            string sql_select = "Select CTHD.MAHANG, CTHD.SOLUONG, HANGHOA.DONGIA From CTHD inner join HANGHOA " +
                "on CTHD.MAHANG = HANGHOA.MAHANG " +
                "Where CTHD.MAHOADON = " + MAHD + " and CTHD.UKEY = " + UKEY;

            return Process.GetCTHDs(sql_select);
        }

        public bool Add_CTHD(int MAHD, string MAHANG, int SOLUONG, int UKEY)
        {
            string sql_insert = "insert CTHD values (" + MAHD + ", '" + MAHANG + "', " + SOLUONG + ", " + UKEY + ")";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }

        public DataTable Load_MA(string MAHANG, int UKEY, int Position)   //Đầu vào cần 1 mã Ukey và tên mã hàng
        {
            DataTable re;
            string sql_select = $"Select MAHANG,TENHANG,SOLUONG,DONGIA,NGNHAP from HANGHOA where CHARINDEX('{MAHANG}', MAHANG) != 0 ";
            if (Position != 0)
                sql_select = sql_select + "AND UKEY = " + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_TENHANG(string TENHANG, int UKEY, int Position)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,SOLUONG,DONGIA,NGNHAP from HANGHOA where CHARINDEX(N'" + TENHANG + "', TENHANG) != 0 ";
            if (Position != 0)
                sql_select = sql_select + "AND UKEY = " + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_NGAYNHAP(string NGNHAP, int UKEY, int Position)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,SOLUONG,DONGIA,NGNHAP from HANGHOA " +
                "where CHARINDEX('" + NGNHAP + "', NGNHAP) != 0 ";
            if (Position != 0)
                sql_select = sql_select + "AND UKEY = " + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }


        public bool Check_SOLUONG(List<CTHD> a, string MAHANG, int SOLUONG)
        {
            bool ck = false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].MAHANG == MAHANG)
                {
                    a[i].SOLUONG += SOLUONG;
                    ck = true;
                }    
            }    
            return ck;
        }

        public int Sum_DONGIA(List<CTHD> a)
        {
            int sum = 0;
            for (int i = 0; i < a.Count; i++)
            {
                sum = sum + a[i].DONGIA * a[i].SOLUONG;
            }
            return sum;
        }

        public void Delete_CTHD(int MAHD, int UKEY)
        {
            string sql_delete = "Delete From CTHD Where MAHOADON = " + MAHD + " and UKEY = " + UKEY;
            Process.ExecutiveNonQuery(sql_delete);
        }
    }
}
