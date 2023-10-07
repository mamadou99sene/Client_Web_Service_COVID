using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Web_Service_COVID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Connexion_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text.Equals("") || textBox_Password.Text.Equals(""))
                {
                MessageBox.Show("Veuillez renseigner toutes le informations demandées");
            }
            else
            {
                this.Hide();
                MainApplication main=new MainApplication();
                main.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Inscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
        }
    }
}
