/*
 * Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". 
 * 
   Lisää aikuiselle ominaisuus auto (String). 
 * 
 * Jere Liikka 24.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Kavelee");
        }
        
    }
}
