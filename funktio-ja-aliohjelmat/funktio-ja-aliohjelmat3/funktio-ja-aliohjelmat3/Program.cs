using System;

namespace funktiojaaliohjelmat3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            int retNumber = numberFromRange(1, 100);
            Console.WriteLine($"Your input {retNumber} passes test!");

        }

        static int numberFromRange(int lowerBound, int upperBound)
        {
            bool isNumb = false;
            int inputNumb = 0;

            do
            {
                Console.Write("Give a random number between numbers 1 and 100 then press enter: ");
                isNumb = int.TryParse(Console.ReadLine(),out inputNumb);

                if (inputNumb >= lowerBound && inputNumb <= upperBound)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error, try again.");
                    isNumb = false;

                }
            } while (isNumb == false && inputNumb < lowerBound || isNumb == false && inputNumb > upperBound);
             return inputNumb;
        }
        
        
       
    }
}
