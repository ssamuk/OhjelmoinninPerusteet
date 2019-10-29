using System;

namespace taulukko
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1: ");
            // Here we make arrays and give them some information
            double[] productPrice = { 7.96, 72.0, 99.90 };
            int[] productAmount = { 1, 3, 2 };

            //next step is making total prices using product price and amount
            double[] productTotalPrice = { (productAmount[0] * productPrice[0]), (productAmount[1] * productPrice[1]), (productAmount[2] * productPrice[2]) };


            //Now we just call them!
            Console.WriteLine($"Product 1: {productTotalPrice[0]}e");
            Console.WriteLine($"Product 2: {productTotalPrice[1]}e");
            Console.WriteLine($"Product 3: {productTotalPrice[2]}e");





            //Task2

            Console.WriteLine();
            Console.WriteLine("Task 2: ");


            double sum = 0;
            int n = 0;              // n toimii alkiona
            int[] iT = new int[100];
            Random rnd = new Random();

            // filling array with rndm numbers
            for (int i = 0; i < 100; i++)
            {
                iT[n] = rnd.Next(50);
                n++;
            }

            // magic things 
            n = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += iT[n];
                Console.WriteLine($"{n + 1}. {iT[n]}");
                n++;
            }
            Console.WriteLine($"Summary is: {sum}.");



            double ka = (sum / iT.Length);

            Console.WriteLine($"Keskiarvo is {ka}.");

        }
    }
}
