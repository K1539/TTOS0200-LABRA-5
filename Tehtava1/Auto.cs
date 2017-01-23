using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Auto
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        private const int maxRenkaat = 4;
        private int lkmRenkaat = 0;

        public List<Rengas> Renkaat { get; }

        public Auto()
        {
            Renkaat = new List<Rengas>();
        }

        public void LisääRengas(Rengas rengas)
        {
            if (lkmRenkaat < maxRenkaat)
            {
                Renkaat.Add(rengas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Malli, Nimi);
            }
            else
            {
                Console.WriteLine("No room for a new tyres..., sorry!");
            }
        }

        public override string ToString()
        {
            string s = "Pirssissä: " + Nimi + " malli :" + Malli + "\nrenkaat:";
            foreach (Rengas r in Renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }
    }
}
