using System;
namespace funktio_ja_aliohjelmat2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä kaksi lukua: ");
            Console.WriteLine("Ensimmäinen: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Toinen: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(minimi(i, n));
        }
        static string minimi(int i, int n)
        {
            string lause = "";
            if (i < n)
            {
                Console.WriteLine($"Luku {i} on pienempi kuin luku {n}.");
            }
            else
            {
                Console.WriteLine($"Luku {n} on pienempi kuin luku {i}.");
            }
            return lause;
        }
    }
}


