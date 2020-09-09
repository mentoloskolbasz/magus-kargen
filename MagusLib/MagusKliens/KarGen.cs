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
            // this.textBox3.DataBindings.Add(new Binding("Text", this.karakter, "Nev", false, DataSourceUpdateMode.OnPropertyChanged));
            this.fieldEro.DataBindings.Add(new Binding("Value", this.karakter, "Ero", false, DataSourceUpdateMode.OnPropertyChanged));
            

        }


      
    }
}
