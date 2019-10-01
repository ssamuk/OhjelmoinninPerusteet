using System;

namespace tehtävä3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä luku");
            int luku;
            luku = int.Parse(Console.ReadLine());
            //alemmas apumuuttujat
            string par = "parillinen";
            string pos = "positiivinen";


            //tarkistetaan positiivisuus
            if (luku < 0)
                pos = "negatiivinen";
            else
            if (luku == 0)
                pos = "nolla";
            else
                pos = "positiivinen";


            //tsekataan onko parillinen
            if (luku % 2 == 0)
                par = "parillinen";
            else
                par = "pariton";


            Console.WriteLine("Numero " + luku + " on " + pos + " ja " + par + ".");



            Console.ReadLine();



        }
    }
}
