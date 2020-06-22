//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using NivelAccesDate;

namespace ManagerImg
{
    public class ManagerImaginiTranzactii
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
                        return new AdministrareImaginiText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\ImaginiTranzactiiSalvate.txt");
                }
            }

            return null;
        }
    }
}
