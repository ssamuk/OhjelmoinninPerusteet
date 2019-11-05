using System;

namespace taulukko2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] numbArray = new int[10];
            intro();
            getNumbs(ref numbArray , 0, 20);
            printNumbs(numbArray);
        }

        static void getNumbs(ref int[] numbArray, int smallest, int highest)
        {
            Random rnd = new Random();
            for (int i = 0; i < numbArray.Length; i++)

            {
                
                int rndNumb = rnd.Next(highest); // muista vaihtaa ((smallest-highest))
                if (numbArray[i] == 0)
                {
                    numbArray[i] = rndNumb;
                }
            }
        }
        

        static void printNumbs(int[] numbArray)
        {

            Console.WriteLine($"[X] = Arvo");

            for (int i = 0; i < numbArray.Length; i++)

                if (numbArray[i] < 10)
                {
                    Console.WriteLine($"[{i}] = 0{numbArray[i]} ");
                }
                else
                {

                    Console.WriteLine($"[{i}] = {numbArray[i]} ");
                }

        }

        static void intro()
        {
            Console.WriteLine("This program gives 10 random numbers between 0 and 20." +
                "\nPress any key to continue!");
            Console.ReadKey();

        }
    }
}
