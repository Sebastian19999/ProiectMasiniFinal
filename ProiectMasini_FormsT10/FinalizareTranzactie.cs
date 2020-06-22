//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ManagerM;
using LibrarieModele;
using ManagerImg;
using NivelAccesDate;


namespace Meniu
{
    public partial class FinalizareTranzactie : Form
    {
        IStocareAnunturi adminMasini;
        IStocareTranzactii adminTranzactii;
        IStocareImagini adminImagini;
        IStocareImagini administrareImaginiAnunturi;
        public Anunt masinaAchizitionata { get; set; }
        public FinalizareTranzactie(Anunt masina)
        {
            InitializeComponent();
            masinaAchizitionata = masina;
            adminTranzactii = ManagerTranzactii.GetAdministratorStocare();
            adminImagini = ManagerImg.ManagerImaginiTranzactii.GetAdministratorStocare();
            administrareImaginiAnunturi = ManagerImg.ManagerImagini.GetAdministratorStocare();
            adminMasini = ManagerAnunturi.GetAdministratorStocare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cumparatorTxt.Text == string.Empty)
            {
                MessageBox.Show("Nume cumparator invalid", "Date incorecte", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Tranzactie tranzactie = new Tranzactie(masinaAchizitionata.numeVanzator, masinaAchizitionata.numeCumparator,
                    masinaAchizitionata.firmaProp, masinaAchizitionata.modelProp, masinaAchizitionata.anFabricatie, masinaAchizitionata.culoareProp, masinaAchizitionata.OptiuniAsString, masinaAchizitionata.dataTranzactie,
                    masinaAchizitionata.pretProp, masinaAchizitionata.tipMasina, masinaAchizitionata.dataActualizare);
                masinaAchizitionata.numeCumparator = cumparatorTxt.Text;
                Imagine imagine = administrareImaginiAnunturi.GetImagineByIndex(masinaAchizitionata.getIdMasina() - 1);
                ManagerTranzactii.addTranzactie(tranzactie);
                ManagerAnunturi.removeAnunt(masinaAchizitionata);
                ManagerImg.ManagerImagini.removeImagine(imagine);
                ManagerAnunturi.actualizareMasini();
                List<Anunt> masiniRamase = ManagerAnunturi.getAnunturi();
                File.WriteAllText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\AnunturiSalvate.txt", String.Empty);
                foreach (Anunt m in masiniRamase)
                {
                    adminMasini.AddAnunt(m);
                }
                ManagerImg.ManagerImagini.actualizareMasini();
                List<Imagine> imaginiRamase = ManagerImg.ManagerImagini.getImagini();
                File.WriteAllText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\ImaginiSalvate.txt", String.Empty);
                foreach (Imagine m in imaginiRamase)
                {
                    administrareImaginiAnunturi.AddImagine(m);
                }
                adminImagini.AddImagine(imagine);
                adminTranzactii.AddTranzactie(tranzactie);
                ManagerTranzactii.addTranzactie(tranzactie);
                
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinalizareTranzactie_Load(object sender, EventArgs e)
        {

        }
    }
}
