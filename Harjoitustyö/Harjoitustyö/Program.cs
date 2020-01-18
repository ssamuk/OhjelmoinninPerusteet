﻿using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //string path = @"Referencenumber.txt"; //This is the name of file where we save reference numbers

            //Here is userinterface to simplify use of program
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface(); 
                switch (userChoise)
                {
                    case 'C':
                        CheckRefNumb();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        break;
                    case 'N':
                        
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        break;
                    case 'M':

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
            int summary = 0;
            char lastNumb;              //this is the last number of userinput which we compare to valmark to check if
            char valMark;               //userinput is valid referencenumber
            int numbLength = 0;
            Console.WriteLine("Please insert reference number to check it: ");
            string userInput = Console.ReadLine();
            numbLength = userInput.Length;
            lastNumb = userInput[numbLength - 1];
            userInput = userInput.Remove(numbLength - 1,1);
            int n = 3;
            for (int i = userInput.Length -1; i >= 0; i--)
            {
                
                if(n == 3)
                {
                    summary = summary + int.Parse(userInput[i].ToString()) * 7;
                    n--;
                }
                else if( n == 2)
                {
                    summary = summary + int.Parse(userInput[i].ToString()) * 3;
                    n--;
                }
                else if(n == 1)
                {
                    summary = summary + int.Parse(userInput[i].ToString()) * 1;
                    n = 3;
                }

            }
            Console.WriteLine(summary);




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