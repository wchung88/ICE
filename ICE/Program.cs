using System;
using System.Linq;

namespace ICE
{
    public class Program
    {
        private static string Input =
            "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

        public static void Main()
        {
            Console.WriteLine("Please enter a subtext to search with");
            var subtext = Console.ReadLine();
            var result = new Matcher().Match(Input, subtext);

            Console.WriteLine(result.Any() ? string.Join(", ", result) : "<no matches>");
            Console.ReadLine();
        }
    }
}
