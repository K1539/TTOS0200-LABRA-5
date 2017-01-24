/*
 * Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy.
 * Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.
 * 
 * Jere Liikka 23.1.2017
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
            Jaakaappi jaakaappi = new Jaakaappi();
            Console.Write("lisätäänkö lihaa ");
            string vastaus = Console.ReadLine();
            if (vastaus == "yes")
            {
                Console.WriteLine("Kuinka monta kiloa? (1, 2, 3... > ");
                int numero = int.Parse(Console.ReadLine());
                for (int i = 0; i < numero; i++)
                {
                    Jaakaappi.LisaaLihaa();
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Lisataanko maitoa? (yes / no) > ");
            vastaus = Console.ReadLine();
            if (vastaus == "yes")
            {
                Console.WriteLine("Kuinka monta litraa? (1, 2, 3... > ");
                int numero = int.Parse(Console.ReadLine());
                for (int i = 0; i < numero; i++)
                {
                    Jaakaappi.LisaaMaitoa();
                }

            }
            


        }
    }
}
