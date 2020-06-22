//GALAN CĂLIN SEBASTIAN 3123B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibrarieModele;
using ManagerM;
using NivelAccesDate;
using ProiectMasini_FormsT10;

namespace TopMasiniComplet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


        public class AnunturiLista
    {
        public int idAnunt { get; set; }
        public string numeAnunt { get; set; }
        public string locatieImagine { get; set; }
        public string numarCautari { get; set; }
    }

    public partial class MainWindow : Window
    {
        public List<AnunturiLista> salvareTop { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            List<Anunt> topAnunturi = ManagerAnunturi.getTopMasiniComplet();
            List < AnunturiLista > anunturiLista= new List<AnunturiLista>();

            foreach (Anunt ant in topAnunturi)
            {
                anunturiLista.Add(new AnunturiLista()
                {
                    idAnunt = ant.getIdMasina(),
                    numeAnunt = ant.firmaProp + " " + ant.modelProp,
                    locatieImagine = ant.locatieFotografie,
                    numarCautari=ant.nrCautari.ToString()
                    
                });
            }

            salvareTop = anunturiLista;

            //anunturiLista.Add(new AnunturiLista()
            //{
            //    idAnunt=1,
            //    numeAnunt="Ford Mondeo",
            //    locatieImagine= @"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\listaMasiniImagini\3.jpg"
            //});
            listView1.ItemsSource = anunturiLista;
        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AnunturiLista[] anunturiChanged = salvareTop.ToArray();

            int id = listView1.SelectedIndex;
            int gasireID = anunturiChanged[id].idAnunt;
            Anunt mas = ManagerAnunturi.getMasina(gasireID);
            AdaugareAnuntList addAnuntList = new AdaugareAnuntList(mas);
            addAnuntList.Show();
            this.Close();
        }
    }
}
