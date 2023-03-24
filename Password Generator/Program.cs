using System.Diagnostics.Metrics;

namespace Password_Generator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var commandLineArgs = new CommandLineArgs();
            var generate = new Generate();
            var helpText = new HelpText();

            if (commandLineArgs.IsValid(args))
            {
                var pattern = args[1].PadRight(Convert.ToInt32(args[0]), 'l');
                var password = generate.GetRandomPassword(pattern);
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