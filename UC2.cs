using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Uc2
    {
        public string RegexPatternn = "^[A-Z]{1}[a-z]*$";

        public bool LastNameCheck(string LastName)
        {
            return Regex.IsMatch(LastName, RegexPatternn);
        }
    }
}
