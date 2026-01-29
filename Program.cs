using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyumolcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gyumolcs g = new Gyumolcs("Alma", "Piros", 150);
            Console.WriteLine(g.Leiras());
            Console.WriteLine("------------------------------------");
            Alma a = new Alma("Alma", "Zöld", 160, "Granny Smith");
            Console.WriteLine(a.Leiras());
            Console.WriteLine("------------------------------------");
            List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();
            gyumolcsok.Add(new Alma("Alma", "Piros", 150, "Red Delicious"));
            gyumolcsok.Add(new Gyumolcs("Banán", "Sárga", 120));
            gyumolcsok.Add(new Alma("Alma", "Zöld", 160, "Granny Smith"));
            gyumolcsok.Add(new Gyumolcs("Narancs", "Narancssárga", 130));

            int almaSzam = 0;
            int nemAlmaSzam = 0;
            foreach (var item in gyumolcsok)
            {
                if (item is Alma)
                {
                    almaSzam++;
                }
                else
                {
                    nemAlmaSzam++;
                }
            }
            Console.WriteLine($"Almák száma: {almaSzam}, Nem almák száma: {nemAlmaSzam}");
            Console.WriteLine("------------------------------------");
        }
    }
}