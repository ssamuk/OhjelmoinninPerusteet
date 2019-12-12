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
            MachineNumber(ref userInput, i);
            Console.WriteLine(userInput);

            LuhnModul(ref userInput);
            

        }
        //this method defines where we put zeros in 'userinput',
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
        //this method makes BBAN length == 14 by knowledge of previous method
        static void MachineNumber(ref string userInput, int i)
        {
            

            Console.WriteLine(userInput[1]);



            Console.ReadKey();

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
        static void LuhnModul(ref string userInput)
        {
            string systemOutput = "";
            userInput = userInput.Remove(13);
            Console.WriteLine($"LuhnModul methodissa ''userinput'' on: {userInput}.");
            
           

            for(int i = 12; i >= 0; i--)
            {
                int o = userInput[i];
                Console.WriteLine(o);

            }

                        
            
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