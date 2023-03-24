using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    public class Generate
    {
        private Random _random = new Random();

        public string GetRandomPassword(string pattern)
        {
            var password = "";
            while (pattern.Length >= 1)
            {
                var randomIndex = _random.Next(0, pattern.Length);
                var category = pattern[randomIndex];
                switch (category)
                {
                    case 'l':
                        password += GetRandomLowerCaseLetter();
                        break;
                    case 'L':
                        password += GetRandomUpperCaseLetter();
                        break;
                    case 'd':
                        password += GetRandomDigit();
                        break;
                    default: 
                        password += GetRandomSpecialChar();
                        break;
                }
                pattern = pattern.Remove(randomIndex, 1);
            }
            return password;
        }

        private char GetRandom(char asciiChar, int maxLength)
        {
            var randomNumber = _random.Next(0, maxLength);
            var randomLetter = Convert.ToChar(asciiChar + randomNumber);
            return randomLetter;
        }

        private char GetRandomLowerCaseLetter()
        {
            var randomLetter = GetRandom('a', 26); // Gets random ASCII char between a-z
            return randomLetter;
        }

        private char GetRandomUpperCaseLetter()
        {
            var randomLetter = GetRandom('A', 26); // Gets random ASCII char between A-Z
            return randomLetter;
        }

        private char GetRandomDigit()
        {
            var randomDigit = GetRandom('0', 10); // Gets random ASCII char between 0-9
            return randomDigit;
        }

        private char GetRandomSpecialChar()
        {
            var specialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}∼";
            var randomSpecialChar = _random.Next(0, specialCharacters.Length); // Gets random special char from string
            var specialChar = specialCharacters[randomSpecialChar];
            return specialChar;
        }
    }
}