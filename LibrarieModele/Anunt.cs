//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LibrarieModele
{
    public class Anunt
    {
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const char SEPARATOR_OPTIUNI = ',';

        //private string[] optiuniMasina;
        public static int idM;
        private int idMasina;
        private string nume_vanzator;
        private string nume_cumparator;
        private string firma, model;
        private int an_fabricatie;
        private string culoare;
        private string optiuni;
        private string data_tranzactie;
        private double pret;

        private const int ID = 0;
        private const int FIRMA = 1;
        private const int MODEL = 2;
        private const int CULOARE = 3;
        private const int ANF = 4;
        private const int NUMEV = 5;
        //private const int NUMEC = 6;
        private const int DATAT = 6;
        private const int PRET = 7;
        private const int OPTIUNI = 8;
        private const int TIP = 9;
        private const int DATE_TIME = 10;
        private const int USER = 11;
        private const int CAUTARI = 12;
        private const int LOCATIE = 13;

        public string[] optiuniMasina { get; set; }
        public int idMasinaPropp { get; set; }

        public static int idMasinaProp { get; set; } = 0;
        public int idMasinaFin { get; set; }
        public string numeVanzator { get; set; }
        public string numeCumparator { get; set; }
        public string firmaProp { get; set; }
        public string modelProp { get; set; }
        public int anFabricatie { get; set; }
        public string culoareProp { get; set; }
        public string optiuniProp { get; set; }
        public string dataTranzactie { get; set; }
        public double pretProp { get; set; }
        public int nrCautari { get; set; }

        public string tipMasina { get; set; }

        public Culori CuloareMasina { get; set; }

        public ArrayList Optiuni { get; set; }

        public DateTime dataActualizare { get; set; }

        public string userProp { get; set; }
        public string locatieFotografie { get; set; }

        public string OptiuniAsString
        {
            get
            {
                string strOptiuni = string.Empty;

                foreach (string optiune in optiuniMasina)
                {
                    if (strOptiuni != string.Empty)
                    {
                        strOptiuni += SEPARATOR_OPTIUNI;
                    }
                    strOptiuni += optiune;
                }

                return strOptiuni;
            }
        }

        public Anunt()
        {
            this.nume_vanzator = string.Empty;
            this.nume_cumparator = string.Empty;
            this.firma = string.Empty;
            this.model = string.Empty;
            this.an_fabricatie = 0;
            this.culoare = string.Empty;
            this.optiuni = string.Empty;
            this.data_tranzactie = string.Empty;
            this.pret = 0;

            idM++;
            setIdMasina(idM);

        }


        public Anunt(string nv, string firma, string model, int anf, string culoare, string optiuni, string dt, double pret, string tipM, DateTime dateT,string user,string foto,int numarCautariAnunt)
        {
            numeVanzator = nv;
            //numeCumparator = nc;
            firmaProp = firma;
            modelProp = model;
            anFabricatie = anf;
            culoareProp = culoare;

            optiuniMasina = optiuni.Split(',');
            dataTranzactie = dt;
            pretProp = pret;

            tipMasina = tipM;
            dataActualizare = dateT;

            userProp = user;

            locatieFotografie = foto;

            nrCautari = numarCautariAnunt;

            idM++;
            setIdMasina(idM);
            idMasinaPropp = idM;
        }

        public Anunt(string linieFisier, int nr)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            idMasinaFin = Convert.ToInt32(dateFisier[ID]);
            firmaProp = dateFisier[FIRMA];
            modelProp = dateFisier[MODEL];
            culoareProp = dateFisier[CULOARE];
            anFabricatie = Convert.ToInt32(dateFisier[ANF]);
            numeVanzator = dateFisier[NUMEV];
            //numeCumparator = dateFisier[NUMEC];
            dataTranzactie = dateFisier[DATAT];
            pretProp = Convert.ToDouble(dateFisier[PRET]);
            optiuniMasina = dateFisier[OPTIUNI].Split(',');
            tipMasina = dateFisier[TIP];
            dataActualizare = Convert.ToDateTime(dateFisier[DATE_TIME]);
            userProp = dateFisier[USER];
            nrCautari = Convert.ToInt32(dateFisier[CAUTARI]);
            locatieFotografie = dateFisier[LOCATIE];


            idMasinaProp = idMasinaFin;

            idM++;
            setIdMasina(idM);
        }

        public void identificaCuloare()
        {
            if (CuloareMasina == Culori.alb)
                culoareProp = "alb";
            else
                if (CuloareMasina == Culori.negru)
                culoareProp = "negru";
            if (CuloareMasina == Culori.rosu)
                culoareProp = "rosu";
            if (CuloareMasina == Culori.galben)
                culoareProp = "galben";
            if (CuloareMasina == Culori.albastru)
                culoareProp = "albastru";
            if (CuloareMasina == Culori.verde)
                culoareProp = "verde";
            if (CuloareMasina == Culori.mov)
                culoareProp = "mov";
            if (CuloareMasina == Culori.portocaliu)
                culoareProp = "portocaliu";
            if (CuloareMasina == Culori.maro)
                culoareProp = "maro";

        }

        public string ConversieLaSir_PentruFisier()
        {
            string sNote = string.Empty;

            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}{13}{0}{14}",
                SEPARATOR_PRINCIPAL_FISIER, (idMasina.ToString()), (firmaProp ?? "NECUNOSCUTA"), (modelProp ?? "NECUNOSCUT"),
                            (culoareProp ?? "NECUNOSCUTA"), (anFabricatie.ToString() ?? "NECUNOSCUT"), (numeVanzator ?? " NECUNOSCUT "),
                            //(numeCumparator ?? " NECUNOSCUT ",
                            (dataTranzactie ?? " NECUNOSCUTA "), (pretProp.ToString() ?? "NECUNOSCUT"),
                            OptiuniAsString, tipMasina, dataActualizare.ToString(),userProp,nrCautari.ToString(),locatieFotografie);

            return s;
        }

        public string toString()
        {
            return idMasina + ". " + firmaProp + " " + modelProp + ", " + culoareProp + ", an: " + anFabricatie + ", Vanzator: " + numeVanzator +
                ", cumparator: " + numeCumparator + ", pret: " + pretProp + " euro";
        }

        public int getIdMasina()
        {
            return this.idMasina;
        }

        public void setIdMasina(int id)
        {
            this.idMasina = id;
        }
    }
}
