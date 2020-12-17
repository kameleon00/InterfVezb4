using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb4
{
    class Korpa : IKupovina
    {
        private Artikal[] niz;
        private int brArtikala = 0;

        public Korpa (int bra)
        {
            niz = new Artikal[bra];
        }

        float IKupovina.ukupnaCena()
        {
            float ukupnaCena = 0;
            foreach (Artikal a in niz)
            {
                if (a != null)
                    ukupnaCena += a.prodajnaCena();
            }
            return ukupnaCena;
        }
        void IKupovina.dodajArtikal(Artikal a)
        {
            niz[brArtikala++] = a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sadrzaj korpe: " + "\n");
            foreach (Artikal a in niz)
            {
                if (a != null)
                    sb.AppendLine(a.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
