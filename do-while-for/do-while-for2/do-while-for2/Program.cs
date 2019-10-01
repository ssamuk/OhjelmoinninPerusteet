using System;

namespace do_while_for2
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Syötä luku mihin saakka lukuja ynnäillään: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int vastaus = 0;


            if (n >= 1)

            {
                while (i <= n)
                {
                    vastaus = (vastaus + i);
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
