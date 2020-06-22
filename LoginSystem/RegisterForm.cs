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
using MySql.Data.MySqlClient;

namespace LoginSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            //defocusare asupra casutelor text
            this.ActiveControl = regLbl;
        }

        private void numeTxt_Enter(object sender, EventArgs e)
        {
            string numeCtr = numeTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("nume"))
            {
                numeTxt.Text = "";
                numeTxt.ForeColor = Color.Black;
            }
        }

        private void numeTxt_Leave(object sender, EventArgs e)
        {
            string numeCtr = numeTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("nume")||numeCtr.Trim().Equals(""))
            {
                numeTxt.Text = "nume";
                numeTxt.ForeColor = Color.Gray;
            }
        }

        private void prenumeTxt_Enter(object sender, EventArgs e)
        {
            string numeCtr = prenumeTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("prenume"))
            {
                prenumeTxt.Text = "";
                prenumeTxt.ForeColor = Color.Black;
            }
        }

        private void prenumeTxt_Leave(object sender, EventArgs e)
        {
            string numeCtr = prenumeTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("prenume") || numeCtr.Trim().Equals(""))
            {
                prenumeTxt.Text = "prenume";
                prenumeTxt.ForeColor = Color.Gray;
            }
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            string numeCtr = emailTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("adresa email"))
            {
                emailTxt.Text = "";
                emailTxt.ForeColor = Color.Black;
            }
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            string numeCtr = emailTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("adresa email") || numeCtr.Trim().Equals(""))
            {
                emailTxt.Text = "adresa email";
                emailTxt.ForeColor = Color.Gray;
            }
        }

        private void usernameTxt_Enter(object sender, EventArgs e)
        {
            string numeCtr = usernameTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("username"))
            {
                usernameTxt.Text = "";
                usernameTxt.ForeColor = Color.Black;
            }
        }

        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            string numeCtr = usernameTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("username") || numeCtr.Trim().Equals(""))
            {
                usernameTxt.Text = "username";
                usernameTxt.ForeColor = Color.Gray;
            }
        }

        private void parolaTxt_Enter(object sender, EventArgs e)
        {
            string numeCtr = parolaTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("parola"))
            {
                parolaTxt.Text = "";
                parolaTxt.UseSystemPasswordChar = true;
                parolaTxt.ForeColor = Color.Black;
            }
        }

        private void parolaTxt_Leave(object sender, EventArgs e)
        {
            string numeCtr = parolaTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("parola") || numeCtr.Trim().Equals(""))
            {
                parolaTxt.Text = "parola";
                parolaTxt.UseSystemPasswordChar = false;
                parolaTxt.ForeColor = Color.Gray;
            }
        }

        private void confirmareTxt_Enter(object sender, EventArgs e)
        {
            string numeCtr = confirmareTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("confirmare parola"))
            {
                confirmareTxt.Text = "";
                confirmareTxt.UseSystemPasswordChar = true;
                confirmareTxt.ForeColor = Color.Black;
            }
        }

        private void confirmareTxt_Leave(object sender, EventArgs e)
        {
            string numeCtr = confirmareTxt.Text;
            if (numeCtr.ToLower().Trim().Equals("confirmare parola") ||
                numeCtr.ToLower().Trim().Equals("parola")||numeCtr.Trim().Equals(""))
            {
                confirmareTxt.Text = "confirmare parola";
                confirmareTxt.UseSystemPasswordChar = false;
                confirmareTxt.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            MySqlCommand comanda = new MySqlCommand("INSERT INTO `users`(`nume`, `prenume`, `email`, `username`, `password`) VALUES (@nm, @pn, @email, @usn, @pass)", dB.getConexiune());
            comanda.Parameters.Add("@nm", MySqlDbType.VarChar).Value = numeTxt.Text;
            comanda.Parameters.Add("@pn", MySqlDbType.VarChar).Value = prenumeTxt.Text;
            comanda.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTxt.Text;
            comanda.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usernameTxt.Text;
            comanda.Parameters.Add("@pass", MySqlDbType.VarChar).Value = parolaTxt.Text;

            dB.deschideConexiunea();

            if (!verificaValoriInitiale())
            {

                if (parolaTxt.Text.Equals(confirmareTxt.Text))
                {
                    if (verificaExistentaUser())
                    {
                        MessageBox.Show("Acest user exista deja, incercati alt nume","username duplicat",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    else
            if (comanda.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Contul dumneavoastra a fost creat","Cont creat",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Eroare");
                    }
                }
                else
                {
                    MessageBox.Show("Confirmare parola gresita","Eroare parola",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Introduceti prima data informatiile dumneavoastra","Date incomplete",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

            
            dB.inchideConexiunea();

        }

        public Boolean verificaExistentaUser()
        {

            DB dB = new DB();

            string utilizatorText = usernameTxt.Text;

            //dB.deschideConexiunea();

            DataTable tabel = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand comanda = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", dB.getConexiune());

            comanda.Parameters.Add("@usn", MySqlDbType.VarChar).Value = utilizatorText;

            adapter.SelectCommand = comanda;

            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean verificaValoriInitiale()
        {
            string numeCrt = numeTxt.Text;
            string prenumeCrt = prenumeTxt.Text;
            string emailCrt = emailTxt.Text;
            string usernameCrt = usernameTxt.Text;
            string parolaCrt = parolaTxt.Text;

            if (numeCrt.Equals("nume") || prenumeCrt.Equals("prenume") ||
                emailCrt.Equals("email") || usernameCrt.Equals("username") || parolaCrt.Equals("parola"))
            {
                return true;
            }
            else
                return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
