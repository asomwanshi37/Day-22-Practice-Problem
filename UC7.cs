using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UC7
    {
        public string RegexPattern7 = "^[A-Z]{1}[a-z]*$";

        public bool PasswordUppCheck(string PasswordUpper)
        {
            return Regex.IsMatch(PasswordUpper, RegexPattern7);
        }
    }
}
