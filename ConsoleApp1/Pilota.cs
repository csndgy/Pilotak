using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pilota
    {
        string nev { get; set; }
        string szuletesiDatum{ get; set; }
        string nemzetiseg { get; set; }
        int rajtszam { get; set; }
        int ev { get; set; }


        public Pilota(string elsosor)
        {
            var sor = elsosor.Split(";");
            this.nev = sor[0];
            this.szuletesiDatum = sor[1];
            this.nemzetiseg = sor[2];
            this.rajtszam = int.Parse(sor[3]);
            this.ev = int.Parse(sor[4]);
        }
    }
}
