using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{
    class Uppgift2
    {
        public static void uppgift2()
        {
            string hejhej = "";
            Console.WriteLine("--Amazing Leap Year Calculator 2019--");
            ReadInt(hejhej);
        }

        public static void ReadInt(string hej)
        {
            int yearOne;
            int yearTwo;

            bool itsTrue = false;

            do
            {
                Console.WriteLine("Skriv in ett år: ");
                yearOne = int.Parse(Console.ReadLine());

                if (yearOne < 0 || yearOne > 9999)
                {
                    Console.WriteLine("Detta året är ogiltigt! Testa igen...");
                }
                else
                {
                    itsTrue = true;
                }

            }
            while (itsTrue == false);

            itsTrue = false;

            do
            {
                Console.WriteLine("Skriv in ditt andra år: ");
                yearTwo = int.Parse(Console.ReadLine());

                if (yearTwo < 0 || yearTwo > 9999)
                {
                    Console.WriteLine("Detta året är ogiltigt! Testa igen...");
                }
                else
                {
                    itsTrue = true;
                }

            }
            while (itsTrue == false);

            for (int NewYears = yearOne; NewYears <= yearTwo; NewYears++)
            {
                if (NewYears % 4 == 0)
                {
                    Console.WriteLine(NewYears + "*");
                }
                else
                {
                    Console.WriteLine(NewYears);
                }
            }

            Console.Read();
        }
    }
}
