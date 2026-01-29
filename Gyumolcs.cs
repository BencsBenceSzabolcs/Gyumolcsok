using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyumolcs
{
    internal class Gyumolcs
    {
        public string nev;
        public string szin;
        public double suly;

        public Gyumolcs(string nev, string szin, double suly)
        {
            this.nev = nev;
            this.szin = szin;
            this.suly = suly;
        }

        public string Leiras()
        {
            return $"Név: {nev}, Szín: {szin}, Súly: {suly} g";
        }
    }
}