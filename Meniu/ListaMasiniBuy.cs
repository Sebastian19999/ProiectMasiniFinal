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
using ManagerM;
using ManagerImg;
using NivelAccesDate;

namespace Meniu
{
    public partial class ListaMasiniBuy : Form
    {
        IStocareImagini adminImagini;

        public Anunt anuntSelectatProp { get; set; }

        public ListaMasiniBuy()
        {
            InitializeComponent();

            List<Anunt> afisareAnunturi = ManagerAnunturi.getAnunturi();
            List<Anunt> afisareAnunturiAltUser = ManagerAnunturi.CautareMasiniFormsAltUser(MeniuAplicatie.salvareUserMeniuStatic);

            var antetTabel = String.Format("{0,-8}{1,-30}{2,-30}{3,-20}{4,-15}{5,-15}{6,-14}{7,-20}{8,-10}\n", "Id", "Nume vanzator", "Nume cumparator", "Data tranzactie", "Firma", "Model", "Culoare", "An fabricatie", "Pret");
            AdaugaStudentiInControlDataGridView(afisareAnunturiAltUser);

            adminImagini = ManagerImg.ManagerImagini.GetAdministratorStocare();
            this.Width = 650;
        }

        public ListaMasiniBuy(int idMasina)
        {
            InitializeComponent();

            List<Anunt> afisareAnunturi = ManagerAnunturi.getAnunturi();
            List<Anunt> afisareAnunturiAltUser = ManagerAnunturi.CautareMasiniFormsAltUser(MeniuAplicatie.salvareUserMeniuStatic);

            var antetTabel = String.Format("{0,-8}{1,-30}{2,-30}{3,-20}{4,-15}{5,-15}{6,-14}{7,-20}{8,-10}\n", "Id", "Nume vanzator", "Nume cumparator", "Data tranzactie", "Firma", "Model", "Culoare", "An fabricatie", "Pret");
            AdaugaStudentiInControlDataGridView(afisareAnunturiAltUser);

            adminImagini = ManagerImg.ManagerImagini.GetAdministratorStocare();
            this.Width = 650;
            dataGridView1.Hide();
        }

        private void AdaugaStudentiInControlDataGridView(List<Anunt> masini)
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = masini.Select(mas => new { V = mas.getIdMasina(), mas.firmaProp, mas.modelProp, mas.anFabricatie, mas.culoareProp, mas.numeVanzator, mas.dataTranzactie, mas.pretProp, mas.tipMasina, mas.dataActualizare, mas.OptiuniAsString }).ToList(); //s.Nume, s.Prenume, s.ProgramSTD, Discipline = string.Join(",", s.Discipline), Note = string.Join(",", s.GetNote()), s.DataNastere, s.DataActualizare }).ToList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListaMasiniBuy_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Width = 1020;
            int index = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            firmaTxt.Text = dataGridViewRow.Cells[1].Value.ToString();
            modelTxt.Text = dataGridViewRow.Cells[2].Value.ToString();
            anFTxt.Text = dataGridViewRow.Cells[3].Value.ToString();

