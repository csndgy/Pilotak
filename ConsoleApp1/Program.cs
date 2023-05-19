using ConsoleApp1;
using System;
using System.IO;
using System.Linq;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pilota> pilota = new List<Pilota>();
            StreamReader sr = new StreamReader("pilotak.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] pilotak = sr.ReadLine().Split(";");
                pilota.Add()
            }
        }
    }
}