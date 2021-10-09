using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class UC8
    {
        public string RegexPattern7 = "[!-*]{1} [a-z]*$";

        public bool PasswordSpecialCheck(string Passwordspecial)
        {
            return Regex.IsMatch(Passwordspecial, RegexPattern7);
        }
    }
}
