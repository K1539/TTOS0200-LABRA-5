/*
    Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia(paino, pituus, nimi). 

    Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella.

    Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Ihminen : Nisakas
    {
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public string Nimi { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Liikun");
        }
        public void Kasva()
        {
            Ika++;
        }
    }
}
