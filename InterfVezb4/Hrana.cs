using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb4
{
    class Hrana : Artikal
    {
        protected float preostaliRokUpotrebe;

        public Hrana (string naz, int cn, float pru) : base (naz, cn)
        {
            preostaliRokUpotrebe = pru;
        }
        public override float prodajnaCena()
        {
            if(preostaliRokUpotrebe < 10)
                return cena * 0.6f;
            else
                return base.prodajnaCena();
        }
        public override string ToString()
        {
            return base.ToString() + "Preostali rok upotrebe je: " + preostaliRokUpotrebe + " dana.";
        }
    }
}
