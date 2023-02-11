using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PolaczenieZBaza
{
    internal class PolaczenieZBaza
    {
        private string connString;

        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }

        public object[][] WykonajZapytanie(string sql)
        {

        }


    }
}
