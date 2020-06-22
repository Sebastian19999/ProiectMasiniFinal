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
    public partial class ModificaUserControl : UserControl
    {
        public ModificaUserControl()
        {
            InitializeComponent();
        }

        private void modificaBtn_Click(object sender, EventArgs e)
        {
            AfiseazaDateCaracteristice afiseazaDateCaracteristice = new AfiseazaDateCaracteristice();
            afiseazaDateCaracteristice.Show();
        }

        private void ModificaUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
