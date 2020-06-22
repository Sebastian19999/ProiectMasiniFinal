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
using System.Collections;
using System.IO;
using LibrarieModele;
using ManagerM;
using NivelAccesDate;

namespace Meniu
{
    public partial class AfiseazaDateCaracteristice : Form
    {

        IStocareAnunturi adminAnunturi;

        ArrayList optiuniSelectate=new ArrayList();

        public Anunt anuntSelectatProp { get; set; }

        public AfiseazaDateCaracteristice()
        {
            InitializeComponent();

            adminAnunturi = ManagerAnunturi.GetAdministratorStocare();

            List<Anunt> afisareAnunturi = ManagerAnunturi.CautareMasiniFormsUser(MeniuAplicatie.salvareUserMeniuStatic);

            var antetTabel = String.Format("{0,-8}{1,-30}{2,-30}{3,-20}{4,-15}{5,-15}{6,-14}{7,-20}{8,-10}\n", "Id", "Nume vanzator", "Nume cumparator", "Data tranzactie", "Firma", "Model", "Culoare", "An fabricatie", "Pret");
            AdaugaStudentiInControlDataGridView(afisareAnunturi);

            this.Width = 600;
            tipCmbBox.Enabled = false;
        }

        private void AdaugaStudentiInControlDataGridView(List<Anunt> masini)
        {
            dataGridView1.DataSource = null;


            dataGridView1.DataSource = masini.Select(mas => new { V = mas.getIdMasina(), mas.firmaProp, mas.modelProp, mas.anFabricatie, mas.culoareProp, mas.numeVanzator, mas.dataTranzactie, mas.pretProp, mas.tipMasina, mas.dataActualizare, mas.OptiuniAsString }).ToList(); //s.Nume, s.Prenume, s.ProgramSTD, Discipline = string.Join(",", s.Discipline), Note = string.Join(",", s.GetNote()), s.DataNastere, s.DataActualizare }).ToList();
        }

        private void AfiseazaDateCaracteristice_Load(object sender, EventArgs e)
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

            string optiuniMasinaForm = OptiuniAsString();

            numeVanzatorTxt.Text = dataGridViewRow.Cells[5].Value.ToString();
            dataTxt.Text = dataGridViewRow.Cells[6].Value.ToString();
            pretTxt.Text = dataGridViewRow.Cells[7].Value.ToString();
            tipCmbBox.Text = masinaGrid.tipMasina.ToString().Trim();
            identificareOptiuni(masinaGrid);
            //optiuniSelectate = identificareOptiuniArray(anuntSelectatProp);

            //anuntSelectatProp.optiuniMasina = optiuniMasinaForm.Split(',');
        }

        public string OptiuniAsString()
        {

            string strOptiuni = string.Empty;

            foreach (string optiune in optiuniSelectate)
            {
                if (strOptiuni != string.Empty)
                {
                    strOptiuni += ", ";
                }
                strOptiuni += optiune;
            }

            return strOptiuni;

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

        private ArrayList identificareOptiuniArray(Anunt m)
        {
            ArrayList optiuniSelect = new ArrayList();
            string[] optiuniSt = m.OptiuniAsString.Split(',');
            foreach(string opt in optiuniSt)
            {
                optiuniSelect.Add(opt.Trim());
            }

            return optiuniSelect;
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            anuntSelectatProp.firmaProp = firmaTxt.Text;
            anuntSelectatProp.modelProp = modelTxt.Text;
            try
            {
                anuntSelectatProp.anFabricatie = Convert.ToInt32(anFTxt.Text);
            }
            catch (Exception)
            {
                anFLbl.ForeColor = Color.Red;
                anFTxt.Text = string.Empty;
            }
            if (albRdb.Checked == true)
                anuntSelectatProp.culoareProp = "alb";
            if (albastruRdb.Checked == true)
                anuntSelectatProp.culoareProp = "albastru";
            if (movRdb.Checked == true)
                anuntSelectatProp.culoareProp = "mov";
            if (galbenRdb.Checked == true)
                anuntSelectatProp.culoareProp = "galben";
            if (rosuRdb.Checked == true)
                anuntSelectatProp.culoareProp = "rosu";
            if (portocaliuRdb.Checked == true)
                anuntSelectatProp.culoareProp = "portocaliu";
            if (verdeRdb.Checked == true)
                anuntSelectatProp.culoareProp = "verde";
            if (maroRdb.Checked == true)
                anuntSelectatProp.culoareProp = "maro";
            if (negruRdb.Checked == true)
                anuntSelectatProp.culoareProp = "negru";
            anuntSelectatProp.numeVanzator = numeVanzatorTxt.Text;
            anuntSelectatProp.dataTranzactie = dataTxt.Text;
            try
            {
                anuntSelectatProp.pretProp = Convert.ToDouble(pretTxt.Text);
            }
            catch (Exception)
            {
                pretLbl.ForeColor = Color.Red;
                pretTxt.Text = "";

            }
            anuntSelectatProp.tipMasina = tipCmbBox.Text;

            anuntSelectatProp.Optiuni = new ArrayList();
            anuntSelectatProp.Optiuni.AddRange(optiuniSelectate);

            string optMas = OptiuniAsString();

            anuntSelectatProp.optiuniMasina = optMas.Split(',');
            File.WriteAllText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\AnunturiSalvate.txt", String.Empty);
            foreach (Anunt m in ManagerAnunturi.getAnunturi())
            {
                adminAnunturi.AddAnunt(m);
            }

            //anuntSelectatProp.Optiuni=optiuniSelectate;

            this.Close();


        }

        private void ckbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string disciplinaSelectata = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(disciplinaSelectata);
            else
                optiuniSelectate.Remove(disciplinaSelectata);
        }
    }
}
