using System.Collections;

namespace Øvelse_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = SumLigning(new List<int> {
            });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static public string SumLigning(List<int> input)
        {
            string output;
            if (input.Count == 0)
            {
            output = "0";
            }
            else
            { 
                output = string.Join(" + ", input);
            }

            output += " = " + input.Sum();

            return output;
        }
    }
}
