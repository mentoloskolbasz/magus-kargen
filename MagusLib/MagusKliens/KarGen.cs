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
                       
            InitializeComponent();
            // TODO: Kitirölni és átírni kontrollra. ez egy teszt
            karakter.Faj = JatszhatoFaj.Ember;

            // this.textBox3.DataBindings.Add(new Binding("Text", this.karakter, "Nev", false, DataSourceUpdateMode.OnPropertyChanged));
            this.fieldEro.DataBindings.Add(new Binding("Value", this.karakter, "Ero", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldGyors.DataBindings.Add(new Binding("Value", this.karakter, "Gyorsasag", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldUgyes.DataBindings.Add(new Binding("Value", this.karakter, "Ugyesseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldAllo.DataBindings.Add(new Binding("Value", this.karakter, "Allokepesseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldEgesz.DataBindings.Add(new Binding("Value", this.karakter, "Egeszseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldSzep.DataBindings.Add(new Binding("Value", this.karakter, "Szepseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldInt.DataBindings.Add(new Binding("Value", this.karakter, "Intelligencia", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldAkarat.DataBindings.Add(new Binding("Value", this.karakter, "Akaratero", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldAsztral.DataBindings.Add(new Binding("Value", this.karakter, "Asztral", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldEszlel.DataBindings.Add(new Binding("Value", this.karakter, "Eszleles", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void GeneraloBtn_Click(object sender, EventArgs e)
        {
            IGeneralo generalo = new HarcertekGeneralo();
            generalo.Generalas(karakter);
        }
    }
}
