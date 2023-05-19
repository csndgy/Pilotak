using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pilota
    {
        string nev;
        string szuletesidatum;
        string nemzetiseg;
        int rajtszam;
        int ev;

        public Pilota(string nev, string szuletesidatum, string nemzetiseg, int rajtszam, int ev)
        {
            this.nev = nev;
            this.szuletesidatum = szuletesidatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
            this.ev = ev;
        }
        public string Nev { get => nev; }
        public string Szuletesidatum { get => szuletesidatum; }
        public string Nemzetiseg { get => nemzetiseg; }
        public int Rajtszam { get => rajtszam; }
        public int Ev { get => ev; }
    }
}
