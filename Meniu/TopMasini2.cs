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
using ManagerM;
using NivelAccesDate;
using LibrarieModele;
using TopMasiniComplet;
using ProiectMasini_FormsT10;

namespace Meniu
{
    public partial class TopMasini2 : Form
    {
        IStocareImagini adminImagini;

        private Anunt locul1 { get; set; }
        private Anunt locul2 { get; set; }
        private Anunt locul3 { get; set; }


        public TopMasini2()
        {
            InitializeComponent();
            adminImagini = ManagerImg.ManagerImagini.GetAdministratorStocare();


            List<Anunt> top3Masini = ManagerAnunturi.top3Masini();

            Anunt[] topMasini = top3Masini.ToArray();

            Imagine imgFis1 = adminImagini.GetImagineByIndex(topMasini[0].getIdMasina() - 1);
            loc1Pct.ImageLocation = topMasini[0].locatieFotografie;
            locul1 = topMasini[0];
            label1.Text = topMasini[0].firmaProp; label4.Text=topMasini[0].modelProp;

            Imagine imgFis2 = adminImagini.GetImagineByIndex(topMasini[1].getIdMasina() - 1);
            loc2Pct.ImageLocation = topMasini[1].locatieFotografie;
            label2.Text = topMasini[1].firmaProp; label5.Text=topMasini[1].modelProp;
            locul2 = topMasini[1];

            Imagine imgFis3 = adminImagini.GetImagineByIndex(topMasini[2].getIdMasina() - 1);
            loc3Pct.ImageLocation = topMasini[2].locatieFotografie;
            label3.Text = topMasini[2].firmaProp; label6.Text=topMasini[2].modelProp;
            locul3 = topMasini[2];


        }

        private void TopMasini2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProiectMasini_FormsT10.AdaugareAnuntList adaugareAnuntList = new ProiectMasini_FormsT10.AdaugareAnuntList(locul1);
            adaugareAnuntList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProiectMasini_FormsT10.AdaugareAnuntList adaugareAnuntList = new ProiectMasini_FormsT10.AdaugareAnuntList(locul2);
            adaugareAnuntList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProiectMasini_FormsT10.AdaugareAnuntList adaugareAnuntList = new ProiectMasini_FormsT10.AdaugareAnuntList(locul3);
            adaugareAnuntList.Show();
        }
    }
}
