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

        protected IKarakter karakter = new Karakter();
        public KarGen()
        {
            karakter.Ero = 7;
            InitializeComponent();
            this.textBox1.DataBindings.Add("Text", this.karakter, "Ero");
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            karakter.Ero = (uint)(new Random()).Next(5, 16);
            this.textBox1.Update();
            this.textBox2.Text = karakter.Ero.ToString();
        }
    }
}
