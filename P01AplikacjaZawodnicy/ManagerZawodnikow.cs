using P04BibliotekaPolaczenieZBaza;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace P01AplikacjaZawodnicy
{
    enum SposobPolaczenia
    {
        BazaDanych,
        Plik
    }
    internal class ManagerZawodnikow
    {
        private string url;
        private string connString;
        private Zawodnik[] tablicaZawodnikow;
        private const string naglowek = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga";
        Zawodnik[] zawodnicyKraju;
        SposobPolaczenia sposobPolaczenia;

        /// <summary>
        /// Tworzy nowy menager zawodników zgodnie z wybranym sposoblem połączenia
        /// </summary>
        /// <param name="sposobPolaczenia">Baza danych lub plik</param>
        /// <param name="parametrPolaczenia">Adres polaczenia do bazy lub adres pliku</param>
        /// <exception cref="Exception"></exception>
        public ManagerZawodnikow(SposobPolaczenia sposobPolaczenia, string parametrPolaczenia)
        {
            this.sposobPolaczenia = sposobPolaczenia;
            if (sposobPolaczenia == SposobPolaczenia.Plik)
                url = parametrPolaczenia;
            else if(sposobPolaczenia == SposobPolaczenia.BazaDanych)
                    connString = parametrPolaczenia;
            else
                throw new Exception("nieznany sposób polaczenia");
        }

        public Zawodnik[] TablicaZawodnikow
        {
            get { return tablicaZawodnikow; }
        }

        //public Zawodnik[] PodajZawodnikow()
        //{
        //    return tablicaZawodnikow;
        //}


        public void WczytajZawodnikow()
        {
            if (sposobPolaczenia == SposobPolaczenia.BazaDanych)
                wczytajZawodnikowZBazy();
            else if (sposobPolaczenia == SposobPolaczenia.Plik)
                wczytajZawodnikowZpliku();
            else
                throw new Exception("nieznany sposób polaczenia");
        }

        private void wczytajZawodnikowZBazy()
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            object[][] wynik = pzb.WykonajZapytanie("select * from zawodnicy");

            Zawodnik[] tab = new Zawodnik[wynik.Length];
            int i = 0;
            foreach (var tablicaKomorek in wynik)
            {
                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = (int)tablicaKomorek[0];

                if (tablicaKomorek[1] != DBNull.Value)
                    z.Id_trenera = (int)tablicaKomorek[1];

                z.Imie = (string)tablicaKomorek[2];
                z.Nazwisko = (string)tablicaKomorek[3];
                z.Kraj = (string)tablicaKomorek[4];
                z.DataUrodzenia = (DateTime)tablicaKomorek[5];
                z.Wzrost = (int)tablicaKomorek[6];
                z.Waga = (int)tablicaKomorek[7];

                tab[i++]= z; 
            }


            // teraz musimy przerobć wynik na tablicaZawodnikow;
            tablicaZawodnikow = tab;
        }

        private void wczytajZawodnikowZpliku()
        {
            string dane = new WebClient().DownloadString(url);
            string[] separatory = { "\r\n" };
            string[] wiersze = dane.Split(separatory, StringSplitOptions.RemoveEmptyEntries);
            
            List<Zawodnik> zawodnicy = new List<Zawodnik>();

            for (int i = 1; i < wiersze.Length; i++) 
            {
                string[]komorki = wiersze[i].Split(';');
                Zawodnik z = new Zawodnik();

                z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                if (!string.IsNullOrEmpty(komorki[1]))
                    z.Id_trenera = Convert.ToInt32(komorki[1]);

                z.Imie = komorki[2];
                z.Nazwisko = komorki[3];
                z.Kraj = komorki[4];
                z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                z.Wzrost = Convert.ToInt32(komorki[6]);
                z.Waga = Convert.ToInt32(komorki[7]);
                zawodnicy.Add(z);               
            }
            tablicaZawodnikow = zawodnicy.ToArray();        
        }

      
        public string PodajLiczbeZawodnikowZDanegoKraju(string kraj)
        {
            List<Zawodnik> znalezieni = new List<Zawodnik>();
            Zawodnik[] tablicaZnalezionych;

            WczytajZawodnikow();

            for (int i = 0; i < tablicaZawodnikow.Length; i++)
                if (tablicaZawodnikow[i].Kraj == kraj.ToUpper())
                    znalezieni.Add(tablicaZawodnikow[i]);
            tablicaZnalezionych = znalezieni.ToArray();

            return (tablicaZnalezionych.Length).ToString();
        }

        public GrupaKraju[] PodajSredniWzrostZawodnikowDlaKazdegoKraju()
        {
            WczytajZawodnikow();
            List<string> kraje = new List<string>();    
            kraje.Add(tablicaZawodnikow[0].Kraj);
            string[] tablicaKrajow;

            for (int i = 1; i < tablicaZawodnikow.Length; i++)
            {
                if (!kraje.Contains(tablicaZawodnikow[i].Kraj))
                    kraje.Add(tablicaZawodnikow[i].Kraj);
            }
            tablicaKrajow= kraje.ToArray();



            List<GrupaKraju> grupy = new List<GrupaKraju>();
            for (int i = 0; i < tablicaKrajow.Length; i++)
            {
                double sumaWzrostu = 0;
                int liczbaZawodnikow = 0;
                for (int j = 0; j < tablicaZawodnikow.Length; j++)
                {
                    if (tablicaKrajow[i] == tablicaZawodnikow[j].Kraj)
                    {
                        sumaWzrostu += tablicaZawodnikow[j].Wzrost;
                        liczbaZawodnikow++;
                    }
                }

                double sredni = Math.Round((sumaWzrostu / liczbaZawodnikow), 2);
                GrupaKraju gk = new GrupaKraju();
                gk.Kraj = tablicaKrajow[i];
                gk.SredniWzrost = sredni;
                grupy.Add(gk);
                //sb.AppendLine("Dla " + tablicaKrajow[i] + " średni wzrost zawodników to " + sredni);
            }
            
            return grupy.ToArray();
            
        }

        public void ZnajdzZawodnikow(string kraj)
        {
            WczytajZawodnikow();
            List<Zawodnik> znalezieni = new List<Zawodnik>();
            

            for (int i = 0; i < tablicaZawodnikow.Length; i++)
            {
                if(kraj.ToLower() == tablicaZawodnikow[i].Kraj.ToLower())
                    znalezieni.Add(tablicaZawodnikow[i]);
            }
            zawodnicyKraju = znalezieni.ToArray();
        }

        public void ZapiszPlik(string sciezka)
        {
            StringBuilder sb = new StringBuilder(naglowek + Environment.NewLine);
            
                foreach(var w in zawodnicyKraju) 
                {
                    sb.AppendLine(
                        $"{w.Id_zawodnika};{w.Id_trenera};{w.Imie}" +
                        $"{w.Nazwisko};{w.Kraj};{w.DataUrodzenia.ToString("yyyy-MM-dd")};" +
                        $"{w.Wzrost};{w.Waga}"
                        );
                }

            File.WriteAllText(sciezka, sb.ToString());                                                         
        }
    }
}
