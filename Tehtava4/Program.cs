using System;
using System.Collections.Generic;

namespace JAMK.IT
{
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VuosiMalli { get; set; }

        public Auto(string merkki, string malli, int vuosimalli)
        {
            Merkki = merkki;
            Malli = malli;
            VuosiMalli = vuosimalli;
        }

        public override string ToString()
        {
            return Merkki + " " + Malli + ", " + VuosiMalli + "\n";
        }
    }

    public class Autotalli
    {
        public List<Auto> AutoLista = new List<Auto>();

        public void AddItem(Auto auto)
        {
            AutoLista.Add(auto);
        }

        public override string ToString()
        {
            string s = "Jeren autotallin sisältö:\n\n";
            foreach (Auto auto in AutoLista)
            {
                if (auto != null) s += auto.ToString();
            }
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AutotallinSisalto();
        }

        static void AutotallinSisalto()
        {
            Autotalli autotalli = new Autotalli();
            autotalli.AddItem(new Auto("Volvo", "Amazon", 1967));
            autotalli.AddItem(new Auto("Volvo", "740", 1988));
            autotalli.AddItem(new Auto("Volvo", "850 T5", 1996));
            Console.WriteLine(autotalli.ToString());
        }
    }
}