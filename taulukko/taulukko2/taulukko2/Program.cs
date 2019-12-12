using System;

namespace taulukko2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //task1
            int[] numbArray = new int[10];
            intro();
            getNumbs(ref numbArray , 0, 20);
            printNumbs(numbArray);
            //task2
            int[,] numbArray2 = new int[10,20];
            getNumbs2(ref numbArray2, 0, 100);
            printNumbs2(numbArray2);
            //Task3
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];
            generateRandomNumbsForThreeArrays(ref arrT_1, ref arrT_2, ref arrT_3);
            printAllThreeArrays(arrT_1, arrT_2, arrT_3);
            Console.ReadKey();
        }
        //Task1 functions
        static void getNumbs(ref int[] numbArray, int lowest, int highest)
        {
            Random rnd = new Random();
            for (int i = 0; i < numbArray.Length; i++)

            {
                
                int rndNumb = rnd.Next(highest); 
                if (numbArray[i] == 0)
                {
                    numbArray[i] = rndNumb;
                }
            }
        }
        static void printNumbs(int[] numbArray)
        {

            Console.WriteLine($"[X] = Arvo");

            for (int i = 0; i < numbArray.Length; i++)

                if (numbArray[i] < 10)
                {
                    Console.WriteLine($"[{i}] = 0{numbArray[i]} ");
                }
                else
                {

                    Console.WriteLine($"[{i}] = {numbArray[i]} ");
                }

        }
        static void intro()
        {
            Console.WriteLine("This program gives 10 random numbers between 0 and 20." +
                "\nPress any key to continue!");
            Console.ReadKey();
        }
        //task2 functions 
        static void getNumbs2(ref int[,] numbArray2, int x, int y)
        {
            Random rnd = new Random();
            for (int i = 0; i < numbArray2.GetLength(0); i++)
            {
                for(int j = 0; j < numbArray2.GetLength(1); j++)
                {

                    numbArray2[i, j] = rnd.Next(100);

                }
                
            }
        }
        static void printNumbs2(int[,] numbArray2)
        {
            Console.WriteLine("\n\nHere is task2\n");
            Console.WriteLine("[X, Y ] = Arvo");
            for (int i = 0; i < numbArray2.GetLength(0); i++)
            {
                for (int j = 0; j < numbArray2.GetLength(1); j++)
                { 
                    Console.WriteLine($"[{i}, {j:d2}] = {numbArray2[i, j]:d2}");
                }
                
            }

            


        }

        //Task3 functions
        static void generateRandomNumbsForThreeArrays(ref int[] arrT_1, ref int[] arrT_2, ref int[] arrT_3)
        {
            Console.WriteLine("\n\nTask3\n");
            Random rnd = new Random();
            for (int i = 0; i < arrT_1.Length; i++)
            {
                int rndNumb = rnd.Next(50);
                arrT_1[i] = rndNumb;

                int rndNumb2 = rnd.Next(50);
                arrT_2[i] = rndNumb2;

                int rndNumb3 = rnd.Next(50);
                arrT_3[i] = rndNumb3;
            }
        }
        static void printAllThreeArrays(int[] arrT_1, int[] arrT_2, int[] arrT_3)
        {
            int[] tempArray = new int[3];
            for (int i = 0; i < arrT_1.Length; i++)
            {
                tempArray[0] = arrT_1[i];
                tempArray[1] = arrT_2[i];
                tempArray[2] = arrT_3[i];

                if (tempArray[0] < tempArray[1] && tempArray[2] < tempArray[1])
                {
                    arrT_1[i] = tempArray[0];
                    arrT_2[i] = tempArray[1];
                    arrT_3[i] = tempArray[1];
                }
                else if (tempArray[1] < tempArray[0] && tempArray[2] < tempArray[0])
                {
                    arrT_1[i] = tempArray[0];
                    arrT_2[i] = tempArray[1];
                    arrT_3[i] = tempArray[0];
                }

                   else if (tempArray[0] < tempArray[2] && tempArray[1] < tempArray[2])
                   {
                       arrT_1[i] = tempArray[1];
                       arrT_2[i] = tempArray[0];
                       arrT_3[i] = tempArray[2];
                   }

                    else  if (tempArray[0] < tempArray[2] && tempArray[1] < tempArray[2])
                    {
                        arrT_1[i] = tempArray[1];
                         arrT_2[i] = tempArray[0];
                       arrT_3[i] = tempArray[2];
                    }


            }
            Console.Write("       ");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i:d2} ");
            }
            Console.WriteLine("\n       -----------------------------");
            Console.Write($"Array1 ");
            for (int i = 0; i < arrT_1.Length; i++)
            {
                Console.Write($"{arrT_1[i]:d2} ");
            }
            Console.Write($"\nArray2 ");
            for (int i = 0; i < arrT_2.Length; i++)
            {
                Console.Write($"{arrT_2[i]:d2} ");
            }
            Console.Write($"\nArray3 ");
            for (int i = 0; i < arrT_3.Length; i++)
            {
                Console.Write($"{arrT_3[i]:d2} ");
            }



        }


    }
}