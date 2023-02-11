using P01AplikacjaZawodnicy.Properties;
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
    public partial class FrmMiasta : Form
    {
        public FrmMiasta(string connString)
        {
            InitializeComponent();

            ManagerMiast mm = new ManagerMiast(connString);
            mm.WczytajMiasta();

            foreach (var m in mm.TablicaMiast)
            {
                lbDane.Items.Add(m.Nazwa);
            }
        }
    }
}
