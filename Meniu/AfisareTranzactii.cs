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
using LibrarieModele;
using NivelAccesDate;
using ManagerImg;
using ManagerM;

namespace Meniu
{
    public partial class AfisareTranzactii : Form
    {
        IStocareImagini adminImaginiTranzactii;
        IStocareTranzactii adminTranzactii;
        public AfisareTranzactii()
        {
            InitializeComponent();

            List<Tranzactie> afisareMasini = ManagerTranzactii.getTranzactii();

            adminImaginiTranzactii = ManagerImg.ManagerImaginiTranzactii.GetAdministratorStocare();
            adminTranzactii = ManagerTranzactii.GetAdministratorStocare();

            AdaugaStudentiInControlDataGridView(afisareMasini);
        }

        private void AdaugaStudentiInControlDataGridView(List<Tranzactie> tranzactii)
        {
            dataGridView1.DataSource = null;


            dataGridView1.DataSource = tranzactii.Select(mas => new { V = mas.getIdMasina(), mas.firmaProp, mas.modelProp, mas.anFabricatie, mas.culoareProp, mas.numeVanzator,mas.dataTranzactie, mas.pretProp, mas.tipMasina, mas.dataActualizare, mas.OptiuniAsString }).ToList(); //s.Nume, s.Prenume, s.ProgramSTD, Discipline = string.Join(",", s.Discipline), Note = string.Join(",", s.GetNote()), s.DataNastere, s.DataActualizare }).ToList();
        }

        private void AfisareTranzactii_Load(object sender, EventArgs e)
        {

        }
    }
}
