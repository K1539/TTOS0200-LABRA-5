/*
 * Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.

    Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).

    Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). 
    Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. 
    Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa

    Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. 
    Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". 
    Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". 
    Lisää aikuiselle ominaisuus auto (String). Lisää vauvalle ominaisuus vaippa (String).

    Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.
     *
     *Jere Liikka 24.1.2017
     * */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Ihminen ihminen = new Ihminen();
            ihminen.Nimi = "Jere";
            ihminen.Ika = 20;
            ihminen.Paino = 80;
            ihminen.Pituus = 178;
            //
            Ihminen ihminen2 = new Ihminen();
            ihminen2.Nimi = "Konsta";
            ihminen2.Ika = 20;
            ihminen2.Paino = 90;
            ihminen2.Pituus = 176;
            //
            Aikuinen aikuinen = new Aikuinen();
            aikuinen.Nimi = "Taisto";
            aikuinen.Ika = 78;
            aikuinen.Paino = 85;
            aikuinen.Pituus = 180;
            aikuinen.Auto = "Volvo 740";
            //
            Aikuinen aikuinen2 = new Aikuinen();
            aikuinen2.Nimi = "keijo";
            aikuinen2.Ika = 75;
            aikuinen2.Paino = 85;
            aikuinen2.Pituus = 170;
            //
            Vauva vauva = new Vauva();
            vauva.Nimi = "Ilari";
            vauva.Ika = 1;
            vauva.Paino = 20;
            vauva.Pituus = 70;
            vauva.Vaippa = "jalassa";

            Console.WriteLine("     Ihminen");
            Console.WriteLine("Nimi : {0}, Ikä : {1}, Paino : {2}, Pituus : {3}", ihminen.Nimi, ihminen.Ika, ihminen.Paino, ihminen.Pituus);
            Console.WriteLine("Laitetaanko ihminen kasvamaan vuosissa? (yes / no > ");
            string vastaus = Console.ReadLine();
            if (vastaus == "yes")
            {
                ihminen.Kasva();
                Console.WriteLine("Nimi : {0}, Ikä : {1}, Paino : {2}, Pituus : {3}", ihminen.Nimi, ihminen.Ika, ihminen.Paino, ihminen.Pituus);
            }
            ihminen.Liiku();
            Console.WriteLine();
            //
            Console.WriteLine("     Aikuinen");
            Console.WriteLine("Nimi : {0}, Ikä : {1}, Paino : {2}, Pituus : {3}, Auto : {4}", aikuinen.Nimi, aikuinen.Ika, aikuinen.Paino, aikuinen.Pituus, aikuinen.Auto);
            Console.WriteLine("Laitetaanko aikuinen kasvamaan vuosissa? (yes / no > ");
            vastaus = Console.ReadLine();
            if (vastaus == "yes")
            {
                ihminen.Kasva();
                Console.WriteLine("Nimi : {0}, Ikä : {1}, Paino : {2}, Pituus : {3}", ihminen.Nimi, ihminen.Ika, ihminen.Paino, ihminen.Pituus);
            }
            aikuinen.Liiku();
            Console.WriteLine();
            //
            Console.WriteLine("     Vauva");
            Console.WriteLine("Nimi : {0}, Ikä : {1}, Paino : {2}, Pituus : {3}, Vaippa : ", vauva.Nimi, vauva.Ika, vauva.Paino, vauva.Pituus, vauva.Vaippa);
            Console.WriteLine("Laitetaanko vauva liikkumaan? (yes / no > ");
            vastaus = Console.ReadLine();
            if (vastaus == "yes")
            {
                vauva.Liiku();
            }
            
        }
    }
}
