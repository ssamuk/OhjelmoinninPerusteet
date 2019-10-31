using System;

namespace lottery
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int temp = 0;
            int n = 0;
            int[] lottery = new int[8];
            Random rnd = new Random();


            for (int i = 0; i <= 7; i++)
            {
                temp = rnd.Next(39);
                while (lottery. == false)
                {
                    lottery[n] = temp;
                    n++;
                }
            }
            Array.Sort(lottery);

            n = 0;
            Console.WriteLine($"Loton oikea rivi on: ");

            //Here i have one way for output
            /*for(int i = 0; i <= 7; i++)
            {
                Console.Write($"{lottery[n]}, ");
                n++;
            }
            */


            //Here is another way for output, this is something that i learned today.
            foreach (int value in lottery)
            {
                Console.Write($"{ value} ");
            }

            Console.WriteLine($"\nLisänumero: ");
            Console.WriteLine($"Tuplausnumero: ");



        }
    }
}
