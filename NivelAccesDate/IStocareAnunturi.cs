//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareAnunturi
    {
        void AddAnunt(Anunt anunt);
        Anunt[] GetAnunt(out int nrAnunturi);

        Anunt GetAnuntByIndex(int index);
    }
}
