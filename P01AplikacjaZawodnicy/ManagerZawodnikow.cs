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


namespace P01AplikacjaZawodnicy
{

    internal class ManagerZawodnikow
    {
        private const string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
        private Zawodnik[] tablicaZawodnikow;
        private const string naglowek = "id_zawodnika;id_trenera;imie;nazwisko;kraj;data urodzenia;wzrost;waga";
        Zawodnik[] zawodnicyKraju;
        public void WczytajZawodnikow()
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

        public string PodajSredniWzrostZawodnikowDlaKazdegoKraju()
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


            StringBuilder sb = new StringBuilder();
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
                sb.AppendLine("Dla " + tablicaKrajow[i] + " średni wzrost zawodników to " + sredni);
            }
            
            return sb.ToString();
            
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
