﻿using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = string.Empty;
            

            //Here is userinterface to simplify use of program
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface(); 
                switch (userChoise)
                {
                    case '1':
                        try
                        {
                            input = InputValue(input,4,20);
                            if (CheckReferenceNumb(input) == true && isNumb(input) == true && validLength(input, 4,20) == true && firstNumbZero(input) == true)
                            {
                                
                                Console.WriteLine($"Your input {AddSpaces(input)} is valid reference number.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid ref number");
                            }
                            Console.WriteLine("Press any key to continue!");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine($"wrong input, click anything to continue!");
                            Console.ReadLine();
                        }
                        break;
                    case '2':
                        try
                        {
                            input = InputValue(input, 3, 19);
                            if (isNumb(input) == true && validLength(input, 3, 19) == true && firstNumbZero(input) == true)
                            {
                                CreateManyRefNumb(input, 1);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                            Console.WriteLine("Press any key to continue!");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine($"wrong input, click anything to continue!");
                            Console.ReadLine();
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.WriteLine("How many: ");
                            int count = int.Parse(Console.ReadLine());
                            Console.WriteLine("Base numb?");
                            string baseNumb = Console.ReadLine();
                            if (isNumb(baseNumb) == true && validLength(baseNumb, 3, 19) == true && firstNumbZero(input) == true)
                            {
                                CreateManyRefNumb(baseNumb, count);
                            }
                            else
                            {
                                Console.WriteLine("Something wrong with your baseNumb?");
                            }
                            Console.WriteLine("Press any key to continue!");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine($"wrong input, click anything to continue!");
                            Console.ReadLine();
                        }
                        break;
                    case '4':
                        try
                        {
                            Console.WriteLine();
                            ReadFile(@"Referencenumber.txt");
                            Console.WriteLine("Press anything to continue!");
                            Console.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine($"I think folder is empty or monkeys have destroyed your ref numbs, click anything to continue!");
                            Console.ReadLine();
                        }
                        break;
                    case '0':
                        break;

                    default:
                        Console.WriteLine("\nCheck your input and press enter!.");
                        Console.ReadLine();
                        break;
                }
            } while (userChoise != 'X');

        } // End main program
        public static string ReverseString(string inputValue)
        {
            char[] arr = inputValue.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static string AddSpaces(string inputValue)
        {
            String input = ReverseString(inputValue);

            for (int i = 5; i <= input.Length; i += 5)
            {
                input = input.Insert(i, " ");
                i++;
            }
            
            return ReverseString(input);
        }
        static bool firstNumbZero(string inputValue)
        {
            if (inputValue[0].ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string InputValue(string inputValue, int minValue, int maxValue)
        {
            Console.WriteLine($"\nInput may only be numbers and it must be between numbers {minValue} to {maxValue}");
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            input = input.Replace(".", "");
            return input;
        }
        static bool validLength(string input, int minValue, int maxValue)
        {
            if (input.Length < minValue || input.Length > maxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool isNumb(string inputValue)
        {
            int n = 0;
            for (int i = 0; i < inputValue.Length; i++)
            { 
                bool tryParse = int.TryParse(inputValue[i].ToString(), out _);
                if (tryParse == false) 
                    n++;
            }
            if (n == 0) 
                return true;
            else
                return false;
        }
        static void CreateManyRefNumb(string baseNumbValue, int countValue)
        {
            int i = 0;
            string path = @"Referencenumber.txt"; //This is the name of file where we save reference numbers
            string baseNumb = baseNumbValue;
            
            
            for (int i2 = 0; i2 < countValue; i2++)
            {
                
                
                if ((CheckReferenceNumb(baseNumb+i) == true))
                {
                    Console.WriteLine($"{baseNumb}{i} is a new reference number");
                    WriteToFile(path, baseNumb+i);
                    i++;
                    
                }
                else
                {
                    i++;
                    i2--;
                } 
                    
            }
        }
        static void CreateRefNumb(string input)
        {
            int i = 0;
            if(CheckReferenceNumb(input) == true && isNumb(input) == true && validLength(input,4,20) == true)
            {
                Console.WriteLine($"New reference number is: {input}");
                WriteToFile(@"Referencenumber.txt", input+i);

            }
            else if (CheckReferenceNumb(input) == false)
                while (CheckReferenceNumb(input) == false)
            {
                if (CheckReferenceNumb(input + i) == false)
                {
                    i++;
                }
                else
                {
                    input += i;
                    Console.WriteLine($"New reference number is: {input}");
                    WriteToFile(@"Referencenumber.txt", input);
                }
            }
            
        }
        static char UserInterface()
        {
            Console.WriteLine("-----\n\nThis program Checks reference number and creates them as many as you want and saves" +
                " them in 'Referencenumber.txt' file.\n\n-----\n ");
            Console.WriteLine("---Reference number interface---.");
            Console.WriteLine("[1] Check reference number.");
            Console.WriteLine("[2] Create new reference number.");
            Console.WriteLine("[3] Create many ref numb.");
            Console.WriteLine("[4] Read saved ref numbers.");
            Console.WriteLine("[0] Close program.");
            Console.WriteLine("Choose what to do: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }
        static bool CheckReferenceNumb(string inputValue)

        {
            
            int summary = 0;
            char lastNumb;                //userinput is valid referencenumber
            int numbLength = 0;
            numbLength = inputValue.Length;
            lastNumb = inputValue[numbLength - 1];
            inputValue = inputValue.Remove(numbLength - 1, 1);


            int n = 3;
            for (int i = inputValue.Length - 1; i >= 0; i--)    //This loop sums userinput numbers
            {                                                   //from last to first by 731 rule without 
                                                                //original userinput last number
                if (n == 3)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 7;
                    n--;
                }
                else if (n == 2)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 3;
                    n--;
                }
                else if (n == 1)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 1;
                    n = 3;
                }
            }
            // Console.WriteLine(summary); this line was to check if summary is right
            int numbValidator = summary + int.Parse(lastNumb.ToString());
            if (numbValidator % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void WriteToFile(string path, string inputValue)
        {
            using StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(inputValue);
        }
        static void ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
