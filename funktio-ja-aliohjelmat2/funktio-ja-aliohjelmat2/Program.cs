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
            Console.WriteLine($"Vastaus: Luku {minimi(i, n)} on pienempi kuin toinen annetuista luvuista.");
        }
        static int minimi(int i, int n)
        {
            if (i < n)
            {
                
                return i;
            }
            else
            {
                return n;
            }
        }
    }
}
