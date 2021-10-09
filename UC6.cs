using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class UC6
    {
        public string RegexPattern6 = "^[A-Z]{1}[a-z]*$";

        public bool PasswordUppCheck(string PasswordUpper)
        {
            return Regex.IsMatch(PasswordUpper, RegexPattern6);
        }
    }
}

