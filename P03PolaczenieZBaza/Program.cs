using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PolaczenieZBaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=.;Initial Catalog=Zawodnicy;User ID=sa;Password=alx";

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);

            object[][] wynik=  pzb.WykonajZapytanie("select * from miasta");

            foreach (var wiersz in wynik)
            {
                string s = string.Join(" ", wiersz);
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
