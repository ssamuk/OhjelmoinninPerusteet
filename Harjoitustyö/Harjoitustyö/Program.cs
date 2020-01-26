using System;
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
                            if (CheckReferenceNumb(input) == true && isNumb(input) == true && validLength(input, 4,20) == true)
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
                        input = InputValue(input,3,19);
                        if(isNumb(input) == true && validLength(input, 3,19) == true)
                        {
                            CreateRefNumb(input);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.WriteLine("How many: ");
                        int count = int.Parse(Console.ReadLine());
                        Console.WriteLine("Base numb?");
                        string baseNumb = Console.ReadLine();
                        if (isNumb(baseNumb) == true && validLength(baseNumb, 3,19) == true)
                        {
                            CreateManyRefNumb(baseNumb, count);
                        }
                        else
                        {
                            Console.WriteLine("Something wrong with your baseNumb?");
                        }
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        break;
                    case '4':
                        Console.WriteLine();
                        ReadFile(@"Referencenumber.txt");
                        Console.WriteLine("Press anything to continue!");
                        Console.ReadLine();
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
        static string InputValue(string inputValue, int minValue, int maxValue)
        {
            Console.WriteLine($"Input may only be numbers and it must be between numbers {minValue} to {maxValue}");
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
            string input = inputValue;
            int inputInt;
            if (!int.TryParse(input, out inputInt))
            {

                return false;
            }
            else
            {
                return true;
            }
        }
        static void CreateManyRefNumb(string baseNumbValue, int countValue)
        {
            string path = @"Referencenumber.txt"; //This is the name of file where we save reference numbers
            string baseNumb = baseNumbValue + 0;
            int baseNumbInt;
            if (!Int32.TryParse(baseNumb, out baseNumbInt))
            {
                baseNumbInt = -1;
            }
            for (int i2 = 0; i2 < countValue; i2++)
            {
                
                
                if ((CheckReferenceNumb(baseNumb) == true))
                {
                    Console.WriteLine($"Your {i2 + 1}. {baseNumbInt} is reference number");
                    WriteToFile(path, baseNumb);
                    baseNumbInt++;
                    baseNumb = Convert.ToString(baseNumbInt);
                    
                }
                else
                {
                    baseNumbInt++;
                    baseNumb = Convert.ToString(baseNumbInt);
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