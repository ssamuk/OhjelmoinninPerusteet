using System;

namespace merkkijononkasittely
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region
            //task1
            string str = "Hello World!";
            int i = str.Length;
            Console.WriteLine($"Syötteessä on {i} merkkiä.");
            //Console.WriteLine(str[12]); 

            //task2
            string str2 = "Hello World!";
            Console.WriteLine(str2.Replace("e", "€"));

           
            //task3
            string str3 = "Hello World!";
            int n2 = 0;
            for (int n = 0; n < str3.Length; n++)
            {
                if (str3[n] == 'l')
                {
                    n2++;
                }
            }
            Console.WriteLine($"L kirjaimia oli {n2}");
            #endregion



            //task4

            Console.WriteLine("\n\nSyötäppä lause ni katotaan onko se palintromi");
            string strPalintromi = Console.ReadLine();
            strPalintromi = strPalintromi.Replace(" ", "");
            int i4 = 0;
            int i5 = strPalintromi.Length-1;
            bool check = true;

            for (int n55 = 0; n55 < strPalintromi.Length - 1; n55++)
            {
               
                    if (strPalintromi[i4] == strPalintromi[i5])
                    {
                        i4++;
                        i5--;
                    }
                    else
                        check = false;
            }
            if (check == true)
            {
                strPalintromi = strPalintromi.ToUpper();
                Console.WriteLine($"Your input '{strPalintromi}' is palindromic.");

            }
            else
            {
                strPalintromi = strPalintromi.ToUpper();
                Console.WriteLine($"Your input '{strPalintromi}' was not palindromic");
            }
        }
    }
}