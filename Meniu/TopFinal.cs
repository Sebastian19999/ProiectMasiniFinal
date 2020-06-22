//GALAN CĂLIN SEBASTIAN, grupa 3123B

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using ManagerM;
using NivelAccesDate;
using ProiectMasini_FormsT10;

namespace Meniu
{
    public partial class TopFinal : UserControl
    {
        IStocareImagini adminImagini;
        public TopFinal()
        {
            InitializeComponent();
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopFinal_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            TopMasini2 topMasini2= new TopMasini2();
            topMasini2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CautareForm cautareForm = new CautareForm();
            cautareForm.Show();
        }
    }
}
