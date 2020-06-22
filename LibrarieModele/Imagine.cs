//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Imagine
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public static int idI;
        private int id;
        private int idImg;

        private const int ID = 0;
        private const int LOCATIE = 1;

        public static int idImagineProp { get; set; } = 0;
        public int idImagine { get; set; }
        public string locatieProp { get; set; }

        public Imagine(string locatie)
        {
            locatieProp = locatie;
            idI++;
            idImagine = idI;
        }

        public Imagine(string linieFisier, int nr)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            id = Convert.ToInt32(dateFisier[ID]);
            locatieProp = dateFisier[LOCATIE];

            idImagine = id;
            

            idI++;
            setIdMasina(idI);
        }

        public string ConversieLaSir_PentruFisier()
        {
            string sNote = string.Empty;

            string i = string.Format("{1}{0}{2}",
                SEPARATOR_PRINCIPAL_FISIER, (idImagine.ToString()), (locatieProp ?? "NECUNOSCUTA"));

            return i;
        }

        public void setIdMasina(int id)
        {
            this.idImg = id;
        }
    }
}
