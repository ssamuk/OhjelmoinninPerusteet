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
                Console.WriteLine("This is a valid card");
            else
                Console.WriteLine("This is not a valid card");


        }// MAIN ENDS!
        //this function defines where we put zeros in 'userinput',
        //so this is raw/lazy way to define the bank
        static void WhichBank(string userInput, ref int i)
        {
            char firstNumb = userInput[0];
            Console.WriteLine(firstNumb);

            if (firstNumb == '4' || firstNumb == '5' || firstNumb == '7')
            {
                i = 1;
            }
            else
                i = 2;
        }
        //this function makes BBAN length 14 by knowledge of "WhichBank" function
        static void MachineNumber(ref string userInput, int i)
        {
            Console.WriteLine(userInput[i]);
            if (i == 1)
            {
                while(userInput.Length < 14)
                {
                    userInput = userInput.Insert(7, "0");
                }
            }
            else
            {
                while(userInput.Length < 14)
                {
                    userInput = userInput.Insert(6,"0");
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

                // We add two digits to handle 
                // cases that make two digits  
                // after doubling 
                nSum += d / 10;
                nSum += d % 10;

                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }



    }

}





/*
 *
 * 
 *
1 = Nordea Pankki(Nordea)
2 = Nordea Pankki(Nordea)
31 = Handelsbanken
33 = Skandinaviska Enskilda Banken(SEB)
34 = Danske Bank
36 = Tapiola Pankki
37 = DnB NOR Bank ASA(DnB NOR)
38 = Swedbank
39 = S - Pankki
4 = Aktia Pankki, Säästöpankit(Sp) ja Paikallisosuuspankit(POP)
5 = OP - Pohjola - ryhmä(Osuuspankit(OP), Helsingin OP Pankki ja Pohjola Pankki)
6 = Ålandsbanken ÅAB)
8 = Sampo Pankki
*
- IndexOf
- Insert
- Length
- Replace
- Remove
- Split
- Substring
- Trim
- ToUpper
- ToLower
*
*
*
* 
*/


