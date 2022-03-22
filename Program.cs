using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                FullName = "Allahverdi",
                Email = "allahverdi123@email.ru",
                Password = "1Askjh"

            };
            Console.WriteLine(user.ShowInfo());
        }
    }
}
