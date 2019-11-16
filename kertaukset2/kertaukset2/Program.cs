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
            //tells user what program does
            Console.WriteLine("Lets sum given numbers till u give two same in a row");
            int sum = 0; //final summary
            int temp = 0; // temporary
            bool isItTrue = false; // with boolean easy to stay in loop as long as we want

            do 
            {
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == temp)
                {
                    isItTrue = true;
                    sum += userInput;
                }                          //wanted to make it use do while for learning curve
                else
                    sum += userInput;
                    temp = userInput;

            } while (isItTrue == false); // here we check if loop ends
            
            Console.WriteLine($"Output: Summary is {sum}"); // final output
            
        }
        static void oneToHundred()
        {

            bool isItTrue = false; //with boolean its easy ro determine how long we want to stay in loop
            Random rnd = new Random();
            int rndNumb = rnd.Next(100); // random number must be generated outside of the loop
            int n = 0; // this right here counts how many times user tries to quess right number
            Console.WriteLine("\nTask 2\nI know a number between 1-100, try to quess it!");


            
            //if input is something else than random number it stays false
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
                    isItTrue = true; // right quess, its time to close the loop
            }
            //Final output
            Console.WriteLine($"Right! It took {n} times to quess right number. Well done!");

        }
    }
}
