using System;

namespace lipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {

            double lipunHinta = 16;
            int ika;
            
            Console.WriteLine("Kuinka vanha olet?");
                ika = int.Parse(Console.ReadLine());

            
            if (ika < 7)
            {
                lipunHinta = 0;
                Console.Write("Lipun hinta on: " + lipunHinta + " euroa.");
                return;
              
            }
            else if (ika >= 65)
            {
                lipunHinta = (lipunHinta * 0.5);
                Console.WriteLine("Lipun hinta on: " + lipunHinta + " euroa.");
                return;
            }
            else if (ika > 6 && ika < 16)
            {
                lipunHinta = (lipunHinta * 0.5);
                Console.WriteLine("Lipun hinta on: " + lipunHinta + " euroa.");
                return;
            }
            else
            {
                lipunHinta = 16;
            }


            //checking if mtk and stud
            Console.WriteLine("Oletko Mtk jäsen sekä opiskelija? Nolla = en, yksi = kyllä");
            int MtkStud = int.Parse(Console.ReadLine());
            if (MtkStud == 1)
            {
                lipunHinta = (lipunHinta * 0.4);
                Console.WriteLine("Lipun hinta on: " + lipunHinta + " euroa.");
                return;
            }
            

            Console.WriteLine("Oletko opiskelija? Nolla = en, yksi = kyllä");
            int stud = int.Parse(Console.ReadLine());
            if (stud == 1)
            {
                lipunHinta = (lipunHinta * 0.55);
                Console.WriteLine("Lipun hinta on: " + lipunHinta + " euroa.");
                return;
            }



            Console.WriteLine("Oletko varusmies? Nolla = en, yksi = kyllä");
            int varusmies = int.Parse(Console.ReadLine());
            if (varusmies == 1)
            {
                lipunHinta = (lipunHinta * 0.5);
                Console.WriteLine("Lipun hinta on: " + lipunHinta + " euroa.");
                return;
            }




            Console.WriteLine("Lipun hinta on: " + lipunHinta + " euroa.");
            return;

        }
    }
}
