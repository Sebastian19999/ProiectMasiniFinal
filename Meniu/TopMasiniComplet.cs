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

namespace Meniu
{
    public partial class TopMasiniComplet : Form
    {
        public TopMasiniComplet()
        {
            InitializeComponent();
        }

        private void TopMasiniComplet_Load(object sender, EventArgs e)
        {
            int[] idMasini = ManagerAnunturi.topMasiniComplet();

            
        }
    }
}
