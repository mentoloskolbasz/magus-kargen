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
                if (Allandok.CE_TILTOTT.Contains(karakter.Alkaszt))
                {
                    fieldCESzintlepes.Enabled = false;
                    fieldCESzintlepes.Value = 0;
                }
            }
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

            if (maradekHmPerSzintSzamolo != 0)
            {
                return;
            }
            //Elfogadás
            var szintlepesArg = new Szintek.Argumentumok
            {

                keSzint = (int)kotelezok.kezdemenyezoErtek + Decimal.ToInt32(fieldKESzintlepes.Value),
                teSzint = (int)kotelezok.tamadoErtek + Decimal.ToInt32(fieldTESzintlepes.Value),
                veSzint = (int)kotelezok.vedoErtek + Decimal.ToInt32(fieldVESzintlepes.Value),
                ceSzint = (int)kotelezok.celzoErtek + Decimal.ToInt32(fieldCESzintlepes.Value),
                fpSzint = Decimal.ToInt32(fieldFpPerSzint.Value)
            };
            karakter.Szint.Lepes(szintlepesArg);
            hmPerSzint = 0;
            fieldSzint.Text = karakter.Szint.Szint.ToString();
            szintLepoFuggveny();




        }

        private void Szintlepes_Load(object sender, EventArgs e)
        {
            szintLepoFuggveny();
        }

        private void szintLepoFuggveny()
        {
            hmPerSzint = Allandok.HM_PER_SZINT[karakter.Alkaszt];
            kotelezok = Allandok.KOTELEZO_HM_PER_SZINT[karakter.Alkaszt](karakter);
            fieldFpPerSzint.Value = Allandok.FP_PER_SZINT[karakter.Alkaszt]();
           // fieldManaPerSzint.Value = Allandok.MANA_PER_SZINT[karakter.Alkaszt]();
            mezoFrissites();

            
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

        private void mezoFrissites()
        {
            fieldKEKotelezo.Text = kotelezok.kezdemenyezoErtek.ToString();
            fieldTEKotelezo.Text = kotelezok.tamadoErtek.ToString();
            fieldVEKotelezo.Text = kotelezok.vedoErtek.ToString();
            fieldCEKotelezo.Text = kotelezok.celzoErtek.ToString();
            fieldOszthatoHM.Text = maradekHmPerSzintSzamolo.ToString();
            fieldSzint.Text = karakter.Szint.Szint.ToString();
            harcertekFrissitese();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (karakter.Szint.Szint < 1)
            {
                return;
            }
            karakter.Szint.VisszaLepes(1);
            szintLepoFuggveny();
        }
    }
}
