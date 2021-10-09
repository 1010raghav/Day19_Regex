using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class UC4
    {
        public string RegexPattern4 = "^[9]{1}[1]{1}[0-9]{10}$";

        public bool PhonenumberCheck(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, RegexPattern4);
        }
    }
}
