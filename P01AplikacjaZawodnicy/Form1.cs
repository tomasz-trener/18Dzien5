using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {       
            mz.WczytajZawodnikow();
            // tutaj chce miec tych zawodnikach
            Zawodnik[] zawodnicy = mz.TablicaZawodnikow;        
            lbDane.Items.Clear();
            //for (int i = 0; i < zawodnicy.Length; i++)
            //{
            //    lbDane.Items.Add(zawodnicy[i].Imie + " " + zawodnicy[i].Nazwisko);
            //}
            foreach (var z in zawodnicy)
                lbDane.Items.Add(z.Imie + " " + z.Nazwisko);
        }

        private void btnSrednieWzrosty_Click(object sender, EventArgs e)
        {
            GrupaKraju[] grupy= mz.PodajSredniWzrostZawodnikowDlaKazdegoKraju();
            FrmGrupyKrajow frmGrupyKrajow = new FrmGrupyKrajow(grupy);
            frmGrupyKrajow.Show();
        }

        private void rbPlik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBaza.Checked)
                mz = new ManagerZawodnikow(SposobPolaczenia.BazaDanych, txtParamPolaczenia.Text);
            else
                mz = new ManagerZawodnikow(SposobPolaczenia.Plik, txtParamPolaczenia.Text);
        }
    }
}
