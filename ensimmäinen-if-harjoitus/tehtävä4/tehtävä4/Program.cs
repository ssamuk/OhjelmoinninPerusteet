using System;

namespace tehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {   
            int pienin;
            int toinen;
            int suurin;

            Console.WriteLine("Anna kolme lukua");

            int luku1, luku2, luku3;

            Console.Write("Ensimmäinen: ");
                luku1 = int.Parse(Console.ReadLine());

            Console.Write("Toinen: ");
                luku2 = int.Parse(Console.ReadLine());

            Console.Write("Kolmas: ");
                luku3 = int.Parse(Console.ReadLine());


            if (luku1 > luku2) { toinen = luku1; pienin = luku2; }
            else { toinen = luku2; pienin = luku1; }

            if (toinen > luku3)
            {
                suurin = toinen; if (pienin > luku3)
                {
                    toinen = pienin; pienin = luku3;
                }
                else
                {
                    toinen = luku3;
                }
            }
            else suurin = luku3;

            Console.Write("Pienimmästä suurimpaan on: " + pienin + ", " + toinen + ", " + suurin + ".");




        }
    }
}
