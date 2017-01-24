using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Jaakaappi
    {
        static public bool Liha { get; set; }
        static public double LihaaKiloina = 0;
        static public bool Maito { get; set; }
        static public double MaitoaLitroina { get; set; }

        
        public Jaakaappi(bool liha, double lihaakiloina, bool maito, double maitoalitroina)
        {
            Liha = liha;
            LihaaKiloina = lihaakiloina;
            Maito = maito;
            MaitoaLitroina = maitoalitroina;
        }
        public Jaakaappi()
        {

        }
        public static void LisaaLihaa()
        {
            Console.WriteLine("  Lihaa lisätty kilo");
            Liha = true;
            LihaaKiloina++;
            Console.WriteLine("     Lihaa yhteensä {0} kiloa", LihaaKiloina);
        }
        public static void LisaaMaitoa()
        {
            Console.WriteLine("  Maitoa lisätty litra");
            Maito = true;
            MaitoaLitroina++;
            Console.WriteLine("     Maitoa yhteensä {0} litraa", MaitoaLitroina);
        }
    }
}
