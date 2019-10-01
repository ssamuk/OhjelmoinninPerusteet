using System;

namespace funktio_ja_aliohjelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Monta tähteä: ");
            int i = int.Parse(Console.ReadLine());
            if (i < 1)
            {
                Console.WriteLine($"Numero {i} ei ole sallittu luku.");
            }
            else
            { 
            Console.WriteLine($"{DoStuff(i)}");
            }
        }
        static string DoStuff(int y)
        {
            string value = "";

            for (int i = 0; i < y; i++)
            {
                value += "*";
            }
            return value;
        }
        

    }
}
