using System;

namespace BBANCheck
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert BBAN: ");
            string userInput = Console.ReadLine();
            userInput = userInput.Replace("-", "");
            int i = 0;
            WhichBank(userInput, ref i);
            MachineNumber(ref userInput, i); // This function adds zeros to user input until its length is 14
            if (CheckLuhn(userInput))
                Console.WriteLine("This is a valid BBAN");
            else
                Console.WriteLine("This is not a valid BBAN");
        }// MAIN ENDS!
        //this function defines where we put zeros in 'userinput',
        //so this is easy way to define bank
        static void WhichBank(string userInput, ref int i)
        {
            char firstNumb = userInput[0];
            if (firstNumb == '4' || firstNumb == '5' || firstNumb == '7')
            {
                i = 1;  //SP, POP or OP 
            }
            else
                i = 2;  //other banks
        }
        //this function makes BBAN length 14 by adding zeros by knowledge of "WhichBank" function
        static void MachineNumber(ref string userInput, int i)
        {
            if (i == 1)
            {
                while(userInput.Length < 14)
                {
                    userInput = userInput.Insert(7, "0");   //SP, POP or OP rule
                }
            }
            else
            {
                while(userInput.Length < 14)
                {
                    userInput = userInput.Insert(6,"0");    //other banks rule
                }
            }
        }
        static bool CheckLuhn(string userInputValue)
        {
            int nDigits = userInputValue.Length;

            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--)
            {
                int d = userInputValue[i] - '0';

                if (isSecond == true)
                    d = d * 2;

                // We add two digits to handle cases that make two digits after doubling               
                nSum += d / 10;
                nSum += d % 10;

                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }
    }
}