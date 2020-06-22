//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareTranzactii
    {
        void AddTranzactie(Tranzactie tranzactie);
        Tranzactie[] GetTranzactie(out int nrTranzactii);

        Tranzactie GetTranzactieByIndex(int index);
    }
}
