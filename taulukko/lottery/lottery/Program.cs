using System;

namespace lottery
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] lotto = new int[40];
            intro();
            rndLottoNumbs(ref lotto, 7, 1);
            rndLottoNumbs(ref lotto, 1, 2);
            printLottoNumbs(lotto);


        }

        static void intro()
        {
            Console.WriteLine("This program gives you 7 random numbers" +
                " for lotto + extra and double number.\n");
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }

        static void rndLottoNumbs(ref int[] arrlotto, int count, int value)
        {

            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int rndnumb = rnd.Next(arrlotto.Length);
                if (arrlotto[rndnumb] == 0)
                {
                    arrlotto[rndnumb] = value;
                }
                else
                    i--;
            }

        }

        static void printLottoNumbs(int[] arrlotto)
        {
            Random rnd = new Random();
            Console.WriteLine("\n\nTodays's lotto numbers are following:");
            for (int i = 0; i < arrlotto.Length; i++)
            {
                
                if (arrlotto[i] == 1)
                {
                    Console.Write($"{i +1} ");
                }
            }

            Console.WriteLine("\n\nExtra number is: ");
            for(int i = 0; i < arrlotto.Length; i++)
                if (arrlotto[i] == 2)
            {
                Console.WriteLine($"{i} ");
            }

            Console.WriteLine($"\nDouble number is:\n{rnd.Next(arrlotto.Length)}");
        }






    }
}
