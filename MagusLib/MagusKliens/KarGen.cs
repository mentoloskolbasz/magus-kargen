using MagusLib;
using MagusLib.Ertek;
using MagusLib.KarakterKeszites;
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

            
            this.fajValasztoBox.DataSource = Enum.GetValues(typeof(JatszhatoFaj));

            this.nemValasztoBox.DataSource = Enum.GetValues(typeof(KarakterNeme));


            #region DataBinding-ok
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

            this.fieldKor.DataBindings.Add(new Binding("Value", this.karakter, "Kor", false, DataSourceUpdateMode.OnPropertyChanged));

            #endregion

            karakter.PropertyChanged += karakter_PropertyChanged;

            karakter.Faj = JatszhatoFaj.Ember;
            karakter.Nem = KarakterNeme.Férfi;        

        }

        private void karakter_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Faj":
                case "Nem":
                    alkasztValasztoBox.DataSource = null;
                    var alkasztValaszto = new AlkasztValaszto();
                    alkasztValasztoBox.DataSource = alkasztValaszto.Felsorolas(karakter);
                    karakter.Alkaszt = alkasztValaszto.Valaszt(karakter);

                    fajValasztoBox.SelectedItem = karakter.Faj;
                    nemValasztoBox.SelectedItem = karakter.Nem;
                    break;
                case "Alkaszt":
                    fieldKaszt.Text = "";
                    var kasztValaszto = new KasztValaszto();
                    karakter.Kaszt = kasztValaszto.Valaszt(karakter);
                                        
                    vallasValasztoBox.DataSource = null;
                    var vallasValaszto = new VallasValaszto();
                    vallasValasztoBox.DataSource = vallasValaszto.Felsorolas(karakter);
                    karakter.Vallas = vallasValaszto.Valaszt(karakter);

                    alkasztValasztoBox.SelectedItem = karakter.Alkaszt;
                    break;
                case "Kaszt":
                    fieldKaszt.Text = karakter.Kaszt.ToString();
                    break;
                case "Vallas":
                    vallasValasztoBox.SelectedItem = karakter.Vallas;
                    break;
                case "Kor":
                    try
                    {
                        fieldKorosztaly.BackColor = Color.White;
                        fieldKorosztaly.ForeColor = Color.Black;
                        fieldKorosztaly.Text = (new KorHatarozo()).Hataroz(karakter).ToString();
                    }
                    catch (NemMegfeleloKorKivetel)
                    {
                        fieldKorosztaly.Text = "Rossz kor!";
                        fieldKorosztaly.ForeColor = Color.Yellow;
                        fieldKorosztaly.BackColor = Color.Black;
                    }                    
                    break;
                default:
                    break;
            }
            //Korosztály frissítés
            if (e.PropertyName != "Kor")
            {
                karakter.Kor = karakter.Kor;
            }
        }
        #region Bekötés FORMRA
        private void GeneraloBtn_Click(object sender, EventArgs e)
        {
            IGeneralo generalo = new AlapKepessegGeneralo();
            generalo.Generalas(karakter);
        }        

        private void nemValasztoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (nemValasztoBox.SelectedValue == null)
            {
                return;
            }
            karakter.Nem = (KarakterNeme)nemValasztoBox.SelectedValue;
        }

        private void fajValasztoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (fajValasztoBox.SelectedValue == null)
            {
                return;
            }
            karakter.Faj = (JatszhatoFaj)fajValasztoBox.SelectedValue;
        }
        
        private void alkasztValasztoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (alkasztValasztoBox.SelectedValue == null)
            {
                return;
            }
            karakter.Alkaszt = (KarakterAlkaszt)alkasztValasztoBox.SelectedValue;
        }

        private void vallasValasztoBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (vallasValasztoBox.SelectedValue == null)
            {
                return;
            }
            karakter.Vallas = (Vallas)vallasValasztoBox.SelectedValue;
        }
        #endregion
    }
}
