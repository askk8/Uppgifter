using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{
    class Uppgift1
    {
        public static void uppgift1()
        {
            string hejhej = "";
            ReadInt(hejhej);
        }

        public static void ReadInt(string hej)
        {
            bool klart = false;

            while (klart == false)
            {
                try
                {
                    Console.WriteLine("Skriv in ett tal: ");
                    var nummerEtt = int.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv in ett till tal: ");
                    var nummerTvå = int.Parse(Console.ReadLine());

                    klart = true;
                    Console.WriteLine();
                    Console.WriteLine($"{nummerEtt} + {nummerTvå} = {nummerEtt + nummerTvå}");
                }
                catch
                {
                    Console.WriteLine("Det är inget nummer, testa igen...");
                }
            }
            Console.Read();
        }
    }
}
