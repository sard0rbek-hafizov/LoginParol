using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginParol
{
    public class Users
    {
        public string Id {  get; set; }
        public string FIO {  get; set; }
        public string Login {  get; set; }
        public string Parol {  get; set; }
        public string UserType {  get; set; }
        public void User()
        {
            string userFileText = @"D:\pdp\lesson1\LoginParol\LoginParol\user.txt";
            File.Create(userFileText);
        }
    }
}
