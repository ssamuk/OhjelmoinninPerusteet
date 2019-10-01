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


            
            if (luku < 0)
                Console.WriteLine("Luku " + luku + " on negatiivinen.");
            else
            if (luku == 0)
                Console.WriteLine("Luku " + luku + " on nolla.");
            else
                Console.WriteLine("Luku " + luku + " on positiivinen.");

            Console.ReadLine();



        }
    }
}