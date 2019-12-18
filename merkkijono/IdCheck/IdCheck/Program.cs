using System;

namespace SocialSecurityNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("This program will check whether the inputted Social Security Number is ");
             Console.WriteLine("a valid Finnish SSN.");*/


            char userChoise;
            do
            {
                userChoise = UserInterface(); // kutsutaan käyttöliittymä funktiota
                switch (userChoise)
                {
                    case 'T':
                        SSNChecker(); //kutsutaan sotun tarkastus funktiota
                        break;
                    case 'u':
                        SSNCreator(); // Kutsutaan sotun luontifunkiota
                        break;

                    case 'X':
                        break;

                    default:
                        Console.WriteLine("\nTarkasta mitä painoit! Jatka enterillä.");
                        Console.ReadLine();
                        break;
                }

            } while (userChoise != 'X');

           
        } // END MAIN PROGRAM
        static void SSNChecker() //function
        {
            Console.Write("\nAnna tarkastettava sotu [PPKKVV-XXXT]: ");
            string userInput = Console.ReadLine();
            userInput = RemoveSpaces(userInput);
            if (IsValidLength(userInput))
            {
                if (IsValidDate(userInput)) // already contains error messages so no need for else 
                {
                    int idNumber = InputParser(userInput);
                    char getLastChar = GetUserInputCheckMark(userInput);
                    bool isOK = IsValidID(idNumber, getLastChar);
                    PrintResult(isOK);
                }
            }
            else
            {
                Console.WriteLine("Please check the inputted SSN. Too many characters.");
            }

        }

        static void SSNCreator()
        {
            Console.Write("\nAnna tarkastettava sotu [PPKKVV-XXXT]: ");
            string userInput = Console.ReadLine();

            userInput = RemoveSpaces(userInput);
            IsValidLength(userInput, 10);
            if (IsValidDate(userInput))
            {
                int idNumber = InputParser(userInput);
                char getValidationMark = GetValidID(idNumber);
                PrintCreatedSSNumner(userInput + getValidationMark);
            }
        }



        static char UserInterface()
        {
            Console.WriteLine("Henkilötunnuksen käsittely.");
            Console.WriteLine("[T] Tarkista henkilötunnuksen oikeellisuus.");
            Console.WriteLine("[U] Luo uusi henkilötunnus.");
            Console.WriteLine("[X] Sulje ohjelma.");
            Console.WriteLine("Valitse mitä tehdään: ");

            return char.ToUpper(Console.ReadKey().KeyChar);

        }

        static bool IsValidDate(string userInput)
        {
            //131052-308T
            bool result = false;
            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(2, 2);
            string year = userInput.Substring(4, 2);
            string century = userInput.Substring(6, 1);

            if (century == "-")
            {
                year = "19" + year; // given results are string type, so result will be 19 + 52 = 1952 
                                    // instead of 19 + 52 = 73 if they were integer
            }
            else if (century == "A")
            {
                year = "20" + year;
            }
            else
            {
                Console.WriteLine("The given century is incorrect.");
                return result;
            }
            try // using try catch you can easily check for possible errors
                // especially handy if you know there can be errors 
            {
                // using Datetime function you can easily calculate whether the inputted date is valid or not
                // DateTime includes checks for correct day, month, year and also includes leap year
                DateTime birthDate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Invalid date.");
            }
            return result;
        }




        /// <summary>
        /// Check is userInput correct length?
        /// Default Length is 11.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        static bool IsValidLength(string userInput)
        {
            return userInput.Length == 11; // returns true if lenght is 11, otherwise returns false
                                           //if userInput.Length == 11) ;
                                           //    return true;
                                           //else
                                           //    return false;
        }




        static bool IsValidLength(string userInput, int length)
        {
            return userInput.Length == length; 
        }




        static string RemoveSpaces(string userInput) // you could also use ref, but it may cause problems 
                                                     // if there are multiple references within the code
        {
            string result = userInput.Replace(" ", ""); // This will replace spaces with empty (NULL).
            return result;
        }

        static char GetUserInputCheckMark(string userInput)
        {
            return userInput[userInput.Length - 1]; // cannot use just length, because program will go to 
        }

        static int InputParser(string stringParser)
        {
            string removed = stringParser;
            if (stringParser.Length > 10)
            {
                removed = stringParser.Remove(10, 1); // this removes the last character from the string
            }
            removed = removed.Remove(6, 1); // this removes the 7th character from the string (-, + or x)
            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber, char checkUserMark)
        {
            string checkMark = "0123456789ABCDEFHJKLMPRSTUVWXY"; // define an array for cross referencing

            int modChecker = idNumber % 31; // this will divide the given number with 31, mod31

            //Checks whether the last char of the input is the same as the counted one
            //if (checkMark[modChecker] == checkUserMark);  // if same, returns this value
            //    return true;
            //else                                          // if different, returns this
            //    return false;
            //yllä oleva on sama kuin alla oleva
            return checkMark[modChecker] == checkUserMark;
        }


        static char GetValidID(int idNumber)
        {
            string checkMark = "0123456789ABCDEFHJKLMPRSTUVWXY"; // define an array for cross referencing
            int modChecker = idNumber % 31; // this will divide the given number with 31, mod31
            return checkMark[modChecker];
        }



        static void PrintResult(bool isValidId)
        {
            if (isValidId)
                Console.WriteLine("The inputted SSN is valid.");
            else
                Console.WriteLine("The inputted SSN is incorrect.");
        }

        static void PrintCreatedSSNumner(string newSSNumber)
        {
            Console.WriteLine($"Luotu sotu on: {newSSNumber}");
        }
    }

}

