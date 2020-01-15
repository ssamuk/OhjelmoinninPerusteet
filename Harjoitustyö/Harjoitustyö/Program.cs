using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----\n\nThis program Checks reference number and creates them as many as you want and saves them in 'Referencenumber.txt' file.\n\n-----\n ");
            string path = @"Referencenumber.txt";
            

            WriteToFile(path);
            ReadFile(path);
            Console.ReadKey();















        } // End main program

        static void WriteToFile(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                DateTime currentTime = DateTime.Now;

                sw.WriteLine($"---{currentTime}---");
                

            }
        }
        static void ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
/*
5
Halutun määrän kotimaisten viitenumeroiden luonti toimii oikein ja niiden tallennus tiedostoon onnistuu.
Sovelluksessa on huomioitu virheiden käsittely.

3
Kotimaisen viitenumeron tarkastusalgoritmi rakennettu modulaariseksi.
Toimiva algoritmi kotimaisen viitenumeron luomiseen.

1
Sovelluksen käyttökokemus ja käytettävyys helppoa.
Kotimaisen viitenumeron tarkastus toimii oikein.
*/