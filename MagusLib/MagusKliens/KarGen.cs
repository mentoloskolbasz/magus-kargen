using MagusKliens.Kiszolgalo;
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
        public KarGen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kommunikator = new MagusSzerverClient();
            textBox1.Text = kommunikator.GetData(15);
        }
    }
}
