﻿//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LibrarieModele;
using NivelAccesDate;

namespace ManagerM
{
    public class ManagerMasini
    {
        public static List<Masina> listaMasini = new List<Masina>();


        public static void addMasina(Masina masina)
        {
            listaMasini.Add(masina);
        }

        public static void stergeMasina(Masina masina)
        {
            listaMasini.Remove(masina);
        }

        public static void removeMasina(int id)
        {
            int ok = 0;
            foreach (var mas in listaMasini)
                if (mas.getIdMasina() == id)
                { listaMasini.Remove(mas); ok = 1; break; }
            if (ok == 0)
                Console.WriteLine("Id-ul este incorect... ");
        }

        public static void getMasini()
        {
            foreach (var mas in listaMasini)
            {
                Console.WriteLine(mas.toString());
            }
        }

        public static List<Masina> getMasiniList()
        {
            return listaMasini;
        }

        public static Masina getMasina(int id)
        {
            int ok = 0;
            Masina rezultat = new Masina();
            foreach (Masina mas in listaMasini)
                if (mas.getIdMasina() == id)
                { ok = 1; rezultat = mas; break; }
            if (ok == 0)
            { Console.WriteLine("Id-ul este incorect... "); return null; }
            Console.WriteLine(rezultat.toString());
            return rezultat;
        }

        public static int numarCautariMax()
        {
            int idMax = 1;
            int nrMax = -1, nr2;
            foreach (Masina mas in listaMasini)
            {
                nrMax = mas.getNumarCautari();
                foreach (Masina mas1 in listaMasini)
                {
                    if (mas1.getNumarCautari() > nrMax)
                    {
                        idMax = mas1.getIdMasina();
                        nrMax = mas1.getNumarCautari();
                    }
                }
            }
            return idMax;
        }

        public static int[] getListaPreturi(int nr)
        {
            Masina masinaCurenta;

            int idCurent = 0;
            int[] idVect = new int[Masina.idM + 1];
            double[] preturiVect = new double[Masina.idM + 1];
            for (int i = 0; i < Masina.idM + 1; i++)
            {
                idCurent++;
                masinaCurenta = getMasina(idCurent);
                idVect[i] = idCurent;
                preturiVect[i] = masinaCurenta.getPret();
            }
            if (nr == 0)
            {
                for (int i = 0; i < Masina.idM - 1; i++)
                {
                    for (int j = 0; j < Masina.idM; i++)
                    {
                        if (preturiVect[i] <= preturiVect[j])
                        {
                            double aux1 = preturiVect[i];
                            preturiVect[i] = preturiVect[j];
                            preturiVect[j] = aux1;
                            int aux2 = idVect[i];
                            idVect[i] = idVect[j];
                            idVect[j] = aux2;
                        }
                    }
                }
            }
            else if (nr == 1)
            {
                for (int i = 0; i < Masina.idM - 1; i++)
                {
                    for (int j = 0; j < Masina.idM; i++)
                    {
                        if (preturiVect[i] >= preturiVect[j])
                        {
                            double aux1 = preturiVect[i];
                            preturiVect[i] = preturiVect[j];
                            preturiVect[j] = aux1;
                            int aux2 = idVect[i];
                            idVect[i] = idVect[j];
                            idVect[j] = aux2;
                        }
                    }
                }
            }
            return idVect;
        }

