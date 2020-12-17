using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb4
{
    class Pice : Artikal
    {
        protected float prAlkohola;

        public Pice (string naz, float prA, int cn) : base (naz, cn)
        {
            prAlkohola = prA;
        }

        public override float prodajnaCena()
        {
            return (1 + prAlkohola / 100f) * cena;
        }

        public override string ToString()
        {
            return base.ToString() + "Procenat alkoholA iznosi: " + prAlkohola + " ";
        }
    }
}
