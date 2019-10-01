using System;

namespace toistorakenne_jatkuu6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int kutoset = 0;

            for ( int n = 1; n <= 1000; n++)
            {
                int result = rnd.Next(6);
                Console.WriteLine($"{n}. {result+1}");
                if (result + 1 == 6)
                {
                    kutoset++;

                }
                
             }
            Console.Write($"Kutonen aravottiin {kutoset} kertaa.");
            return;
        }
    }
}