        public static int[] cautare(int nr)
        {
            int[] idVect = new int[10];
            int ind = 0;
            if (nr == 0)
            {
                Console.WriteLine("Introduceti numele cumparatorului dupa care cautati:");
                string numec = Console.ReadLine();
                foreach (Masina mas in listaMasini)
                    if (mas.numeCumparator.Equals(numec))
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else if (nr == 1)
            {
                Console.WriteLine("Introduceti numele vanzatorului dupa care cautati:");
                string numec = Console.ReadLine();
                foreach (Masina mas in listaMasini)
                    if (mas.numeVanzator.Equals(numec))
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else if (nr == 2)
            {
                Console.WriteLine("Introduceti firma dupa care cautati:");
                string numec = Console.ReadLine();
                foreach (Masina mas in listaMasini)
                    if (mas.firmaProp.Equals(numec))
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else if (nr == 3)
            {
                Console.WriteLine("Introduceti modelul dupa care cautati:");
                string numec = Console.ReadLine();
                foreach (Masina mas in listaMasini)
                    if (mas.modelProp.Equals(numec))
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else if (nr == 4)
            {
                Console.WriteLine("Introduceti anul fabricatiei dupa care cautati:");
                int numec = Convert.ToInt32(Console.ReadLine());
                foreach (Masina mas in listaMasini)
                    if (mas.anFabricatie == numec)
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else if (nr == 5)
            {
                Console.WriteLine("Introduceti culoarea dupa care cautati:");
                string numec = Console.ReadLine();
                foreach (Masina mas in listaMasini)
                    if (mas.culoareProp.Equals(numec))
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else if (nr == 6)
            {
                Console.WriteLine("Introduceti data tranzactiei dupa care cautati [dd.mm.yyyy]:");
                string numec = Console.ReadLine();
                foreach (Masina mas in listaMasini)
                    if (mas.dataTranzactie.Equals(numec))
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else if (nr == 7)
            {
                Console.WriteLine("Introduceti pretul dupa care cautati:");
                double numec = Convert.ToDouble(Console.ReadLine());
                foreach (Masina mas in listaMasini)
                    if (mas.pretProp == numec)
                    {
                        idVect[ind] = mas.getIdMasina();
                        ind++;
                    }
            }
            else
            {
                Console.WriteLine("Optiune invalida");
                return null;
            }
            return idVect;
        }



        /// <summary>
        /// ////////////FISIER////////////////
        /// </summary>
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareMasiniBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareMasiniText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\MasiniSalvate.txt");
                }
            }

            return null;
        }

        public static List<Masina> CautareMasiniForms(string firma, string model, string culoare, string anFabricatie,
                                                    string numeVanzator, string numeCumparator, string data, string pret, string optiuni)
        {
            List<Masina> listaMasiniCautate = new List<Masina>(listaMasini);
            List<Masina> copieListaMasiniCautate = new List<Masina>(listaMasini);
            if (firma != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.firmaProp.Equals(firma)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (model != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.modelProp.Equals(model)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (culoare != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.culoareProp.Equals(culoare)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (anFabricatie != string.Empty)
            {
                int anf = Convert.ToInt32(anFabricatie);
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (masina.anFabricatie != anf)
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeVanzator != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.numeVanzator.Equals(numeVanzator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeCumparator != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.numeCumparator.Equals(numeCumparator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (data != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.dataTranzactie.Equals(data)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (pret != string.Empty)
            {
                double p = Convert.ToDouble(pret);
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (masina.pretProp != p)
                        copieListaMasiniCautate.Remove(masina);
                }
            }

            foreach(Masina masC in copieListaMasiniCautate)
            {
                masC.nrCautari++;
            }


            return copieListaMasiniCautate;
        }


        public static List<Masina> CautareMasiniFormsDate(string firma, string model, string culoare, string anFabricatie,
                                                    string numeVanzator, string numeCumparator, string data, string pret, string optiuni,string startDate,string stopDate)
        {

            string[] startDate1 = startDate.Split(' ');
            string[] startDate2 = startDate1[0].Split('/');

            string[] stopDate1 = stopDate.Split(' ');
            string[] stopDate2 = stopDate1[0].Split('/');

            List<Masina> listaMasiniCautate = new List<Masina>(listaMasini);
            List<Masina> copieListaMasiniCautate = new List<Masina>(listaMasini);
            if (firma != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.firmaProp.Equals(firma)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (model != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.modelProp.Equals(model)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (culoare != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.culoareProp.Equals(culoare)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (anFabricatie != string.Empty)
            {
                int anf = Convert.ToInt32(anFabricatie);
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (masina.anFabricatie != anf)
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeVanzator != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.numeVanzator.Equals(numeVanzator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (numeCumparator != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.numeCumparator.Equals(numeCumparator)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (data != string.Empty)
            {
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (!(masina.dataTranzactie.Equals(data)))
                        copieListaMasiniCautate.Remove(masina);
                }
            }
            if (pret != string.Empty)
            {
                double p = Convert.ToDouble(pret);
                foreach (Masina masina in listaMasiniCautate)
                {
                    if (masina.pretProp != p)
                        copieListaMasiniCautate.Remove(masina);
                }
            }

            foreach (Masina masina in listaMasiniCautate)
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

                if(!(luna_min<=luna_curenta&&luna_curenta<=luna_max))
                    copieListaMasiniCautate.Remove(masina);
                else
                    if (!(zi_min <= zi_curenta && zi_curenta <= zi_max))
                    copieListaMasiniCautate.Remove(masina);
                else
                    if (!(an_min <= an_curent && an_curent <= an_max))
                    copieListaMasiniCautate.Remove(masina);
            }

            foreach (Masina masC in copieListaMasiniCautate)
            {
                masC.nrCautari++;
            }

            return copieListaMasiniCautate;
        }

        public static List<Masina> top3Masini()
        {
            Masina[] masiniArr = listaMasini.ToArray();
            Masina loc1=masiniArr[0], loc2=masiniArr[1], loc3=masiniArr[1];
            int nr1 = -1, nr2 = -1, nr3 = -1;

            foreach(Masina mas in listaMasini)
            {
                if (mas.nrCautari > nr1)
                {
                    nr1 = mas.nrCautari;
                    loc1 = mas;
                }
                else
                {
                    if (mas.nrCautari <= nr1 && mas.nrCautari > nr2)
                    {
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
            List<Masina> top3M=new List<Masina>();
            top3M.Add(loc1);
            top3M.Add(loc2);
            top3M.Add(loc3);
            return top3M;
        }

        public static void actualizareMasini()
        {
            int ind = 0;
            foreach(Masina m in listaMasini)
            {
                ind++;
                m.setIdMasina(ind);
            }
        }
    }
}
