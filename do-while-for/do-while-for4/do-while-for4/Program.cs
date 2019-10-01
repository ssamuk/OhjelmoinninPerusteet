using System;

namespace do_while_for4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku mihin saakka lisätään tai vähennetään: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int vastaus = 0;


            if (n > 0)

            {
                while (i <= n)
                {
                    vastaus = (vastaus + i);
                    i++;
                }
                Console.WriteLine("Vastaus on: " + vastaus);

            }
            else

            if (n < 0)
            {
                while (i >= n)
                {
                    vastaus = (vastaus + i);
                    i--;
                }
                Console.WriteLine("Vastaus on: " + vastaus);
            }
        }
    }
}
