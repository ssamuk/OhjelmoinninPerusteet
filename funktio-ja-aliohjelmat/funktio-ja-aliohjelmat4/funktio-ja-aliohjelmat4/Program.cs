using System;

namespace funktiojaaliohjelmat4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(numbers());
        }


        static string numbers()
        { 

            int maxInput = 1;
            int input;
            int count = 1;
            int highNumb = 0;
            string output = "";
            string finalOutput = "";


            Console.WriteLine("Give 10 positive numbers: ");
            

            while (count <= 10)
            {
                
                Console.Write($"{count}. ");


                    input = int.Parse(Console.ReadLine());

                if (input > 0)
                {
                    
                    if (input > highNumb)
                    {
                        highNumb = input;
                        maxInput = count;
                    }
                    output += $"{input} ";
                    count++;
                }
                else if (input < 0)
                    Console.WriteLine("Wrong input, number must be positive.");

                
            }
            finalOutput = $"You gave these numbers: {output}\n Highest number was {highNumb} and it was {maxInput}. number.";
            return finalOutput;
        }


    }
}

