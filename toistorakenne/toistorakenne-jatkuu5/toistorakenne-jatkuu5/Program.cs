using System;

namespace toistorakenne_jatkuu5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            

            for (int n = 1; n < 14; n++)
            {
                double result = rnd.NextDouble();

                if (result <= 0.4)
                {
                    Console.WriteLine("{0}. 1", n);
                }

                else if (result > 0.4 && result <= 0.6)
                {
                    Console.WriteLine("{0}. X", n);
                }
                else
                {
                    Console.WriteLine("{0}. 2", n);
                }

                
            }






        }
    }
}
