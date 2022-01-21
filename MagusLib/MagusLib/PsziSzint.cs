using System;
using System.Collections.Generic;
using System.Text;
using MagusLib.Kepzettsegek;
using MagusLib.Kepzettsegek.Elasjatitott;


namespace MagusLib
{
    public class PsziSzint
    {
        private IPszi aktualisIskola;
        private LinkedList<IPszi> psziSzintek = new LinkedList<IPszi>();

        public void SzintLepes()
        {
            
        }
        public void SzintVisszaLepes(int szintek = 1)
        {

        }

        public IPszi AktualisIskola
        {
            get
            {
                return aktualisIskola;
            }
            set
            {
                aktualisIskola = value;
            }
        }
    }
}
