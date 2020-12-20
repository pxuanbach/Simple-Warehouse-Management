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
        public DataTable Load_On(int Ukey)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select UKEY, USERNAME, POSITION ,STATUSACC from USERACC where UKEY != " + Ukey;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTableSelect UKEY, USERNAME from USERACC
        }
        //Function có chức năng thêm 1 UKEY vào database
        public bool Them_Postion(string Position)
        {
            string sql_insert = "insert USERACC(POSITION,STATUSACC) values (N'" + Position + "',N'Bình thường')";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
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

        //Function có chức năng xóa 1 useracc trong database
        public bool Xoa_USERACC(int UKEY)
        {
            string sql_del = "delete from USERACC where UKEY = '" + UKEY + "';";
            bool re = false;
            if (Process.ExecutiveNonQuery(sql_del) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable Load_UKEY(int UKEY)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select UKEY, USERNAME, POSITION from USERACC where UKEY = " + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_USERNAME(string username)   //Đầu vào cần 1 Username
        {
            DataTable re;
            string sql_select = "Select UKEY, USERNAME, POSITION from USERACC where USERNAME =' " + username + "'";
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        public bool Check_UKEY(int UKEY)
        {
            string sql_sel = "Select UKEY From USERACC Where UKEY = " + UKEY;
            bool ck = false;
            if (Process.ExecutiveReader(sql_sel) > 0)
            {
                ck = true;
            }
            return ck;
        }
        public bool Fix_Status(string UKEY, string VALUE)
        {
            string sql_update = "UPDATE USERACC SET STATUSACC  = N'" + VALUE + "' WHERE UKEY =  " + UKEY + "";
            bool ck = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                ck = true;
            }
            return ck;
        }

    }
}
