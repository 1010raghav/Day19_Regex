using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class UC3
    {
        public string RegexPattern3 = "^[a-z]{3}[.]{1}[a-z]{3}[@]{1}[b]{1}[l]{1}[.]{1}[c]{1}[o]{1}$";
        public bool emailCheck(string Email)
        {
            return Regex.IsMatch(Email, RegexPattern3);
        }
    }
}
