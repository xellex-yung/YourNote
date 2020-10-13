using System;
using System.Text.RegularExpressions;

namespace YourNote.BL
{
    static class RegexPattern
    {
        public const string Login = @"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$";
        public const string Password = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{1,16}$";
        public const string Name = @"^[а-яА-ЯёЁa-zA-Z].{1,20}$";
    }
    public static class Validation
    {
        public static bool IsLoginValid(string login)
        {
            char lastChar = Convert.ToChar(login.Substring(login.Length - 1, 1));
            if ((lastChar != '-') && (lastChar != '_') && (lastChar != '.'))
            {
                return new Regex(RegexPattern.Login).IsMatch(login);
            }
            return false;

        }
        public static bool IsPasswordValid(string password)
        {
            return new Regex(RegexPattern.Password).IsMatch(password);
        }
        public static bool IsNameValid(string name)
        {
            string[] array = name.Split(' ');
            int count = 0;
            foreach (var item in array)
            {
                if (new Regex(RegexPattern.Name).IsMatch(item))
                {
                    count++;
                }
            }
            if (count == array.Length)
            {
                return true;
            }
            return false;
        }
    }
}
