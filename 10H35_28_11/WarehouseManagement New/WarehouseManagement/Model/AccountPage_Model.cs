﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarehouseManagement.Model
{
    class AccountPage_Model
    {
        public string[] getDataUserAcc(string username)
        {
        //    string sql_sel = "Select HOTEN,SDT,GIOITINH,EMAIL,POSITION From USERACC Where USERNAME = '" + username + "'";
            string[] dataUAcc = new string[10];
        //    dataUAcc = Process.ListData(sql_sel);
            return dataUAcc;
        }

        //public DateTime birthday(string username)
        //{
        //    string sql_sel = "Select BIRTHDAY From USERACC Where USERNAME = '" + username + "'";
        //    DateTime NgaySinh = new DateTime();
        //    NgaySinh = Process.date(username);
        //    return NgaySinh;
        //}
        public bool changeUserPass(string oldpass, string newpass, string account)
        {
            string sql_sel = "update USERACC set USERPASS = '" + newpass + "' where USERPASS = '" + oldpass + "' and USERNAME = '" + account + "'";
            bool ck = false;
            if (Process.ExecutiveReader(sql_sel) > 0)
            {
                ck = true;
            }
            return ck;
        }
    }
}
