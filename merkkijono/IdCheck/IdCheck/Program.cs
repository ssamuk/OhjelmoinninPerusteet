using System;

namespace IdCheck
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            intro();
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);


        }

        static void intro()
        {
            Console.WriteLine("Hello! This program check if user input is valid finnish ID. Lets continue!\nPlease insert ID: ");
        }
        

    }
}
