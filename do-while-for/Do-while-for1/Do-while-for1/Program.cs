using System;

namespace Do_while_for1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku mihin saakka kerrotaan: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int vastaus = 1;


            if (n >= 1)

            {
                while (i <= n)
                {
                    vastaus = (vastaus * i);
                    i++;
                }
                Console.WriteLine("Vastaus on: " + vastaus);

            }
            else
            {
                Console.WriteLine("Liian pieni luku!");
            }
        }


    }
}
