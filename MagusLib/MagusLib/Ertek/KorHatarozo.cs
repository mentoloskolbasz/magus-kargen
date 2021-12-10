using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MagusLib.Ertek
{
    public class KorHatarozo : IHatarozo<KarakterKorosztaly>
    {
        private class KorosztalyIntervallum
        {
            public int Tol { get; set; }
            public int Ig { get; set; }
            public KarakterKorosztaly Korosztaly { get; set; }
        }

        private static Dictionary<JatszhatoFaj, KorosztalyIntervallum[]> LISTA = new Dictionary<JatszhatoFaj, KorosztalyIntervallum[]>
        {
            {JatszhatoFaj.Ember,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=13, Ig= 16, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=17, Ig= 30, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=31, Ig= 42, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=43, Ig= 55, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=56, Ig= 75, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=76, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
             {JatszhatoFaj.Elf,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=30, Ig= 50, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=51, Ig= 1400, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=1401, Ig= 1600, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=1601, Ig= 1800, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=1801, Ig= 1900, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=1901, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
              {JatszhatoFaj.Félelf,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=16, Ig= 22, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=23, Ig= 110, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=111, Ig= 130, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=131, Ig= 150, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=151, Ig= 170, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=171, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
              {JatszhatoFaj.Törpe,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=25, Ig= 40, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=41, Ig= 350, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=351, Ig= 600, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=601, Ig= 680, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=681, Ig= 750, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=751, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
              {JatszhatoFaj.Ork,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=15, Ig= 19, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=20, Ig= 120, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=121, Ig= 200, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=201, Ig= 230, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=231, Ig= 260, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=261, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
               {JatszhatoFaj.Dzsad,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=13, Ig= 16, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=17, Ig= 30, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=31, Ig= 42, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=43, Ig= 55, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=56, Ig= 75, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=76, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },


               {JatszhatoFaj.Amund,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=15, Ig= 20, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=21, Ig= 49, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=50, Ig= 75, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=76, Ig= 99, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=100, Ig= 119, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=120, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
                {JatszhatoFaj.Dzsenn,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=18, Ig= 24, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=25, Ig= 114, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=115, Ig= 160, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=161, Ig= 199, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=200, Ig= 229, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=230, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
                {JatszhatoFaj.Gnóm,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=16, Ig= 20, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=21, Ig= 124, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=125, Ig= 170, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=171, Ig= 200, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=201, Ig= 210, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=211, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
                 {JatszhatoFaj.Goblin,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=16, Ig= 18, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=19, Ig= 110, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=111, Ig= 180, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=181, Ig= 200, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=201, Ig= 230, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=231, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
                  {JatszhatoFaj.Khal,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=5, Ig= 9, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=10, Ig= 24, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=25, Ig= 32, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=33, Ig= 40, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=41, Ig= 49, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=50, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },
                   {JatszhatoFaj.Wier,
               new KorosztalyIntervallum[]
               {
                new KorosztalyIntervallum {Tol=13, Ig= 16, Korosztaly = KarakterKorosztaly.Serdülő},

                new KorosztalyIntervallum {Tol=17, Ig= 30, Korosztaly = KarakterKorosztaly.Ifjú},

                new KorosztalyIntervallum {Tol=31, Ig= 42, Korosztaly = KarakterKorosztaly.Középkorú},

                new KorosztalyIntervallum {Tol=43, Ig= 55, Korosztaly = KarakterKorosztaly.Meglett},

                new KorosztalyIntervallum {Tol=56, Ig= 75, Korosztaly = KarakterKorosztaly.Idős},

                new KorosztalyIntervallum {Tol=76, Ig= int.MaxValue, Korosztaly = KarakterKorosztaly.Aggastyán},
                }
            },

        };

        public KarakterKorosztaly Hataroz(IKarakter karakter)
        {
            //throw new NotImplementedException();
            var intervallumLista = LISTA[karakter.Faj];
            var intervallum = Array.Find<KorosztalyIntervallum>(intervallumLista,
                elem => elem.Tol <= karakter.Kor && elem.Ig >= karakter.Kor
                );
            if (intervallum == null)
            {
                throw new NemMegfeleloKorKivetel();
            }
            return intervallum.Korosztaly;
        }
    }
}
