using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagement.Model;
using System.Data;

namespace WarehouseManagement.Controller
{
    class MainForm_Controller
    {
        //tạo 1 đối tượng Model
        MainForm_Model stock = new MainForm_Model();

        //Function gọi GetUkey từ Model để lấy giá trị UKEY từ SQL Server
        public int GetUkey(string Username)
        {
            return stock.GetUkey(Username);
        }
    }
}
