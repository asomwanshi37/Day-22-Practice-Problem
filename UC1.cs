using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class UC1
    {
        public string RegexPattern = "^[A-Z]{1}[a-z]*$";

        public bool FirstNameCheck(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexPattern);
        }

       
    }
}
