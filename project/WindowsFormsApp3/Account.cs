using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Account
    {
        private string User;
        private string EncodePassword;
        public string user
        {
            get
            {
                return this.User;
            }
            set
            {
                this.User = value;
            }
        }
        public string Pass
        {
            get
            {
                return this.EncodePassword;
            }
            set
            {
                this.EncodePassword = value;
            }
        }
        public static string Encode(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
    }
}
