using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class StatisticsPage_Controller
    {
        StatisticsPage_Model model = new StatisticsPage_Model();

        public DataTable Load_Data_Month(string thang, string nam)
        {
            return model.Load_Data_Month(thang, nam);
        }

        public DataTable Load_Data_Year(string THOIGIAN)
        {
            return model.Load_Data_Year(THOIGIAN);
        }

        public DataTable Load_Data()
        {
            return model.Load_Data();
        }
        public DataTable Load_Top_HANGHOA(string SLtop, string nam)
        {
            return model.Load_Top_HANGHOA(SLtop, nam);
        }

        public DataTable Load_Top_DOITAC(string top, string nam)
        {
            return model.Load_Top_DOITAC(top, nam);
        }
    }
}
