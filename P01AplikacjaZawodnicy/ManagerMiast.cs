using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaZawodnicy
{
    internal class ManagerMiast
    {

        private string connString;
        private Miasto[] tablicaMiast;


        public Miasto[] TablicaMiast
        {
            get{ return tablicaMiast; }
        }

        public ManagerMiast(string connString)
        {
            this.connString = connString;
        }


        public void WczytajMiasta()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            object[][] wynik = pzb.WykonajZapytanie("select id_miasta, SUBSTRING( nazwa_miasta,2,len(nazwa_miasta)-2) from miasta");

            Miasto[] tab = new Miasto[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Miasto m = new Miasto();
                m.Id = (int)wynik[i][0];
                m.Nazwa = (string)wynik[i][1];

                tab[i] = m;
            }

            tablicaMiast = tab;
        }

    }
}
