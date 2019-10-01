using System;

namespace do_while_for3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Syötä luku: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1;
            int paritonSumma = 0;
            int parillinenSumma = 0;

            if (n >= 1)

            {
                while (i <= n)
                {
                    if (i % 2 == 0)
                    {
                        parillinenSumma = parillinenSumma + i;
                    }
                    else
                    {
                        paritonSumma = paritonSumma + i;
                    }
                        i++;
                    
                }


                Console.WriteLine("Vastaus: Parittomien summa = " + paritonSumma
                    + ", parillisten summa = " + parillinenSumma + ".");

            }
            else
            {
                Console.WriteLine("Luku on liian pieni.");
            }









        }
    }
}
