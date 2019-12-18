using System;
using System.IO;

class Test
{
    public static void Main()
    {
        Console.WriteLine("Tiedoston kirjoitus ja luku esimerkki.");
        string path = @"MyTest.txt";
        // string path = "c\\temp\\MyTest.txt";                      <----   // Tämä on vanhempi tapa kun @ merkki ei ollut käytössä!

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
            sw.WriteLine("Hello");
            sw.WriteLine("And");
            sw.WriteLine("Welcome");
            sw.WriteLine("Moikka");

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