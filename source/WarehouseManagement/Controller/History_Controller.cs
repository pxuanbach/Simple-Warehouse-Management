﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class History_Controller
    {
        History_Model model = new History_Model();

        public DataTable Load_On_NhanVien(int Ukey, string dd, string MM, string yyyy, int Type)   //Đầu vào cần 1 mã Ukey 
        {
            return model.Load_On_NhanVien(Ukey, dd, MM, yyyy, Type);
        }

        public DataTable Load_On_QuanLy(string dd, string MM, string yyyy, int Type)
        {
            return model.Load_On_QuanLy(dd, MM, yyyy, Type);
        }

        public List<CTHD> GetCTHDs(int MAHD)
        {
            return model.GetCTHDs(MAHD);
        }
    }
}
