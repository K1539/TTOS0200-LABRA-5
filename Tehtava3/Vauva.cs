/*
 *  Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. 
 *  
    Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". 

    Lisää vauvalle ominaisuus vaippa (String).
*
* Jere Liikka 23.1.2017
* */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Konttaa");
        }
    }
}
