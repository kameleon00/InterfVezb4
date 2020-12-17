using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb4
{
    public abstract class Artikal
    {
        protected string naziv;
        protected int cena;

        public Artikal (string naz, int cn)
        {
            naziv = naz;
            cena = cn;
        }
        public virtual float prodajnaCena()
        {
            return cena;
        }

        public override string ToString()
        {
            return "Naziv: " + naziv + " Cena: " + cena + " RSD ";
        }
    }
}
