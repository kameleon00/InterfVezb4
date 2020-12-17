using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfVezb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikal a1 = new Pice( "Pivo", 45, 5f);
            Artikal a2 = new Hrana("Meso", 55, 1);
            Artikal a3 = new Hrana("Celer", 60, 100);

            IKupovina k = new Korpa(10);

            k.dodajArtikal(a1);
            k.dodajArtikal(a2);
            k.dodajArtikal(a3);

            Console.WriteLine(k);
            Console.WriteLine("Ukupna cena proizvoda je: {0}", k.ukupnaCena());

            Console.ReadKey();
        }
    }
}
