using System.Collections;

namespace Øvelse_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = SumLigning(new List<int> { 1, 5, 7 });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static public string SumLigning(List<int> input)
        {
            string output = string.Join(" + ", input);
            output += " = " + input.Sum();
            return output;
        }
    }
}
