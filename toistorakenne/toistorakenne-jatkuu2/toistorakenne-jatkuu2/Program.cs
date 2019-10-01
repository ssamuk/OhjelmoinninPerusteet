using System;

namespace toistorakenne_jatkuu2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 1;

            while (n < 10 && i < 10)
            {
                Console.WriteLine(i + " x " + n + " = "   +     i * n);
                i++;
                if (i == 10)
                {
                    n++;
                    i = 1;
                }
            }
            if (n == 10)
            {
                return;
            }

        }
    }
}
