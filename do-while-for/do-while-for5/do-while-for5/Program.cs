using System;

namespace do_while_for5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku: ");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            int paritonSumma = 0;
            int parillinenSumma = 0;

            if (n > 0)

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




            else if (n < 0)

                {
                while (i >= n)
                {
                    if (i % 2 == 0)
                    {
                        parillinenSumma = parillinenSumma + i;
                    }
                    else
                    {
                        paritonSumma = paritonSumma + i;
                    }
                    i--;

                }


                Console.WriteLine("Vastaus: Parittomien summa = " + paritonSumma
                    + ", parillisten summa = " + parillinenSumma + ".");

            }

            }
        }
}
