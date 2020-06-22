//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;
using ManagerM;
using ManagerImg;

using ProiectMasini_FormsT10;
using Meniu;
using LoginSystem;

namespace ProiectMasiniPIU
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Masina masina;
            

            Masina[] masini;
            IStocareData adminMasini = ManagerMasini.GetAdministratorStocare();
            int nrMasini;
            masini = adminMasini.GetMasina(out nrMasini);
            Masina.idMasinaProp = nrMasini;
            for (int i = 0; i < nrMasini; i++)
            {
                ManagerMasini.addMasina(masini[i]);
            }

            Imagine[] imagini;
            IStocareImagini adminImagini = ManagerImg.ManagerImagini.GetAdministratorStocare();
            int nrImagini;
            imagini = adminImagini.GetImagine(out nrImagini);
            Imagine.idImagineProp = nrImagini;
            for (int i = 0; i < nrImagini; i++)
            {
                ManagerImg.ManagerImagini.addImagine(imagini[i]);
            }

            Tranzactie[] tranzactii;
            IStocareTranzactii adminTranzactii = ManagerTranzactii.GetAdministratorStocare();
            int nrTranzactii;
            tranzactii = adminTranzactii.GetTranzactie(out nrTranzactii);
            Tranzactie.idMasinaProp = nrTranzactii;
            for (int i = 0; i < nrTranzactii; i++)
            {
                ManagerTranzactii.addTranzactie(tranzactii[i]);
            }

            Anunt[] anunturi;
            IStocareAnunturi adminAnunturi = ManagerAnunturi.GetAdministratorStocare();
            int nrAnunturi;
            anunturi = adminAnunturi.GetAnunt(out nrAnunturi);
            Anunt.idMasinaProp = nrAnunturi;
            for (int i = 0; i < nrAnunturi; i++)
            {
                ManagerAnunturi.addAnunt(anunturi[i]);
            }

            Imagine[] imaginiTranzactii;
            IStocareImagini adminImaginiTranzactii = ManagerImg.ManagerImaginiTranzactii.GetAdministratorStocare();
            int nrImaginiTranzactii;
            imaginiTranzactii = adminImaginiTranzactii.GetImagine(out nrImaginiTranzactii);
            Tranzactie.idMasinaProp = nrImaginiTranzactii;
            for (int i = 0; i < nrImaginiTranzactii; i++)
            {
                ManagerImg.ManagerImaginiTranzactii.addImagine(imaginiTranzactii[i]);
            }

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());



           



        }

        
    }
}
