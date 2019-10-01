using System;

namespace toistorakenne_jatkuu4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n;
            int i = 0;

            int kruuna = 0, klaava = 0;

            Console.Write("Monta heittoa? ");
            n = int.Parse(Console.ReadLine());


            for (i = 0; i < n; i++)
            {
                int result = rnd.Next(2);
                if (result == 1)
                {
                    kruuna++;
                }
                 else if (result == 0)
                {
                    klaava++;
                }
            }

            
            Console.WriteLine("Rahaa on heitetty " + n + " kertaa.");
            Console.WriteLine("Klaavoja tuli " + klaava + " kertaa ja kruunuja " + kruuna + " kertaa.");
            return;
        }
    }
}
