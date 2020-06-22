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
using ProiectMasini_FormsT10;

namespace Meniu
{
    public partial class TopMasini : UserControl
    {
        public TopMasini()
        {
            InitializeComponent();
        }

        private void cautat21_Load(object sender, EventArgs e)
        {

        }

        private void cautaAltaMasinaBtn_Click(object sender, EventArgs e)
        {
            CautareForm cautareForm = new CautareForm();
            cautareForm.Show();
        }

        private void TopMasini_Load(object sender, EventArgs e)
        {

        }
    }
}
