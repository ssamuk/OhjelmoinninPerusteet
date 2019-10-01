using System;

namespace toistorakenne_jatkuu3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = 0;
            int n = 1;


            while (n < 5)
            {
                Console.Write("Rivi " + n + ": ");
                while (i < 4)
                {
                    Console.Write(rnd.Next(50) + ", ");
                    i++;
                    if (i == 4)
                    {
                        Console.Write(rnd.Next(50) + ".");
                    }
                }
                i = 0;
                n++;
                Console.WriteLine();
            }
            




                
                
            


        }
        
    }
}
