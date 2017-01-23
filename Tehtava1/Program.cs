/*Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. 
 * Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn. 
 * Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina esim. taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen 
 * (kokoelmaluokat käsitellään tarkemmin seuraavissa demoissa). 
 * Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. 
 * Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.

Esimerkkitoiminta:


    Created a new vehichle Porsche model 911
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    Tyre Nokia added to vehicle Porsche
    
    Vechicle Name: Porsche Model:911
    Tyres:
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    
    Created a new vehichle Ducati model Diavel
    Tyre MIC added to vehicle Ducati
    Tyre MIC added to vehicle Ducati
    
    Vechicle Name: Ducati Model:Diavel
    Tyres:
    -Name: MIC Model:Pilot TyreSize:160R17
    -Name: MIC Model:Pilot TyreSize:140R16    
    ... * 
 * 
 * 
 * Jere Liikka 23.1.2017
 * 
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
            TestCarWithFourWheelsV2();
        }

        static void TestCarWithFourWheelsV2()
        {
            // create tyre
            Rengas tyre1 = new Rengas { Valmistaja = "Nokia", Malli = "Hakkapeliitta", Rengaskoko = "205R16" };
            // create a car
            Auto kaara = new Auto { Nimi = "Porsche", Malli = "911" };
            Console.WriteLine("Luotu uusi pirssi {0} {1}", kaara.Nimi, kaara.Malli);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            Console.WriteLine(kaara.ToString());
        }
    }
}
