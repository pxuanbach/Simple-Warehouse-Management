using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WarehouseManagement.Model
{
    class Admin_Model
    {
        //Function có chức năng load data từ SQL Server
        public DataTable Load_On(int Position)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select UKEY, HOTEN, POSITION ,STATUSACC from USERACC ";
            if (Position == 1)
            {
                sql_select = sql_select + "where POSITION = N'Nhân viên'";
            }    

            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTableSelect UKEY, USERNAME from USERACC
        }

        public int getNewKey(string Position)
        {
            string sql = "insert USERACC(POSITION,STATUSACC) output inserted.UKEY " +
                "values (N'" + Position + "',N'Bình thường')";
            int newKEY = Process.getNewKEY(sql);
            return newKEY;
        }

        //Function có chức năng sửa 1 useracc trong database
        public bool Sua_USERACC(string TENCOT, string value, string OLD_UKEY)
        {
            string sql_update;
            if (TENCOT != "POSITION") // Khác POSITION  chỉ có thể là STATUSACC
            {
                sql_update = "UPDATE USERACC SET " + TENCOT + " = " + value
                            + " WHERE UKEY = " + OLD_UKEY + "";

            }
            else // nếu TENCOT là POSITION 
            {
                sql_update = "UPDATE USERACC SET " + TENCOT + " = N'" + value
                            + "' WHERE UKEY =  " + OLD_UKEY + "";
            }

            bool re = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool set_Status_Position(string UKEY, string Sta, string Pos)
        {
            string sql_update = "UPDATE USERACC SET ";
            if (Sta != "Không thay đổi")
            {
                sql_update = sql_update + "STATUSACC  = N'" + Sta + "'";
                if (Pos != "Không thay đổi")
                    sql_update = sql_update + ", ";
            }    
            if (Pos != "Không thay đổi")
                sql_update = sql_update + "POSITION = N'" + Pos + "' ";

            sql_update = sql_update + " WHERE UKEY = " + UKEY;
            bool ck = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                ck = true;
            }
            return ck;
        }

        public List<int> getCountPosition()
        {
            List<int> count = new List<int>(3);
            string sql_select = "Select count(UKEY) From USERACC Where POSITION = N'Nhân viên'";
            count.Add(Process.getNumber(sql_select));
            sql_select = "Select count(UKEY) From USERACC Where POSITION = N'Quản lý'";
            count.Add(Process.getNumber(sql_select));
            sql_select = "Select count(UKEY) From USERACC Where POSITION = N'Quản trị viên'";
            count.Add(Process.getNumber(sql_select));
            return count;
        }

        public DataTable Load_MA(string UKEY, int Position)   //Đầu vào cần 1 mã Ukey và tên mã hàng
        {
            DataTable re;
            string sql_select = "Select UKEY, HOTEN, POSITION ,STATUSACC from USERACC where CHARINDEX('" + UKEY + "', UKEY) != 0 ";
            if (Position == 1)
            {
                sql_select = sql_select + " and POSITION = N'Nhân viên'";
            }
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_HOTEN(string HOTEN, int Position)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select UKEY, HOTEN, POSITION ,STATUSACC from USERACC where CHARINDEX(N'" + HOTEN + "', HOTEN) != 0 ";
            if (Position == 1)
            {
                sql_select = sql_select + " and POSITION = N'Nhân viên'";
            }    
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
    }
}
