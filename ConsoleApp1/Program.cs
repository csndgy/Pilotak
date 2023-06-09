﻿using ConsoleApp1;
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
                pilota.Add(new Pilota(pilotak[0], pilotak[1], pilotak[2], int.Parse(pilotak[3]), int.Parse(pilotak[4])));
            }
            sr.Close();

            Console.WriteLine($"3.feladat: {pilota.Count()}");

            var utolsoNev = pilota.Last().Nev;
            Console.WriteLine($"4.feladat: {utolsoNev}");

            //string[] szuldatumsplit = pilota.sz
            Console.WriteLine($"5.feladat: {pilota}");

            Console.WriteLine($"6. feladat: {pilota.Where(y => y.Rajtszam != null).ToList().OrderBy(x => x.Rajtszam).First().Nemzetiseg}");


        }
    }
}