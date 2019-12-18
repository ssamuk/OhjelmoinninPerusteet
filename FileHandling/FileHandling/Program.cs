using System;
using System.IO;

class Test
{
    public static void Main()
    {
        Console.WriteLine("Tiedoston kirjoitus ja luku esimerkki.");
        string path = @"Users\Samu\Desktop\MyTest.txt";
        // string path = "c\\temp\\MyTest.txt";                      <----   // Tämä on vanhempi tapa kun @ merkki ei ollut käytössä!
        //if (!File.Exists(path))
        //{
        // Create a file to write to.
        
            
       // }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
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


}