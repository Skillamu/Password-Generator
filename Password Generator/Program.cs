using System.Diagnostics.Metrics;

namespace Password_Generator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var commandLineArgs = new CommandLineArgs();
            var helpText = new HelpText();
            var generate = new Generate();

            if (commandLineArgs.IsValid(args))
            {
                var pattern = args[1].PadRight(Convert.ToInt32(args[0]), 'l');
                var password = "";

                while (pattern.Length >= 1)
                {
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