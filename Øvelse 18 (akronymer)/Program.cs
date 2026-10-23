namespace Øvelse_18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var resultat = Akronymer(@"For the purposes of the EU General Data Protection Regulation (GDPR), the controller of your personal information is International Business Machines Corporation (IBM Corp.), 1 New Orchard Road, Armonk, New York, United States, unless indicated otherwise. Where IBM Corp. or a subsidiary it controls (not established in the European Economic Area (EEA)) is required to appoint a legal representative in the EEA, the representative for all such cases is IBM United Kingdom Limited, PO Box 41, North Harbour, Portsmouth, Hampshire, United Kingdom PO6 3AU.");
            Console.WriteLine(string.Join(", ", resultat));



        }

        static public List<string> Akronymer(string ord)
        {
            List<string> list = new List<string>();

            string[] alleOrd = ord.Split(' ');

            foreach (string enkeltOrd in alleOrd) {
                string rensetOrd = enkeltOrd.Trim('.', ',', '(', ')');

                if (rensetOrd.Length > 1 && rensetOrd == rensetOrd.ToUpper())
                {
                    foreach (char c in rensetOrd)
                    {
                        if (char.IsLetter(c))
                        {
                            list.Add(rensetOrd);
                            break;
                        }
                    }
                }
            }
            
            return list;
        }

    }
}
