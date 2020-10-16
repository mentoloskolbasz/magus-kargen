using System;
using MagusLib;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.KarakterKeszites
{

    public class PapVallas
    {
        private static HashSet<Vallas> ARAB = new HashSet<Vallas>
        {
            Vallas.Doldzsah,
            Vallas.Dzsah,
            Vallas.Galradzsa
        };

        private static HashSet<Vallas> GORVIK = new HashSet<Vallas>
        {
            Vallas.Ranagol,           
        };


        public static HashSet<Vallas> ISTEN = new HashSet<Vallas>
        {
            Vallas.Adron,
            Vallas.Alborne,
            Vallas.Antoh,
            Vallas.Arel,
            Vallas.Domvik,
            Vallas.Kyel,
            Vallas.Orwella,            
            Vallas.Sogron,
            Vallas.Tharr,
        };
        // Metszet
        public static readonly Dictionary<KarakterNeme, HashSet<Vallas>> NEMESITO = new Dictionary<KarakterNeme, HashSet<Vallas>>()
        {
            { KarakterNeme.Nő, new HashSet<Vallas> {

            } },
            { KarakterNeme.Férfi, new HashSet<Vallas> {
                Vallas.Orwella,
            } },
        };
        // Unió
        public static readonly Dictionary<JatszhatoFaj, HashSet<Vallas>> FAJITO = new Dictionary<JatszhatoFaj, HashSet<Vallas>>()
        {
            { JatszhatoFaj.Dzsad, PapVallas.ARAB },
            { JatszhatoFaj.Dzsenn, PapVallas.ARAB},
            { JatszhatoFaj.Ember, PapVallas.GORVIK },
            { JatszhatoFaj.Wier, PapVallas.GORVIK },
            { JatszhatoFaj.Törpe, new HashSet<Vallas> {
                Vallas.Tooma,
                Vallas.Kadal
            }},
        };
        /* private static readonly Dictionary<KarakterAlkaszt, PapKasztAlkasztja[]> LISTA = new Dictionary<KarakterAlkaszt, PapKasztAlkasztja[]>()
         {
             { KarakterAlkaszt.Pap, new PapKasztAlkasztja[] {
                 PapKasztAlkasztja.Adron,
                 PapKasztAlkasztja.Antoh,
                 PapKasztAlkasztja.Arel,
                 PapKasztAlkasztja.Doldzsah,
                 PapKasztAlkasztja.Domvik,
                 PapKasztAlkasztja.Dzsah,
                 PapKasztAlkasztja.Galradzsa,
                 PapKasztAlkasztja.Kadal,
                 PapKasztAlkasztja.Kyel,
                 PapKasztAlkasztja.Orwella,
                 PapKasztAlkasztja.Ranagol,
                 PapKasztAlkasztja.Sogron,
                 PapKasztAlkasztja.Tharr,
                 PapKasztAlkasztja.Tooma,
             } },            
         };

         public PapKasztAlkasztja[] this[KarakterAlkaszt kaszt]
         {
             get => PapVallas.LISTA[kaszt];
         }*/
    }


}
