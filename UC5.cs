using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class UC5
    {
        public string RegexPattern5 = "^[a-z]{7}[a-z]*$";

        public bool PasswordCheck(string Passwordchar)
        {
            return Regex.IsMatch(Passwordchar, RegexPattern5);
        }
    }
}
