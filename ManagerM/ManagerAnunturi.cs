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
    public class ManagerAnunturi
    {
        public static List<Anunt> listaAnunturi = new List<Anunt>();

        public static void addAnunt(Anunt anunt)
        {
            listaAnunturi.Add(anunt);
        }

        public static void removeAnunt(Anunt anunt)
        {
            listaAnunturi.Remove(anunt);
        }

        public static Anunt getMasina(int id)
        {
            int ok = 0;
            Anunt rezultat = new Anunt();
            foreach (Anunt mas in listaAnunturi)
                if (mas.getIdMasina() == id)
                { ok = 1; rezultat = mas; break; }
            if (ok == 0)
            { Console.WriteLine("Id-ul este incorect... "); return null; }
            Console.WriteLine(rezultat.toString());
            return rezultat;
        }

        public static List<Anunt> getAnunturi()
        {
            return listaAnunturi;
        }

        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareAnunturi GetAdministratorStocare()
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
                        return new AdministratorAnunturiText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\AnunturiSalvate.txt");
                }
            }

            return null;
        }

        public static List<Anunt> CautareMasiniForms(string firma, string model, string culoare, string anFabricatie,
                                                    string numeVanzator, string numeCumparator, string data, string pret, string optiuni)
        {
            List<Anunt> listaMasiniCautate = new List<Anunt>(listaAnunturi);
            List<Anunt> copieListaMasiniCautate = new List<Anunt>(listaAnunturi);
            if (firma != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.firmaProp.Equals(firma)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (model != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.modelProp.Equals(model)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (culoare != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.culoareProp.Equals(culoare)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (anFabricatie != string.Empty)
            {
                int anf = Convert.ToInt32(anFabricatie);
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (masina.anFabricatie != anf)
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeVanzator != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.numeVanzator.Equals(numeVanzator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeCumparator != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.numeCumparator.Equals(numeCumparator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (data != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.dataTranzactie.Equals(data)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (pret != string.Empty)
            {
                double p = Convert.ToDouble(pret);
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (masina.pretProp != p)
                        copieListaMasiniCautate.Remove(masina);
                }
            }

            foreach (Anunt masC in copieListaMasiniCautate)
            {
                masC.nrCautari++;
            }


            return copieListaMasiniCautate;
        }


        public static List<Anunt> CautareMasiniFormsDate(string firma, string model, string culoare, string anFabricatie,
                                                    string numeVanzator, string numeCumparator, string data, string pret, string optiuni, string startDate, string stopDate)
        {

            string[] startDate1 = startDate.Split(' ');
            string[] startDate2 = startDate1[0].Split('/');

            string[] stopDate1 = stopDate.Split(' ');
            string[] stopDate2 = stopDate1[0].Split('/');

            List<Anunt> listaMasiniCautate = new List<Anunt>(listaAnunturi);
            List<Anunt> copieListaMasiniCautate = new List<Anunt>(listaAnunturi);
            if (firma != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.firmaProp.Equals(firma)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (model != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.modelProp.Equals(model)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (culoare != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.culoareProp.Equals(culoare)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (anFabricatie != string.Empty)
            {
                int anf = Convert.ToInt32(anFabricatie);
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (masina.anFabricatie != anf)
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeVanzator != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.numeVanzator.Equals(numeVanzator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeCumparator != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.numeCumparator.Equals(numeCumparator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (data != string.Empty)
            {
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (!(masina.dataTranzactie.Equals(data)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (pret != string.Empty)
            {
                double p = Convert.ToDouble(pret);
                foreach (Anunt masina in listaMasiniCautate)
                {
                    if (masina.pretProp != p)
                        copieListaMasiniCautate.Remove(masina);
                }
            }

            

            foreach (Anunt masina in listaMasiniCautate)
            {
                string[] dataCurenta = masina.dataActualizare.ToString().Split(' ');
                string[] dataCurentaFinal = dataCurenta[0].Split('/');
                int luna_min = Convert.ToInt32(startDate2[0]);
                int zi_min = Convert.ToInt32(startDate2[1]);
                int an_min = Convert.ToInt32(startDate2[2]);

                int luna_max = Convert.ToInt32(stopDate2[0]);
                int zi_max = Convert.ToInt32(stopDate2[1]);
                int an_max = Convert.ToInt32(stopDate2[2]);

                int luna_curenta = Convert.ToInt32(dataCurentaFinal[0]);
                int zi_curenta = Convert.ToInt32(dataCurentaFinal[1]);
                int an_curent = Convert.ToInt32(dataCurentaFinal[2]);

                if (!(luna_min <= luna_curenta && luna_curenta <= luna_max))
                    copieListaMasiniCautate.Remove(masina);
                else
                    if (!(zi_min <= zi_curenta && zi_curenta <= zi_max))
                    copieListaMasiniCautate.Remove(masina);
                else
                    if (!(an_min <= an_curent && an_curent <= an_max))
                    copieListaMasiniCautate.Remove(masina);
            }

            foreach (Anunt masC in copieListaMasiniCautate)
            {
                masC.nrCautari++;
            }

            return copieListaMasiniCautate;
        }

        public static List<Anunt> top3Masini()
        {
            Anunt[] masiniArr = listaAnunturi.ToArray();
            Anunt loc1 = masiniArr[0], loc2 = masiniArr[1], loc3 = masiniArr[2];
            int nr1 = -1, nr2 = -1, nr3 = -1;

            foreach (Anunt mas in listaAnunturi)
            {
                if (mas.nrCautari > nr1)
                {
                    loc2 = loc1;
                    loc3 = loc1;
                    nr1 = mas.nrCautari;
                    loc1 = mas;
                }
                else
                {
                    if (mas.nrCautari <= nr1 && mas.nrCautari > nr2)
                    {
                        loc3 = loc2;
                        nr2 = mas.nrCautari;
                        loc2 = mas;
                    }
                    else
                    {
                        if (mas.nrCautari <= nr1 && mas.nrCautari <= nr2 && mas.nrCautari > nr3)
                        {
                            nr3 = mas.nrCautari;
                            loc3 = mas;
                        }
                    }
                }
            }
            List<Anunt> top3M = new List<Anunt>();
            top3M.Add(loc1);
            top3M.Add(loc2);
            top3M.Add(loc3);
            return top3M;
        }

        public static List<Anunt> CautareMasiniFormsUser(string user)
        {

            List<Anunt> listaMasiniUser = new List<Anunt>(listaAnunturi);
            List<Anunt> copieListaMasiniUser = new List<Anunt>(listaAnunturi);
            if (user != string.Empty)
            {
                foreach (Anunt masina in listaMasiniUser)
                {
                    if (!(masina.userProp.Equals(user)))
                        copieListaMasiniUser.Remove(masina);
                }
            }


            //foreach (Anunt masC in copieListaMasiniCautate)
            //{
            //    masC.nrCautari++;
            //}

            return copieListaMasiniUser;
        }

        public static List<Anunt> CautareMasiniFormsAltUser(string user)
        {

            List<Anunt> listaMasiniUser = new List<Anunt>(listaAnunturi);
            List<Anunt> copieListaMasiniUser = new List<Anunt>(listaAnunturi);
            if (user != string.Empty)
            {
                foreach (Anunt masina in listaMasiniUser)
                {
                    if (masina.userProp.Equals(user))
                        copieListaMasiniUser.Remove(masina);
                }
            }


            //foreach (Anunt masC in copieListaMasiniCautate)
            //{
            //    masC.nrCautari++;
            //}

            return copieListaMasiniUser;
        }

        public static void actualizareMasini()
        {
            int ind = 0;
            foreach (Anunt m in listaAnunturi)
            {
                ind++;
                m.setIdMasina(ind);
            }
        }

        public static int[] topMasiniComplet()
        {
            int[] idMasini = new int[Anunt.idMasinaProp];
            Anunt[] anunturiCautate = listaAnunturi.ToArray();

            for (int i = 0; i < Anunt.idMasinaProp; i++)
            {
                idMasini[i] = i+1;
            }

            for (int i = 0; i < Anunt.idMasinaProp-1; i++)
            {
                for (int j = i+1; j < Anunt.idMasinaProp; j++)
                {
                    if (anunturiCautate[i].nrCautari < anunturiCautate[j].nrCautari)
                    {
                        int aux = idMasini[i];
                        idMasini[i] = idMasini[j];
                        idMasini[j] = aux;

                    }
                }
            }
            return idMasini;
        }

        public static List<Anunt> getTopMasiniComplet()
        {

            List<Anunt> topAnunturi = new List<Anunt>();

            int[] idArr = topMasiniComplet();

            for(int i = 0; i < Anunt.idMasinaProp; i++)
            {
                topAnunturi.Add(getMasina(idArr[i]));
            }

            return topAnunturi;
        }
    }
}
