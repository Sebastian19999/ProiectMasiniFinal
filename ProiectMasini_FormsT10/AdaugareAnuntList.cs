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
using ManagerM;
using Meniu;

namespace ProiectMasini_FormsT10
{
    public partial class AdaugareAnuntList : Form
    {

        public Anunt masinaGrid { get; set; }

        public AdaugareAnuntList(Anunt anunt)
        {
            InitializeComponent();

            masinaGrid = anunt;

            //DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            firmaTxt.Text = masinaGrid.firmaProp;
            modelTxt.Text = masinaGrid.modelProp;
            anFTxt.Text = masinaGrid.anFabricatie.ToString();

            //Anunt masinaGrid = ManagerAnunturi.getMasina(Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString()));
            //anuntSelectatProp = masinaGrid;
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

            numeVanzatorTxt.Text = masinaGrid.numeVanzator;
            dataTxt.Text = masinaGrid.dataTranzactie;
            pretTxt.Text = masinaGrid.pretProp.ToString();
            tipCmbBox.Text = masinaGrid.tipMasina;
            identificareOptiuni(masinaGrid);
            try
            {
                Imagine imgFis = new Imagine(masinaGrid.locatieFotografie);
                afiseazaImaginiPct.ImageLocation = imgFis.locatieProp;
            }
            catch (Exception)
            {
                afiseazaImaginiPct.ImageLocation = "C:\\Users\\sebyg\\source\\repos\\ProiectMasiniPIU\\ProiectMasiniPIU\\ImaginiMeniu\noImg.jpg";
            }

            BlocareControale();
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

        private void AdaugareAnuntList_Load(object sender, EventArgs e)
        {

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

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            FinalizareTranzactie finalizareTranzactie = new FinalizareTranzactie(masinaGrid);
            finalizareTranzactie.Show();
            adaugaBtn.Enabled = false;
        }
    }
}
