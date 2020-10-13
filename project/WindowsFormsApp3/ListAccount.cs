using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ListAccount
    {
        private List<Account> listAccount = new List<Account>();
        private string path = @"./Check_User.txt";
        public ListAccount()
        {
            //doc data tu file
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] info = lines[i].Split('|');
                listAccount.Add(new Account() { user = info[0], Pass = info[1] });
            }
        }
        public bool Check_user(string User)
        {
            bool check = true;
            check = listAccount.Exists(x => x.user == User);
            return check;
        }
        public bool Check_Pass(string pass)
        {
            bool check = true;
            check = listAccount.Exists(x => x.Pass == pass);
            return check;
        }
        public bool addAccount(string User, string Password)
        {

            if (Check_user(User) == false)
            {
                using (StreamWriter writer = new StreamWriter(path, true))

                {
                    writer.WriteLine(User + '|' + Password);
                }
                return true;
            }
            else
                return false;
        }
        public Account GetAccount(string User)
        {
            //goi mot ham find tra ve 1 account
            //tim account
            return listAccount.Find(x => x.user == User);
        }
    }
}
