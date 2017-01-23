namespace JAMK.IT
{
    public class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string Rengaskoko { get; set; }

        public override string ToString()
        {
            return "Valmistaja: " + Valmistaja + " Malli:" + Malli + " rengas koko:" + Rengaskoko;
        }
    }
}