            Anunt masinaGrid = ManagerAnunturi.getMasina(Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString()));
            anuntSelectatProp = masinaGrid;
            if (masinaGrid.culoareProp == "alb")
                albRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "albastru")
                albastruRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "mov")
                movRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "galben")
                galbenRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "portocaliu")
                portocaliuRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "rosu")
                rosuRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "verde")
                verdeRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "maro")
                maroRdb.Checked = true;
            else
                if (masinaGrid.culoareProp == "negru")
                negruRdb.Checked = true;

            numeVanzatorTxt.Text = dataGridViewRow.Cells[5].Value.ToString();
            dataTxt.Text = dataGridViewRow.Cells[6].Value.ToString();
            pretTxt.Text = dataGridViewRow.Cells[7].Value.ToString();
            tipCmbBox.Text = masinaGrid.tipMasina.ToString().Trim();
            identificareOptiuni(masinaGrid);
            try {
                Imagine imgFis = adminImagini.GetImagineByIndex(Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString()) - 1);
                afiseazaImaginiPct.ImageLocation = imgFis.locatieProp;
            }
            catch (Exception)
            {
                afiseazaImaginiPct.ImageLocation = "C:\\Users\\sebyg\\source\\repos\\ProiectMasiniPIU\\ProiectMasiniPIU\\ImaginiMeniu\noImg.jpg";
            }
            
        }

        public void BlocareControale()
        {
            firmaTxt.Enabled = false;
            modelTxt.Enabled = false;
            anFTxt.Enabled = false;
            albRdb.Enabled = false;
            albastruRdb.Enabled = false;
            galbenRdb.Enabled = false;
            negruRdb.Enabled = false;
            maroRdb.Enabled = false;
            portocaliuRdb.Enabled = false;
            rosuRdb.Enabled = false;
            movRdb.Enabled = false;
            verdeRdb.Enabled = false;
            numeVanzatorTxt.Enabled = false;
            dataTxt.Enabled = false;
            pretTxt.Enabled = false;
            tipCmbBox.Enabled = false;
            absCheck.Enabled = false;
            airbagCheck.Enabled = false;
            cruiseCheck.Enabled = false;
            solarCheck.Enabled = false;
            bluetoothCheck.Enabled = false;
            proiectoareCheck.Enabled = false;
            pilotCheck.Enabled = false;
            masajCheck.Enabled = false;
            leatherCheck.Enabled = false;
        }

        private void identificareOptiuni(Anunt m)
        {
            string[] optiuniSt = m.OptiuniAsString.Split(',');

            absCheck.Checked = false;
            airbagCheck.Checked = false;
            cruiseCheck.Checked = false;
            solarCheck.Checked = false;
            bluetoothCheck.Checked = false;
            proiectoareCheck.Checked = false;
            pilotCheck.Checked = false;
            masajCheck.Checked = false;
            leatherCheck.Checked = false;

            if (m.tipMasina.Trim().Equals("Sedan"))
            {
                foreach (string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("ABS"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Airbaguri laterale"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Cruise Control"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Solar Roof"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Conectivitate Bluetooth"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Proiectoare ceata"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Pilot automat"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Scaune masaj"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Full Leather"))
                        leatherCheck.Checked = true;
                }

            }
            else if (m.tipMasina.Trim().Equals("Sport"))
            {
                foreach (string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("WiFi Hotspot"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Pachet Alcantara"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Cruise Control"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Solar Roof"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Fibra de carbon"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Frane ceramice"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Camere laterale"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Smart Suspension"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Volan piele"))
                        leatherCheck.Checked = true;


                }
            }
            else if (m.tipMasina.Trim().Equals("SUV"))
            {
                foreach (string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("Track Pace"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Airbaguri laterale"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Full Leather"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Keyless Entry"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Conectivitate Bluetooth"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Head-Up Display"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Power Tailgate"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Scaune masaj"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Volan piele"))
                        leatherCheck.Checked = true;
                }



            }
            else if (m.tipMasina.Trim().Equals("Lux"))
            {
                foreach (string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("Bara spate"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Airbaguri laterale"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Cruise Control"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Solar Roof"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Head-Up Display"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Keyless Entry"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Pilot automat"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Scaune masaj"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Full Leather"))
                        leatherCheck.Checked = true;
                }

            }
        }

        private void tipCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int optiuneCmb = tipCmbBox.SelectedIndex;

            if (optiuneCmb == 0)
            {
                absCheck.Text = "ABS";
                airbagCheck.Text = "Airbaguri laterale";
                cruiseCheck.Text = "Cruise Control";
                solarCheck.Text = "Solar Roof";
                bluetoothCheck.Text = "Conectivitate Bluetooth";
                proiectoareCheck.Text = "Proiectoare ceata";
                pilotCheck.Text = "Pilot automat";
                masajCheck.Text = "Scaune masaj";
                leatherCheck.Text = "Full Leather";
            }
            if (optiuneCmb == 1)
            {
                absCheck.Text = "WiFi Hotspot";
                airbagCheck.Text = "Pachet Alcantara";
                cruiseCheck.Text = "Cruise Control";
                solarCheck.Text = "Solar Roof";
                bluetoothCheck.Text = "Fibra de carbon";
                proiectoareCheck.Text = "Frane ceramice";
                pilotCheck.Text = "Camere laterale";
                masajCheck.Text = "Smart Suspension";
                leatherCheck.Text = "Volan piele";
            }
            if (optiuneCmb == 2)
            {
                absCheck.Text = "Track Pace";
                airbagCheck.Text = "Airbaguri laterale";
                cruiseCheck.Text = "Full Leather";
                solarCheck.Text = "Keyless Entry";
                bluetoothCheck.Text = "Conectivitate Bluetooth";
                proiectoareCheck.Text = "Head-Up Display";
                pilotCheck.Text = "Power Tailgate";
                masajCheck.Text = "Scaune masaj";
                leatherCheck.Text = "Volan piele";
            }
            if (optiuneCmb == 3)
            {
                absCheck.Text = "Bara spate";
                airbagCheck.Text = "Airbaguri laterale";
                cruiseCheck.Text = "Cruise Control";
                solarCheck.Text = "Solar Roof";
                bluetoothCheck.Text = "Head-Up Display";
                proiectoareCheck.Text = "Keyless Entry";
                pilotCheck.Text = "Pilot automat";
                masajCheck.Text = "Scaune masaj";
                leatherCheck.Text = "Full Leather";
            }
        }

        private void imaginiBtn_Click(object sender, EventArgs e)
        {
            this.Width = 1500;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            FinalizareTranzactie finalizareTranzactie = new FinalizareTranzactie(anuntSelectatProp);
            finalizareTranzactie.Show();
            adaugaBtn.Enabled = false;
        }
    }
}
