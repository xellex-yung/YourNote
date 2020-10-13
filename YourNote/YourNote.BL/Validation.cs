using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YourNote.BL
{
    public static class Validation
    {
        public static bool IsLoginValid(string login)
        {
            Regex regex = new Regex(@"");

            return regex.IsMatch(login);
        }
    }
}
