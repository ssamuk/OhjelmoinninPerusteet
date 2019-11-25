using System;

namespace vokaaliLaskuri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            intro();

            
            string vokaalit = "AEIOUYÄÖ";
            string userInput = Console.ReadLine();
            int n = userInput.Length;
            int howManyVocals = 0;

            for (int i = 0; i < n; i++)
            {
                for(int i2 = 0; i2 < vokaalit.Length; i2++)
                {
                    if (userInput.ToUpper()[i] == vokaalit[i2])
                    {
                        howManyVocals++;
                    }
                }
            }

            Console.WriteLine($"Your input '{userInput}' has {howManyVocals} vocals!");

        }
        static void intro()
        {
            Console.WriteLine("Write something and ill count vocals for you!");
        }
       
    }
}
