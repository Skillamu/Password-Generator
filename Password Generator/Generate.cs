using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    public class Generate
    {
        private Random _random;

        public Generate(Random random)
        {
            _random = random;
        }

        private char GetRandom(char character, int maxNumber)
        {
            var randomNumber = _random.Next(0, maxNumber);
            var randomLetter = Convert.ToChar(character + randomNumber);
            return randomLetter;
        }

        public char GetRandomLowerCaseLetter()
        {
            var randomLetter = GetRandom('a', 26);
            return randomLetter;
        }

        public char GetRandomUpperCaseLetter()
        {
            var randomLetter = GetRandom('A', 26);
            return randomLetter;
        }

        public int GetRandomDigit()
        {
            var randomDigit = GetRandom('0', 10);
            return randomDigit;
        }

        public char GetRandomSpecialChar()
        {
            var specialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}∼";
            var randomSpecialChar = _random.Next(0, specialCharacters.Length);
            var specialChar = specialCharacters[randomSpecialChar];
            return specialChar;
        }
    }
}