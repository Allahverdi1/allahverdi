using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal interface IAccount
    {
        public string PasswordChecker();
        public string FullName { get; set; }
        public string Email { get; set; }
        public void ShowInfo()

        {
            Console.WriteLine($"{FullName}-{Email}");
        }
    }
}
