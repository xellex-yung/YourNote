using System;
using YourNote.BL;

namespace YourNote.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = @"xellex_yung";
            string password = ")TcaL40(y&q2Xn)";
            string Name = "xellex x";
            char lastChar = Convert.ToChar(login.Substring(login.Length - 1, 1));
            //Console.WriteLine(lastChar);
            Console.WriteLine(Validation.IsNameValid(Name));
            Console.ReadKey();
        }
    }
}
