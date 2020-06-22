//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerM
{
    public class ManagerImagini
    {
        public static List<string> listaImagini = new List<string>();

        public static void addImagine(string img)
        {
            listaImagini.Add(img);
        }

        public static void removeImagine(string img)
        {
            listaImagini.Remove(img);
        }
    }
}
