using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PPE2
{
    public partial class AjoutCategorie : Form

    {
        OpenFileDialog parcourir;

        public AjoutCategorie()
        {
            InitializeComponent();

        }

        private void AjoutCategorie_Load(object sender, EventArgs e)
        {
            try
            {
                string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                MySqlConnection connection = new MySqlConnection(infoConnection);
                string selectQuery = "SELECT CODE_CATEG_PRODUIT FROM CATEGORIE_PRODUIT";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbBoxCodeCategProduit.Items.Add(reader.GetString("CODE_CATEG_PRODUIT"));
                }


            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                MySqlConnection connection = new MySqlConnection(infoConnection);
                string selectQuery = "SELECT CODE_MARQUE FROM MARQUE";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbBoxCodeMarque.Items.Add(reader.GetString("CODE_MARQUE"));
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            

        }

        private void btnInsertCategorie_Click(object sender, EventArgs e)
        {
            if (txtBoxCdeCategProduit.Text != "" && txtBoxLibelleCateg.Text != "")
            {
                if (txtBoxCdeCategProduit.TextLength < 4 || txtBoxLibelleCateg.TextLength < 4)
                {
                    MessageBox.Show("Attention 4 caractères minimum pour les deux champs");
                }
                else
                {


                    BDD.AjouterCodeLibelle("CATEGORIE_PRODUIT", "CODE_CATEG_PRODUIT", txtBoxCdeCategProduit.Text, txtBoxLibelleCateg.Text);
                }
            }
            if (txtBoxCdeCategProduit.Text == "" || txtBoxLibelleCateg.Text == "")
            {
                MessageBox.Show("Un ou plusieurs champs n'ont pas été saisis !");
            }
        }


        private void btnAjoutImg_Click(object sender, EventArgs e)
        {

            parcourir = new OpenFileDialog();
            parcourir.Filter = "*.BMP; *.JPG; *.JPEG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF *.PNG";
            if (parcourir.ShowDialog() == DialogResult.OK)
            {
                

                pctBxImgProduit.Image = new Bitmap(parcourir.FileName);
            }


        }





        private void btnInsertProduit_Click(object sender, EventArgs e)
        {


            if (btnInsertProduit.Text == "Valider l'ajout du produit")
            {


                if (string.IsNullOrEmpty(cbBoxCodeCategProduit.Text) == false && txtBoxNomProduit.Text != "" && cbBoxCodeMarque.Text != "")

                {
                    if (txtBoxNomProduit.TextLength < 5)
                    {
                        MessageBox.Show("Attention le nom de produit, doit être de 5 caractères minimum");
                    }
                    else
                    {

                        FileStream fs = new FileStream(parcourir.FileName, FileMode.Open, FileAccess.Read);

                        BDD.AjouterNouveauProduit(cbBoxCodeCategProduit.Text, txtBoxNomProduit.Text, cbBoxCodeMarque.Text, dtPckrAjoutStock.Value, (float)numUpDownPrixTarif.Value, (int)numUpDownSeuilReap.Value, fs);


                    }
                }


                if (string.IsNullOrEmpty(cbBoxCodeCategProduit.Text) == true || txtBoxNomProduit.Text == "" || cbBoxCodeMarque.Text == "")
                {
                    MessageBox.Show("Une ou plusieurs informations n'ont pas été saisies");
                }
            }

            if (btnInsertProduit.Text == "Modifier")
            {
                if (string.IsNullOrEmpty(cbBoxCodeCategProduit.Text) == false && txtBoxNomProduit.Text != "" && cbBoxCodeMarque.Text != "")

                {
                    if (txtBoxNomProduit.TextLength < 5)
                    {
                        MessageBox.Show("Attention le nom de produit, doit être de 5 caractères minimum");
                    }
                    else
                    {
                        BDD.ModifProduit(int.Parse(txtBoxNoProduit.Text), cbBoxCodeCategProduit.Text, txtBoxNomProduit.Text, cbBoxCodeMarque.Text, float.Parse(numUpDownPrixTarif.Value.ToString()), int.Parse(numUpDownSeuilReap.Value.ToString()));
                    }


                }

            }




        }

        private void btnInsertMarque_Click(object sender, EventArgs e)
        {
           
           
            

            if (txtBoxCodeMarque.Text != "" && txtBoxLibelleMarque.Text != "")
            {

                if (txtBoxCodeMarque.TextLength < 4 || txtBoxLibelleMarque.TextLength < 4)
                {
                    MessageBox.Show("Attention 4 caractères minimum pour les deux champs");
                }
                else
                {
                    BDD.AjouterCodeLibelle("MARQUE", "CODE_MARQUE", txtBoxCodeMarque.Text, txtBoxLibelleMarque.Text);

                }
            }

            if (txtBoxCodeMarque.Text == "" || txtBoxLibelleMarque.Text == "")
            {
                MessageBox.Show("Un ou plusieurs champs n'ont pas été saisis !");

            }

        }

        private void txtBoxNomProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

       

        private void txtBoxLibelleCateg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void txtBoxCodeMarque_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void txtBoxLibelleMarque_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void txtBoxCdeCategProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

         
        }

        private void txtBoxCdeCategProduit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

