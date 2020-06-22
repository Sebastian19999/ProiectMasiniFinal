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
    public partial class OptiuniUser : UserControl
    {
        public OptiuniUser()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaMasiniBuy listaMasiniBuyForm = new ListaMasiniBuy();
            listaMasiniBuyForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdaugareForm listMasiniSellForm = new AdaugareForm(MeniuAplicatie.salvareUserMeniuStatic);
            listMasiniSellForm.ShowDialog();
        }

        private void OptiuniUser_Load(object sender, EventArgs e)
        {

        }
    }
}
