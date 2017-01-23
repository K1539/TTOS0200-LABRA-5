using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Jaakaappi
    {
        public bool Liha { get; set; }
        public double LihaaKiloina { get; set; }
        public bool Maito { get; set; }
        public double MaitoaLitroina { get; set; }
        public Jaakaappi()
        {

        }
        public Jaakaappi(bool liha, double lihaakiloina, bool maito, double maitoalitroina)
        {
            Liha = liha;
            LihaaKiloina = lihaakiloina;
            Maito = maito;
            MaitoaLitroina = maitoalitroina;
        }
    }
}
