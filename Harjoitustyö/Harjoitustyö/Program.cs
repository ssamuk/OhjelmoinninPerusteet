using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string path = @"Referencenumber.txt"; //This is the name of file where we save reference numbers

            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface(); 
                switch (userChoise)
                {
                    case 'C':
                        
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        break;
                    case 'N':
                        
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        break;

                    case 'X':
                        break;

                    default:
                        Console.WriteLine("\nCheck your input and press enter!.");
                        Console.ReadLine();
                        break;
                }
            } while (userChoise != 'X');

            

            
        } // End main program

        static char UserInterface()
        {
            Console.WriteLine("-----\n\nThis program Checks reference number and creates them as many as you want and saves" +
                " them in 'Referencenumber.txt' file.\n\n-----\n ");
            Console.WriteLine("---Reference number interface---.");
            Console.WriteLine("[C] Check reference number.");
            Console.WriteLine("[N] Create new reference number.");
            Console.WriteLine("[X] Close program.");
            Console.WriteLine("Choose what to do: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static void CheckRefNumb()
        {
            Console.WriteLine("Please insert reference number to check it: ");
            int userInput = int.Parse(Console.ReadLine());




        }



        /*static void WriteToFile(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                DateTime currentTime = DateTime.Now;

                sw.WriteLine($"---{currentTime}---");
                

            }
        }*/
        /*static void ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }*/
    }
}
/*
5
Halutun määrän kotimaisten viitenumeroiden luonti toimii oikein ja niiden tallennus tiedostoon onnistuu.
Sovelluksessa on huomioitu virheiden käsittely.

3
Kotimaisen viitenumeron tarkastusalgoritmi rakennettu modulaariseksi.
Toimiva algoritmi kotimaisen viitenumeron luomiseen.

1
Sovelluksen käyttökokemus ja käytettävyys helppoa.
Kotimaisen viitenumeron tarkastus toimii oikein.
*/