// Esimerkkiratkaisu tehtävää 1
// Pirkko Sutinen 13.4.2021
// pirkko.sutinen@sasky.fi

namespace tehtävä1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mikä sinun nimesi on?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Minä ikäinen olet?");
            string ika = Console.ReadLine();
            bool tulos;
            int iika;
            tulos = int.TryParse(ika, out iika);
            if (tulos)
            {
                Console.WriteLine($"Ajattele {nimi.ToUpper()}, vuonna 2036 olet jo {iika + 10} vuotta vanha");
            }
            else
            {
                Console.WriteLine("Anna ikä numerona");
            }
        }
    }
}
