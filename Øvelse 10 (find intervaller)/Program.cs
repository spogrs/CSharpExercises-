namespace Øvelse_10
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var resultat = FindIntervaller(new List<int> { 2, 5, 4, 8, 12, 6, 7, 10, 13 });
            string tekst = "[";
            for (var i = 0; i < resultat.Count; i++)
            {
                var interval = resultat[i];

                if (interval.Start == interval.Slut - 1)
                {
                    tekst += interval.Start;
                }
                else
                {
                    tekst += $"({interval.Start},{interval.Slut})";
                }

                if (i < resultat.Count - 1)
                {
                    tekst += ",";
                }
            }
            tekst += "]";
            Console.WriteLine(tekst);

        }




        public static List<(int Start, int Slut)> FindIntervaller(List<int> inputList)
        {
            var sorteret = new List<int>(inputList);
            sorteret.Sort();
            var resultat = new List<(int Start, int Slut)>();
            var start = sorteret[0];

            for (var i = 1; i < sorteret.Count; i++)
            {
                if (sorteret[i] != sorteret[i - 1] + 1)
                {
                    resultat.Add((start, sorteret[i - 1] + 1));
                    start = sorteret[i];
                }
            }
            resultat.Add((start, sorteret[^1] + 1));
            return resultat;
        }
    }
}