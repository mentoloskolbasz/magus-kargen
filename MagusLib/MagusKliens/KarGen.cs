using MagusLib;
using MagusLib.Ertek;
using MagusLib.KarakterKeszites;
using MagusLib.Kepzettsegek;
using MagusLib.Kepzettsegek.Elasjatitott;
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
        protected KorAlapertekModosito korAlapertekModosito = new KorAlapertekModosito();
        protected List<System.Windows.Forms.TextBox> mezok;
        protected ToolTip toolTip = new ToolTip();
        protected List<KeyValuePair<string, NumericUpDown>> kepessegPontok;
        protected Hatarozok hatarozok = Hatarozok.Instance;

        protected void modositokFrissitese()
        {

            try
            {
                mezok.ForEach(mezo =>
                 {
                     mezo.BackColor = Color.FromKnownColor(KnownColor.Control);
                     mezo.ForeColor = Color.Black;
                 });

                korAlapertekModosito.Karakter = karakter;
                fieldEroKorModosito.Text = korAlapertekModosito.Ero.ToString();
                fieldGyorsasagKorModosito.Text = korAlapertekModosito.Gyorsasag.ToString();
                fieldUgyessegKorModosito.Text = korAlapertekModosito.Ugyesseg.ToString();
                fieldAllokepessegKorModosito.Text = korAlapertekModosito.Allokepesseg.ToString();
                fieldEgeszsegKorModosito.Text = korAlapertekModosito.Egeszseg.ToString();
                fieldSzepsegKorModosito.Text = korAlapertekModosito.Szepseg.ToString();
                fieldKarakterSzint.Text = karakter.Szint.Szint.ToString();
            }
            catch (NemMegfeleloKorKivetel)
            {
                /*fieldEroKorModosito.Text = "KOR!";
                fieldEroKorModosito.ForeColor = Color.Yellow;
                fieldEroKorModosito.BackColor = Color.Black;*/

                mezok.ForEach(mezo =>
                {
                    mezo.Text = "KOR!";
                    mezo.BackColor = Color.Black;
                    mezo.ForeColor = Color.Yellow;
                });
            }
        }
        public KarGen()
        {

            InitializeComponent();

            mezok = new List<TextBox> { fieldEroKorModosito, fieldGyorsasagKorModosito, fieldAllokepessegKorModosito, fieldUgyessegKorModosito, fieldEgeszsegKorModosito, fieldSzepsegKorModosito };

            fieldKor.Maximum = int.MaxValue;

            this.fajValasztoBox.DataSource = Enum.GetValues(typeof(JatszhatoFaj));

            this.nemValasztoBox.DataSource = Enum.GetValues(typeof(KarakterNeme));

            var iskolak = Enum.GetValues(typeof(Iskola)).Cast<Iskola>().Select(isk => isk.ToString()).ToList();

            iskolak.Insert(0, "NINCS");

            this.psziIskolaBox.DataSource = iskolak;

            //this.psziIskolaBox.DataSource = Enum.GetValues(typeof(Iskola));

            this.psziFokaBox.DataSource = Enum.GetValues(typeof(KepzettsegFoka));

            psziFrissites();


            #region DataBinding-ok

            kepessegPontok = new List<KeyValuePair<string, NumericUpDown>>()
            {
                new KeyValuePair<string, NumericUpDown>("Ero", fieldEro),
                new KeyValuePair<string, NumericUpDown>("Gyorsasag", fieldGyors),
                new KeyValuePair<string, NumericUpDown>("Ugyesseg", fieldUgyes),
                new KeyValuePair<string, NumericUpDown>("Allokepesseg", fieldAllo),
                new KeyValuePair<string, NumericUpDown>("Egeszseg", fieldEgesz),
                new KeyValuePair<string, NumericUpDown>("Szepseg", fieldSzep),
                new KeyValuePair<string, NumericUpDown>("Intelligencia", fieldInt),
                new KeyValuePair<string, NumericUpDown>("Akaratero", fieldAkarat),
                new KeyValuePair<string, NumericUpDown>("Asztral", fieldAsztral),
                new KeyValuePair<string, NumericUpDown>("Eszleles", fieldEszlel),
            };
            kepessegPontok.ForEach((kepesseg) => kepesseg.Value.DataBindings.Add(new Binding("Value", this.karakter, kepesseg.Key, false, DataSourceUpdateMode.OnPropertyChanged)));

            /*this.fieldEro.DataBindings.Add(new Binding("Value", this.karakter, "Ero", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldGyors.DataBindings.Add(new Binding("Value", this.karakter, "Gyorsasag", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldUgyes.DataBindings.Add(new Binding("Value", this.karakter, "Ugyesseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldAllo.DataBindings.Add(new Binding("Value", this.karakter, "Allokepesseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldEgesz.DataBindings.Add(new Binding("Value", this.karakter, "Egeszseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldSzep.DataBindings.Add(new Binding("Value", this.karakter, "Szepseg", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldInt.DataBindings.Add(new Binding("Value", this.karakter, "Intelligencia", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldAkarat.DataBindings.Add(new Binding("Value", this.karakter, "Akaratero", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldAsztral.DataBindings.Add(new Binding("Value", this.karakter, "Asztral", false, DataSourceUpdateMode.OnPropertyChanged));

            this.fieldEszlel.DataBindings.Add(new Binding("Value", this.karakter, "Eszleles", false, DataSourceUpdateMode.OnPropertyChanged));*/

            this.fieldKor.DataBindings.Add(new Binding("Value", this.karakter, "Kor", false, DataSourceUpdateMode.OnPropertyChanged));

            #endregion

            karakter.PropertyChanged += karakter_PropertyChanged;

            karakter.Faj = JatszhatoFaj.Ember;
            karakter.Nem = KarakterNeme.Férfi;
            karakter.Alkaszt = KarakterAlkaszt.Harcos;
            karakter.Kor = 30;

            //toolTip.SetToolTip(GeneraloBtn, "Mi a Fasz Van \n Gecc!");
            //Találati térképhez láthatatlan boxok feliratok! -->


            /*toolTip.AutoPopDelay = 1000000;
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(groupBoxFej, "Mi a Fasz Van \n Mi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van \nMi a Fasz Van");*/
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
                        fieldKorosztaly.BackColor = Color.FromKnownColor(KnownColor.Control);
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
            modositokFrissitese();
            harcertekFrissitese();
            osszKepessegpontFrissites();

        }

        //Harcértékek frissítése
        protected void harcertekFrissitese()
        {
            fieldCE.Text = hatarozok.celzoHatarozo.Hataroz(karakter).ToString();
            fieldKE.Text = hatarozok.kezdemenyezoHatarozo.Hataroz(karakter).ToString();
            fieldTE.Text = hatarozok.tamadoHatarozo.Hataroz(karakter).ToString();
            fieldVE.Text = hatarozok.vedoHatarozo.Hataroz(karakter).ToString();
            fieldMaxEP.Text = hatarozok.epHatarozo.Hataroz(karakter).ToString();
            fieldMaxFP.Text = hatarozok.fpHatarozo.Hataroz(karakter).ToString();

            var maxMana = hatarozok.mpHatarozo.Hataroz(karakter);

            fieldMaxManaPont.Text = maxMana.ToString();
            fieldAktualisMana.Text = (maxMana - fieldFelhasznaltMana.Value).ToString();
            fieldFelhasznaltMana.Maximum = maxMana;
            fieldFelhasznaltMana.Minimum = 0;
            psziFrissites();
        }

        protected void osszKepessegpontFrissites()
        {
            fieldOsszPontok.Text = kepessegPontok.Aggregate<KeyValuePair<string, NumericUpDown>, int>(0, (result, current) => result + karakter.GetKepessegPont(current.Key)).ToString();
        }

        protected void psziFrissites()
        {
            this.psziFokaBox.Visible = false;
            var pszi = (Pszi)this.karakter.Kepzettsegek.FirstOrDefault(kepzettseg => kepzettseg.Tipusa == KepzettsegTipusa.Pszi);
            if (pszi is null)
            {
                this.psziIskolaBox.Text = "NINCS";
            }
            else
            {
                if (this.psziIskolaBox.SelectedValue.ToString() == "Pyarron")
                {
                    this.psziFokaBox.Visible = true;
                }
                this.psziIskolaBox.Text = pszi.Iskola.ToString();
                this.psziFokaBox.Text = pszi.Foka.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            (new Szintlepes { Karakter = karakter }).ShowDialog();

        }

        private void fieldFelhasznaltMana_ValueChanged(object sender, EventArgs e)
        {
            harcertekFrissitese();
        }

        private void buttonIma_Click(object sender, EventArgs e)
        {
            fieldFelhasznaltMana.Value = 0;
        }

        private void psziIskolaBox_SelectedValueChanged(object sender, EventArgs e)
        {
            iskolaTorlese();
            if (this.psziIskolaBox.SelectedValue.ToString() != "NINCS")
            {
                iskolaHozzaadasa();
            }
            psziFrissites();
        }

        private void iskolaTorlese()
        {
            var pszi = this.karakter.Kepzettsegek.FirstOrDefault(kepzettseg => kepzettseg.Tipusa == KepzettsegTipusa.Pszi);
            if (!(pszi is null))
            {
                this.karakter.Kepzettsegek.Remove(pszi);
            }
        }

        private void iskolaHozzaadasa()
        {
            var iskola = (Iskola)Enum.Parse(typeof(Iskola), psziIskolaBox.SelectedValue.ToString());
            var fok = KepzettsegFoka.Mester;
            if (iskola == Iskola.Pyarron)
            {
                fok = (KepzettsegFoka)Enum.Parse(typeof(KepzettsegFoka), psziFokaBox.SelectedValue.ToString());
            }
            this.karakter.Kepzettsegek.AddFirst(new Pszi { Iskola = iskola, Foka = fok });
        }

        private void psziFokaBox_SelectedValueChanged(object sender, EventArgs e)
        {
            iskolaTorlese();

            iskolaHozzaadasa();

            psziFrissites();
        }
    }
}
