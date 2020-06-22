//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareImagini
    {
        void AddImagine(Imagine img);
        Imagine[] GetImagine(out int nrImagini);

        Imagine GetImagineByIndex(int index);
    }
}
