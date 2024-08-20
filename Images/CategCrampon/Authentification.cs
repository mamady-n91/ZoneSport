using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE2.Images.CategCrampon
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void gpBoxFormInscrip_Enter(object sender, EventArgs e)
        {

        }

        private void btnValiderCnx_Click(object sender, EventArgs e)
        {
            

            if (txtBoxPseudo.Text != "" && txtBoxMdp.Text != "")
            {

                if (BDD.Authentification(txtBoxPseudo.Text,txtBoxMdp.Text))
                {
                    BDD.utilisateur = BDD.GetNoCompte(txtBoxPseudo.Text, txtBoxMdp.Text);
                    Accueil accueil = new Accueil();
                    accueil.ShowDialog();




                }

                else
                {

                    MessageBox.Show("Le compte n'existe pas ou les informations sont mauvaises");

                }

            }
            else
            {
                
                
                    MessageBox.Show("Les champs n'ont pas été saisis.");


              }
          
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Inscription FormInscription = new Inscription();
            FormInscription.ShowDialog();
        }
    }
}
