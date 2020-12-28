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
        public DataTable Load_On(int Ukey, int Position)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,SOLUONG,DONGIA," +
                "CONVERT(varchar,NGNHAP, 103) as NGNHAP" +
                " from HANGHOA ";

            sql_select = sql_select + "where SOLUONG > 0";
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        //Function có chức năng kiểm tra xem thông tin hàng hóa đúng với trong database hay không
        public bool Check_HangHoa(string MAHANG, string TENHANG, int DONGIA, int UKEY, int POSITION)
        {
            string sql_select = "Select * From HANGHOA Where " +
                "MAHANG = '" + MAHANG + "' and TENHANG = N'" + TENHANG + "' " +
                "and DONGIA = " + DONGIA;

            bool re = false;
            if (Process.ExecutiveReader(sql_select) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Check_SoLuong_HangHoa(List<CTHD> a ,string MAHANG, int UKEY, int So_Luong, int Position)
        {
            string sql_select = "Select SOLUONG From HANGHOA Where MAHANG = " + MAHANG;   

            bool re = false;
            int n = Process.getNumber(sql_select);
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

        public bool Update_SoLuong_HangHoa(string MAHANG, int SOLUONG, char CHAR)
        {
            string sql_update = "UPDATE HANGHOA SET SOLUONG = SOLUONG " + CHAR + " " + SOLUONG + 
                " WHERE MAHANG = " + MAHANG;

            bool re = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }

        //Function có chức năng thêm 1 hóa đơn vào database
        public int Add_Order(string TENDOITAC, string LIENHE, DateTime THOIGIAN, int UKEY)
        {
            string sql_insert = "insert HOADON(TENDOITAC, LIENHE, THOIGIAN, TRIGIA, UKEY) output inserted.MAHOADON " +
                "values (N'" + TENDOITAC + "', N'" + LIENHE + "', '" + THOIGIAN + "', 0," + UKEY + ")";
            int newKEY = Process.getNewKEY(sql_insert);
            return newKEY;
        }

        public bool Update_Order(int MAHD, string value, string tenThuocTinh)
        {
            string sql_update = "update HOADON set " + tenThuocTinh + " = " + value + " where MAHOADON = " + MAHD;
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }

        public int get_MAHOADON()
        {
            string sql_select = "SELECT max(MAHOADON) From HOADON";
            int n = Process.getNumber(sql_select);
            return n;
        }

        public List<CTHD> GetCTHDs(int MAHD)
        {
            string sql_select = "Select CTHD.MAHANG, CTHD.SOLUONG, HANGHOA.DONGIA, TENHANG From CTHD inner join HANGHOA " +
                "on CTHD.MAHANG = HANGHOA.MAHANG " +
                "Where CTHD.MAHOADON = " + MAHD;

            return Process.GetCTHDs(sql_select);
        }

        public bool Add_CTHD(int MAHD, string MAHANG, int SOLUONG)
        {
            string sql_insert = "insert CTHD values (" + MAHD + ", '" + MAHANG + "', " + SOLUONG + ")";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }

        public DataTable Load_MA(string MAHANG, int UKEY)   //Đầu vào cần 1 mã Ukey và tên mã hàng
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,SOLUONG,DONGIA," +
                "CONVERT(varchar,NGNHAP, 103) as NGNHAP" +
                " from HANGHOA " +
                $"where CHARINDEX('{MAHANG}', MAHANG) != 0 ";
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_TENHANG(string TENHANG, int UKEY)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,SOLUONG,DONGIA," +
                "CONVERT(varchar,NGNHAP, 103) as NGNHAP" +
                " from HANGHOA " +
                "where CHARINDEX(N'" + TENHANG + "', TENHANG) != 0 ";
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_NGNHAP(string NGNHAP, int UKEY)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,SOLUONG,DONGIA," +
                "CONVERT(varchar,NGNHAP, 103) as NGNHAP " +
                "from HANGHOA " +
                "where (CHARINDEX('" + NGNHAP + "', DAY(NGNHAP)) != 0  or " +
                "CHARINDEX('" + NGNHAP + "', MONTH(NGNHAP)) != 0 " +
                "or CHARINDEX('" + NGNHAP + "', YEAR(NGNHAP)) != 0 or " +
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 1)) != 0 or " +    //03/31/19
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 2)) != 0 or " +    //19.03.31
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 3)) != 0 or " +    //31/12/19
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 4)) != 0 or " +    //31.03.19
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 5)) != 0 or " +    //31-03-19
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 10)) != 0 or " +   //03-31-19
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 11)) != 0 or " +   //19/03/31
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 12)) != 0 or " +   //190331
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 23)) != 0 or " +   //2019-03-31
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 101)) != 0 or " +  //03/31/2019
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 102)) != 0 or " +  //2019.03.31
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 103)) != 0 or " +  //31/03/2019
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 104)) != 0 or " +  //31.03.2019
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 105)) != 0 or " +  //31-03-2019
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 110)) != 0 or " +  //03-31-2019
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 111)) != 0 or " +  //2019/03/31
                "CHARINDEX('" + NGNHAP + "', CONVERT(varchar,NGNHAP, 112)) != 0) ";      //20190331
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        public bool Sum_SOLUONG(List<CTHD> a, string MAHANG, int SOLUONG)
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

        public void Delete_CTHD(int MAHD)
        {
            string sql_delete = "Delete From CTHD Where MAHOADON = " + MAHD;
            Process.ExecutiveNonQuery(sql_delete);
        }

        public string getName(int UKEY)
        {
            string sql_select = "Select HOTEN From USERACC Where UKEY = " + UKEY;
            string str = Process.getString(sql_select);
            return str;
        }

        public bool Delete_HoaDon(int MAHD)
        {
            string sql_delete = "Delete From HOADON Where MAHOADON = " + MAHD;
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_delete) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
