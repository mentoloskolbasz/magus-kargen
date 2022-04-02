using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using MagusLib.Kepzettsegek;
using MagusLib.Kepzettsegek.Elasjatitott;


namespace MagusLib
{
    [JsonConverter(typeof(PsziSzintKonverter))]
    public class PsziSzint : AbsztraktSzint, IEnumerable<IPszi>
    {
        private IPszi aktualisIskola;
        private LinkedList<IPszi> psziSzintek = new LinkedList<IPszi>();
        public int Szint { get => psziSzintek.Count; }
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
            for (int i = 0; (psziSzintek.Count > 1) && (i < szintek); i++)
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
                var ujIskola = (value != null) && ((aktualisIskola == null) || (aktualisIskola.Iskola != value.Iskola));
                var ujFok = (aktualisIskola != null) && (value != null) && (aktualisIskola.Iskola == value.Iskola) && (psziSzintek.Count == 1);
                if ((psziSzintek.Count > 1) && ujIskola)
                {
                    throw new NemEngedelyezettPsziValtas();
                }
                aktualisIskola = value;
                if (ujIskola || ujFok)
                {

                    psziSzintek = new LinkedList<IPszi>();
                    psziSzintek.AddLast(aktualisIskola);

                }
                if (value == null)
                {
                    psziSzintek = new LinkedList<IPszi>();
                }

                valtozasEsemeny();
            }
        }

    }
}
