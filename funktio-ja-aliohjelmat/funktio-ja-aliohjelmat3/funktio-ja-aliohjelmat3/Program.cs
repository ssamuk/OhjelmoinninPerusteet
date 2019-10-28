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

            
            int inputNumb = 0;
            int ret = 0;


            do
            {

                Console.Write("Give a random number between numbers 1 and 100 then press enter: ");
                inputNumb = int.Parse(Console.ReadLine());

                if (inputNumb >= lowerBound && inputNumb <= upperBound)
                {
                    return inputNumb;
                }
                else
                {
                    Console.WriteLine("Error, try again.");
                    
                }
            } while (inputNumb < lowerBound || inputNumb > upperBound);
            return inputNumb;
        }
        
        
       
    }
}
