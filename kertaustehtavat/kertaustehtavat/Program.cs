using System;

namespace kertaustehtavat
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Task 1
            Console.Write("Write a lause: ");
            string string1 = Console.ReadLine();

            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine(string1);
            }
           

            //Task 2

            Console.Write("\nWrite a lause: ");
            string string2 = Console.ReadLine();

            for (int i = 0; i < string2.Length; i++)
            {
                Console.WriteLine(string2);
            }


            //Task 3
            Console.WriteLine("\nGive a numbers as long as you want, '-1' stops program: ");
            int numb1 = 0;
            int sum = 0;

            while (numb1 != -1)
            {
                numb1 = int.Parse(Console.ReadLine());
                sum += numb1;
            }

            Console.WriteLine($"Summary is: {sum + 1}");





            //Task4

            Console.WriteLine("Now I want you to insert two numbers and ill show you some serious math skills: ");
            Console.Write("First number: ");
            int numb2 = int.Parse(Console.ReadLine());
            Console.Write("First number: ");
            int numb3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{numb2} + {numb3} = {numb2 + numb3}");
            Console.WriteLine($"{numb2} - {numb3} = {numb2 - numb3}");
            Console.WriteLine($"{numb2} * {numb3} = {numb2 * numb3}");
            Console.WriteLine($"{numb2} / {numb3} = {numb2 / numb3}");




            


        }
    }
}

