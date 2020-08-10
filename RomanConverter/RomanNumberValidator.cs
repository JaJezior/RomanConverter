using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RomanConverter
{
    public class RomanNumberValidator
    {
        public Regex _regex = new Regex(@"^(?=[MDCLXVI])M*(C[MD]|D?C{0,3})(X[CL]|L?X{0,3})(I[XV]|V?I{0,3})$");

        public bool ValidateInput(string input)
        {
            if (_regex.IsMatch(input)) return true;
            else return false;
        }
    }
}
