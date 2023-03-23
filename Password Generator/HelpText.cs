using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    public class HelpText
    {
        public void Message()
        {
            Console.WriteLine(@"****** HELP TEXT MESSAGE ******

Options:
- l = lower case letter
- L = upper case letter
- d = digit
- s = special character(!""#¤%&/(){}[]

Example: PasswordGenerator 14 lLssdd      
Min. 1 lower case

Min. 1 upper case

Min. 2 special characters
              
Min. 2 digits   
                               ");
            Console.WriteLine("\n\nInvalid command line arguments, press any key to close the program...");
        }
    }
}

