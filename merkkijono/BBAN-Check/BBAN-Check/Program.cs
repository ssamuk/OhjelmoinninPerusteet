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
           // Int32.TryParse(userInput, out int j);
            
            WhichBank(ref userInput);
            
        }

        static void WhichBank(ref string userInput)
        {
            
            Console.WriteLine(userInput[1]);



            Console.ReadKey();



        }

    }
}
          /*1 = Nordea Pankki(Nordea)
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
            8 = Sampo Pankki*/