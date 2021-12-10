using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib
{
    public class AlapKepessegGeneralo : AbsztraktGeneralo
    {
        public AlapKepessegGeneralo()
        {
            #region Erő
            ertekadok = karakter =>
            {

                
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.ERO.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.ERO_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Ero =  (kaszt() + faj);
            };
            #endregion

            #region Gyorsaság
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.GYORSASAG.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.GYORSASAG_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Gyorsasag = (kaszt() + faj);
            };
            #endregion

            #region Ügyesség
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.UGYESSEG.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.UGYESSEG_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Ugyesseg = (kaszt() + faj);
            };
            #endregion

            #region Állóképesség
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.ALLOKEPESSEG.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.ALLOKEPESSEG_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Allokepesseg = (kaszt() + faj);
            };
            #endregion

            #region Egészség
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.EGESZSEG.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.EGESZSEG_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Egeszseg = kaszt() + faj;
            };
            #endregion

            #region Szépség
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.SZEPSEG.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.SZEPSEG_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Szepseg = kaszt() + faj;
            };
            #endregion

            #region Intelligencia
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.INTELLIGENCIA.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.INTELLIGENCIA_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Intelligencia = kaszt() + faj;
            };
            #endregion

            #region Akaraterő
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.AKARATERO.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.AKARATERO_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Akaratero = kaszt() + faj;
            };
            #endregion

            #region Asztrál
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.ASZTRAL.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.ASZTRAL_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Asztral = kaszt() + faj;
            };
            #endregion

            #region Észlelés
            ertekadok += karakter =>
            {
                Func<int> kaszt;
                if (!KarakterKeszites.Allandok.ESZLELES.TryGetValue(karakter.Alkaszt, out kaszt))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                int faj;
                if (!KarakterKeszites.Allandok.ESZLELES_FAJ.TryGetValue(karakter.Faj, out faj))
                {
                    throw new NemDefinialtErtekKivetel();
                }
                karakter.Eszleles = kaszt() + faj;
            };
            #endregion
        }

    }
}
