using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WarehouseManagement.Model;

namespace WarehouseManagement.Controller
{
    class OrderPage_Controller
    {
        OrderPage_Model model = new OrderPage_Model();

        //Function gọi Load_On từ Model để load data từ SQL Server lên datagridview của StockPage
        public DataTable Load_On(int UKey)   //Đầu vào cần 1 chuỗi tương ứng username
        {
            return model.Load_On(UKey);
        }
    }
}
