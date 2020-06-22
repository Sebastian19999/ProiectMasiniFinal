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
using ProiectMasini_FormsT10;

namespace Meniu
{
    public partial class MeniuAplicatie : Form
    {

        public string salvareUserMeniu { get; set; }
        public static string salvareUserMeniuStatic{get;set;}

        public MeniuAplicatie(string userTxt)
        {
            InitializeComponent();
            optiuniUser1.BringToFront();
            salvareUserMeniu = userTxt;
            salvareUserMeniuStatic = userTxt;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            optiuniUser1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topFinal1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            principalHome1.BringToFront();
        }

        private void optiuniUser1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdaugareForm adaugareForm = new AdaugareForm(salvareUserMeniu);
            adaugareForm.ShowDialog();
        }

        private void closeLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificaBtn_Click(object sender, EventArgs e)
        {
            modificaUserControl1.BringToFront();
        }
    }
}
