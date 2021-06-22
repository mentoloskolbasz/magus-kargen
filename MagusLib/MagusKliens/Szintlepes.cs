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
    }
}
