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
using MySql.Data;
using Meniu;

namespace LoginSystem
{
    public partial class LoginForm : Form
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3325;username=root;password=;database=proiectpiu");
        

        public LoginForm()
        {
            InitializeComponent();
            passwordTxt.AutoSize = false;
            passwordTxt.Size = new Size(passwordTxt.Width, 50);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DB dB = new DB();

            string utilizatorText = userTxt.Text;
            string parolaText = passwordTxt.Text;

            //dB.deschideConexiunea();

            DataTable tabel = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand comanda = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass",dB.getConexiune());

            comanda.Parameters.Add("@usn", MySqlDbType.VarChar).Value = utilizatorText;
            comanda.Parameters.Add("@pass", MySqlDbType.VarChar).Value = parolaText;

            adapter.SelectCommand = comanda;

            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                this.Hide();
                MeniuAplicatie meniuAplicatie = new MeniuAplicatie(userTxt.Text.ToString().Trim());
                meniuAplicatie.Show();
            }
            else
            {
                if (utilizatorText.Trim().Equals(""))
                {
                    MessageBox.Show("Introduceti username-ul pentru a intra","Username incomplet",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                else
                {
                    if (parolaText.Trim().Equals(""))
                    {
                        MessageBox.Show("Introduceti parola pentru a intra", "Parola incompleta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Username sau parola gresita", "Date incorecte", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
