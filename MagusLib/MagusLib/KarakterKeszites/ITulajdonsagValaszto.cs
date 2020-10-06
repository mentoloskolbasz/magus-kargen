using System;
using System.Collections.Generic;
using System.Text;

namespace MagusLib.KarakterKeszites
{
    public interface ITulajdonsagValaszto<Ttulajdonsag>
    {
        Ttulajdonsag[] Felsorolas(IKarakter karakter);
        Ttulajdonsag Valaszt(IKarakter karakter);
    }
}
