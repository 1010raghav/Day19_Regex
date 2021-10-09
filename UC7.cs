using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class UC7
    {
        public string RegexPattern7 = "[0-9]{1}[a-z]*$";

        public bool PasswordnumCheck(string Passwordnum)
        {
            return Regex.IsMatch(Passwordnum, RegexPattern7);
        }

    }
}
