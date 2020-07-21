using MagusLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagusKliens
{
    public partial class KarGen : Form
    {

        protected IKarakter karakter = new KarakterFigyelo();
        public KarGen()
        {
            karakter.Ero = 7;
            karakter.Nev = "Kocsog";
            InitializeComponent();
            this.textBox3.DataBindings.Add(new Binding("Text", this.karakter, "Nev", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // karakter.Ero = (uint)(new Random()).Next(5, 16);
            karakter.Nev = "Valami más";
        }

        
    }
}
