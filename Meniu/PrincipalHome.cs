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

namespace Meniu
{
    public partial class PrincipalHome : UserControl
    {
        public PrincipalHome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfisareTranzactii afisareTranzactii = new AfisareTranzactii();
            afisareTranzactii.Show();
        }

        private void PrincipalHome_Load(object sender, EventArgs e)
        {

        }
    }
}
