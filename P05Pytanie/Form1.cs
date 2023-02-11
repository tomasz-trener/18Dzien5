using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05Pytanie
{
    public partial class Form1 : Form
    {
        ManagerMemory mm;
        public Form1()
        {
            InitializeComponent();
            mm = new ManagerMemory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int[] tab= mm.Liczby;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] tab = mm.Liczby;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] tab = mm.Liczby;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] tab = mm.Liczby;
        }
    }
}
