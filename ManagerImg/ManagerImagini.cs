//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NivelAccesDate;
using LibrarieModele;

namespace ManagerImg
{
    public class ManagerImagini
    {
       
            public static List<Imagine> listaImagini = new List<Imagine>();

            public static void addImagine(Imagine img)
            {
                listaImagini.Add(img);
            }

            public static void removeImagine(Imagine img)
            {
                listaImagini.Remove(img);
            }

            public static List<Imagine> getImagini()
            {
                return listaImagini;
            }

        /// <summary>
        /// ////////////FISIER////////////////
        /// </summary>
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareImagini GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    //case "bin":
                    //    return new AdministrareMasiniBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareImaginiText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\ImaginiSalvate.txt");
                }
            }

            return null;
        }

        public static void actualizareMasini()
        {
            int ind = 0;
            foreach (Imagine m in listaImagini)
            {
                ind++;
                m.setIdMasina(ind);
            }
        }
    }
    
}
