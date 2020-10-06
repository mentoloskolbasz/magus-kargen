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

        protected KarakterFigyelo karakter = new KarakterFigyelo();
        public KarGen()
        {

            InitializeComponent();

            this.karakter.Nem = KarakterNeme.Férfi;

            this.fajValasztoBox.DataSource = Enum.GetValues(typeof(JatszhatoFaj));

            this.kasztValasztoBox.DataSource = Enum.GetValues(typeof(KarakterKaszt));

            this.nemValasztoBox.DataSource = Enum.GetValues(typeof(KarakterNeme));

            this.fajValasztoBox.DataBindings.Add(new Binding("SelectedItem", this.karakter, "Faj", false, DataSourceUpdateMode.OnPropertyChanged));

            this.nemValasztoBox.DataBindings.Add(new Binding("SelectedItem", this.karakter, "Nem", false, DataSourceUpdateMode.OnPropertyChanged));

            this.kasztValasztoBox.DataBindings.Add(new Binding("SelectedItem", this.karakter, "Kaszt", false, DataSourceUpdateMode.OnPropertyChanged));

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


            karakter.PropertyChanged += karakter_PropertyChanged;

            karakter.Faj = JatszhatoFaj.Ember;
            karakter.Kaszt = KarakterKaszt.Harcos;
            karakter.Alkaszt = KarakterAlkaszt.Amazon;

        }

        private void karakter_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Faj" || e.PropertyName == "Nem")
            {
                alkasztValasztoBox.DataSource = null;
                var ds = new AlkasztValaszto();
                alkasztValasztoBox.DataSource = ds.Felsorolas(karakter);
                karakter.Alkaszt = ds.Valaszt(karakter);
                alkasztValasztoBox.Enabled = true;
            }
        }

        private void GeneraloBtn_Click(object sender, EventArgs e)
        {
            IGeneralo generalo = new AlapKepessegGeneralo();
            generalo.Generalas(karakter);
        }

        private void kasztValasztoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            karakter.Kaszt = (KarakterKaszt)kasztValasztoBox.SelectedValue;
        }

        private void nemValasztoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            karakter.Nem = (KarakterNeme)nemValasztoBox.SelectedValue;
        }
    }
}
