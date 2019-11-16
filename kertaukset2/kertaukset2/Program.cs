using System;

namespace kertaukset2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            twoSameNumbers();
            oneToHundred();

        }






        static void twoSameNumbers()
        {
            Console.WriteLine("Lets sum given numbers till u give two same in a row");
            int sum = 0;
            int temp = 0;
            bool isItTrue = false;

            do
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == temp)
                {
                    isItTrue = true;
                    sum += userInput;
                }
                else
                    sum += userInput;
                    temp = userInput;

            } while (isItTrue == false);
            
            Console.WriteLine($"Output: Summary is {sum}");
            




        }







        static void oneToHundred()
        {
            bool isItTrue = false;
            Random rnd = new Random();
            int rndNumb = rnd.Next(100);
            int n = 0;
            Console.WriteLine("\nTask 2\nI know a number between 1-100, try to quess it!");


            while (isItTrue == false)
            {
                Console.Write("Take a quess: ");
              int userInput = int.Parse(Console.ReadLine());
                n++;

                if (userInput < rndNumb)
                {
                    Console.WriteLine("Too low");
                }
                else if (userInput > rndNumb)
                {
                    Console.WriteLine("Too high!");
                }
                else
                    isItTrue = true;
            }

            Console.WriteLine($"Right! It took {n} times to quess right number. Well done!");

        }
    }
}
