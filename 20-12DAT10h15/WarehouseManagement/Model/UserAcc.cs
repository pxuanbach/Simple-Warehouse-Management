using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class UserAcc
    {
        private string TENCOT;
        private string value;
        private string OLD_UKEY;

        public string TENCOT1 { get => TENCOT; set => TENCOT = value; }
        
        public string OLD_UKEY1 { get => OLD_UKEY; set => OLD_UKEY = value; }
        public string Value { get => value; set => this.value = value; }
    }
}
