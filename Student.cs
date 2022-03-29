using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }

        public static bool CheckGroupNo(string str)
        {
            if(!string.IsNullOrWhiteSpace(str)&&str.Length==4)
            {
                if(char.IsUpper(str[0])&&char.IsDigit(str[1])&&char.IsDigit(str[2])&&char.IsDigit(str[3]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckFullName(string str)
        {
            if(!string.IsNullOrWhiteSpace(str))
            {
                var word = str.Split(' ');

                if(word.Length==2 && char.IsUpper(word[0][0]) && char.IsUpper(word[1][0]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
