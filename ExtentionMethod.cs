using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    static internal class ExtentionMethod
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 0)
                return false;
            return true;
        }

        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                    return true;
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            str = str.ToLower();
            if (string.IsNullOrWhiteSpace(str))
                return str;

            string newStr = char.ToUpper(str[0]) + str.Substring(1);
            return newStr;
        }

        

        public static int[] GetValueIndexes(this string str,char a)
        {
            int[] indexs = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == a)
                {
                    Array.Resize(ref indexs, indexs.Length + 1);
                    indexs[indexs.Length - 1] = i;
                }
            }
            return indexs;
        }







    }
}










