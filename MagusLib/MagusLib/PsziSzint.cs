using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MagusLib.Kepzettsegek;
using MagusLib.Kepzettsegek.Elasjatitott;


namespace MagusLib
{
    public class PsziSzint : AbsztraktSzint , IEnumerable<IPszi>
    {
        private IPszi aktualisIskola;
        private LinkedList<IPszi> psziSzintek = new LinkedList<IPszi>();

        public void SzintLepes()
        {
            if (aktualisIskola == null)
            {
                return;
            }
            psziSzintek.AddLast(new Pszi { Iskola = aktualisIskola.Iskola, Foka = aktualisIskola.Foka });
            valtozasEsemeny();
        }
        public void SzintVisszaLepes(int szintek = 1)
        {
            for (int i = 0; (psziSzintek.Count > 0) && (i < szintek); i++)
            {
                psziSzintek.RemoveLast();
            }
            valtozasEsemeny();
        }

        public IEnumerator<IPszi> GetEnumerator()
        {
            return psziSzintek.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return psziSzintek.GetEnumerator();
        }

        public IPszi AktualisIskola
        {
            get
            {
                return aktualisIskola;
            }
            set
            {
                var ujIskola = (aktualisIskola != null) && (aktualisIskola.Iskola != value.Iskola);

                if ((psziSzintek.Count > 0) && ujIskola)
                {
                    throw new NemEngedelyezettPsziValtas();
                }
                if (ujIskola)
                {
                    psziSzintek = new LinkedList<IPszi>();
                   
                }
                aktualisIskola = value;
                valtozasEsemeny();
            }
        }

    }
}
