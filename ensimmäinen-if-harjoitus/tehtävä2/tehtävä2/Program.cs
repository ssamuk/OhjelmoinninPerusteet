using System;


namespace EhtoJaSilmukka
{
    public class Program
    {
        static void Main(string[] args)
        {

            int luku;

            Console.WriteLine("Syötä luku!");
            luku = int.Parse(Console.ReadLine());

            if (luku % 2 == 0)
                Console.WriteLine("Luku " + luku + " on parillinen.");
            else
                Console.WriteLine("Luku " + luku + " on pariton.");

            Console.ReadLine();



        }
    }
}
