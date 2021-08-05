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
        public IKarakter Karakter
        {
            set
            {
                karakter = value;
                harcertekFrissitese();
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
            uint hmPerSzint = Allandok.HM_PER_SZINT[karakter.Alkaszt];
            KotelezoHM kotelezok = Allandok.KOTELEZO_HM_PER_SZINT[karakter.Alkaszt](karakter);
            hmPerSzint -= kotelezok.levonando;
            fieldKEKotelezo.Text = kotelezok.kezdemenyezoErtek.ToString();
            fieldTEKotelezo.Text = kotelezok.tamadoErtek.ToString();
            fieldVEKotelezo.Text = kotelezok.vedoErtek.ToString();
            fieldCEKotelezo.Text = kotelezok.celzoErtek.ToString();

            fieldOszthatoHM.Text = hmPerSzint.ToString();

        }
    }
}
