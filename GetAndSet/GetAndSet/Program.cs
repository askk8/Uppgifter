using System;

namespace GetAndSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1.uppgift1();

            //Uppgift2.uppgift2();

            //Uppgift4.uppgift4();

            //Uppgift5.uppgift5();

            var random = new Random();
            var number = random.Next(1, 100);

            int gissatNummer;

            do
            {
                Console.WriteLine("Gissa på ett tal mellan 0 till 100: ");
                gissatNummer = int.Parse(Console.ReadLine());

                if(gissatNummer < number)
                {
                    Console.WriteLine("För lågt, gissa på ett högre nummer...");
                }
                if(gissatNummer > number)
                {
                    Console.WriteLine("För högt, gissa på ett lägre nummer...");
                }
            } while (gissatNummer != number);

            Console.WriteLine($"Du gissade på {gissatNummer} och det var rätt, grattis!");
            Console.Read();
        }
    }
}
