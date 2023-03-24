using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    public class CommandLineArgs
    {
        private bool IsValidLength(int argLength)
        {
            if (argLength != 2) { return false; }
            return true;
        }

        private bool IsDigitsOnly(string arg0)
        {
            foreach (char character in arg0)
            {
                if (!Char.IsDigit(character)) { return false; }
            }
            return true;
        }

        private bool IsValidLettersOnly(string arg1)
        {
            var validLetters = "Llds";

            foreach (char character in arg1)
            {
                if (!validLetters.Contains(character)) { return false; }
            }
            return true;
        }

        public bool IsValid(string[] args)
        {
            if (IsValidLength(args.Length) && IsDigitsOnly(args[0]) && IsValidLettersOnly(args[1]))
            {
                return true;
            }
            return false;
        }
    }
}
