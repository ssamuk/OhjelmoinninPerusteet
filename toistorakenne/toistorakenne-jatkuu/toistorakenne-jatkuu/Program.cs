using System;

namespace toistorakenne_jatkuu
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Luku   Neliöjuuri");

            double i = 0;
            
            
            while (i <= 10)
            {
                double neliojuuri = Math.Sqrt(i);
                Console.WriteLine("{0}      {1}", i,neliojuuri);
                i++;
            }
            return;
        }
    }
}
