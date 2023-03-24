using System.Diagnostics.Metrics;

namespace Password_Generator
{
    public class Program
    {
        private static Random s_random = new Random();

        public static void Main(string[] args)
        {
            var commandLineArgs = new CommandLineArgs();
            var helpText = new HelpText();
            var generate = new Generate(s_random);

            if (commandLineArgs.IsValid(args))
            {
                var pattern = args[1].PadRight(Convert.ToInt32(args[0]), 'l');
                var password = "";

                while (pattern.Length >= 1)
                {
                    var randomIndex = s_random.Next(0, pattern.Length);
                    if (pattern[randomIndex] == 'l')
                    {
                        password += generate.GetRandomLowerCaseLetter();
                    }
                    else if (pattern[randomIndex] == 'L')
                    {
                        password += generate.GetRandomUpperCaseLetter();
                    }
                    else if (pattern[randomIndex] == 'd')
                    {
                        password += generate.GetRandomDigit();
                    }
                    else
                    {
                        password += generate.GetRandomSpecialChar();
                    }
                    pattern = pattern.Remove(randomIndex, 1);
                }
                Console.WriteLine(password);
                Console.ReadKey(true);
            }
            else
            {
                helpText.Message();
                Console.ReadKey(true);
            }
        }
    }
}