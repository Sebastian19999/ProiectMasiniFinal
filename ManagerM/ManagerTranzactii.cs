//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using NivelAccesDate;

namespace ManagerM
{
    public class ManagerTranzactii
    {
        public static List<Tranzactie> listaTranzactii = new List<Tranzactie>();

        public static void addTranzactie(Tranzactie masina)
        {
            listaTranzactii.Add(masina);
        }

        public static List<Tranzactie> getTranzactii()
        {
            return listaTranzactii;
        }

        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareTranzactii GetAdministratorStocare()
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
                        return new AdministrareTranzactiiText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\TranzactiiSalvate.txt");
                }
            }

            return null;
        }
    }
}
