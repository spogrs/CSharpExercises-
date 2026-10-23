namespace Øvelse_13
{
    internal class Program
    {
     

        static void Main(string[] args)
        {


            var d = new Dictionary<string, List<string>>
            {
                ["move"] = new List<string> { "flytte" },
                ["hide"] = new List<string> { "gemme", "skjule" },
                ["guy"] = new List<string> { "fyr" },
                ["lighthouse"] = new List<string> { "fyr" }
            };

            var omvendt = VendOrdBog(d);
            foreach (var par in omvendt)
            {
                Console.WriteLine($"{par.Key}: {string.Join(", ", par.Value)}");
            }


        }

        public static Dictionary<string, List<string>> VendOrdBog(Dictionary<string, List<string>> d)
        {
            Dictionary<string, List<string>> rd = new Dictionary<string, List<string>>();

            foreach (var pair in d)
            {
                foreach (var w in pair.Value)
                {
                    if (!rd.ContainsKey(w))
                    {
                        rd[w] = new List<string>() { pair.Key };
                    }
                    else
                    {
                        rd[w].Add(pair.Key);
                    }
                        
                }
            }

            return rd;
        }

    }
}
