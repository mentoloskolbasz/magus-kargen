using MagusLib;
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
    public partial class Szintlepes : Form
    {
        protected Hatarozok hatarozok = Hatarozok.Instance;
        private IKarakter karakter;
        private uint hmPerSzint = 0;
        private KotelezoHM kotelezok;
        public IKarakter Karakter
        {
            set
            {
                karakter = value;
                harcertekFrissitese();
            }
        }
        private bool folyamatban
        {
            get => hmPerSzint > 0;
        }

        public Szintlepes()
        {
            InitializeComponent();

        }

        protected void harcertekFrissitese()
        {
            fieldCEAlap.Text = hatarozok.celzoHatarozo.Hataroz(karakter).ToString();
            fieldKEAlap.Text = hatarozok.kezdemenyezoHatarozo.Hataroz(karakter).ToString();
            fieldTEAlap.Text = hatarozok.tamadoHatarozo.Hataroz(karakter).ToString();
            fieldVEAlap.Text = hatarozok.vedoHatarozo.Hataroz(karakter).ToString();

        }

        private void buttonLepes_Click(object sender, EventArgs e)
        {
            if (folyamatban)
            {
                //Elfogadás
            }
            else
            {
                szintLepoFuggveny();
            }
            

        }

        private void Szintlepes_Load(object sender, EventArgs e)
        {
            szintLepoFuggveny();
        }

        private void szintLepoFuggveny()
        {
            hmPerSzint = Allandok.HM_PER_SZINT[karakter.Alkaszt];
            kotelezok = Allandok.KOTELEZO_HM_PER_SZINT[karakter.Alkaszt](karakter);
            fieldKEKotelezo.Text = kotelezok.kezdemenyezoErtek.ToString();
            fieldTEKotelezo.Text = kotelezok.tamadoErtek.ToString();
            fieldVEKotelezo.Text = kotelezok.vedoErtek.ToString();
            fieldCEKotelezo.Text = kotelezok.celzoErtek.ToString();

            fieldOszthatoHM.Text = maradekHmPerSzintSzamolo.ToString();

            buttonLepes.Text = "Elfogadás";
        }

        private int maradekHmPerSzintSzamolo
        {
            get => (int)hmPerSzint - (int)kotelezok.levonando - (int)(fieldKESzintlepes.Value + fieldTESzintlepes.Value + fieldVESzintlepes.Value + fieldCESzintlepes.Value);
        }

        private void fieldKNumUpDown_Validating(object sender, EventArgs e)
        {
            var mezo = (NumericUpDown)sender;
            if (mezo.Value < 0)
            {
                mezo.Value = 0;
            }
            if (maradekHmPerSzintSzamolo < 0)
            {
                mezo.Value += maradekHmPerSzintSzamolo;
            }
            fieldOszthatoHM.Text = maradekHmPerSzintSzamolo.ToString();
        }

    }
}
