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
using System.IO;

namespace PPE2
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }




        private void Accueil_Load(object sender, EventArgs e)
        {
            try
            {
                string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                MySqlConnection connection = new MySqlConnection(infoConnection);
                string selectQuery = "SELECT NO_PRODUIT,CATEGORIE_PRODUIT.LIBELLE AS CATEGORIE_PRODUIT, NOM_PRODUIT,MARQUE.LIBELLE AS MARQUE_PRODUIT,PRIX_TARIF, PHOTO_PRODUIT FROM produit,categorie_produit,marque WHERE PRODUIT.CODE_CATEG_PRODUIT = categorie_produit.CODE_CATEG_PRODUIT AND produit.CODE_MARQUE = marque.CODE_MARQUE";
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, connection);
                DataTable dtTable = new DataTable();
                dataAdapter.Fill(dtTable);
                dtGridViewProduits.RowTemplate.Height = 125;
                dtGridViewProduits.AutoGenerateColumns = false;
                dtGridViewProduits.DataSource = dtTable;

            }


            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            try
            {
                string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                MySqlConnection connection = new MySqlConnection(infoConnection);
                string selectQuery = "SELECT CODE_MARQUE,LIBELLE FROM MARQUE";
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, connection);
                DataTable table = new DataTable("myTable");
                dataAdapter.Fill(table);




                cbBoxMarque.DisplayMember = "LIBELLE";
                cbBoxMarque.ValueMember = "CODE_MARQUE";
                cbBoxMarque.DataSource = table;



            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                MySqlConnection connection = new MySqlConnection(infoConnection);
                string selectQuery = "SELECT CODE_CATEG_PRODUIT, LIBELLE FROM CATEGORIE_PRODUIT";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("CATEGORIE_PRODUIT");
                dataAdapter.Fill(table);




                cbBoxCategProduit.DisplayMember = "LIBELLE";
                cbBoxCategProduit.ValueMember = "CODE_CATEG_PRODUIT";
                cbBoxCategProduit.DataSource = table;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            btnAjoutProduit.Visible = false;
            btnModifierProduit.Visible = false;

            if (BDD.typeCompte == "GEST" || BDD.typeCompte == "ADM")
            {
                btnAjoutProduit.Visible = true;
                btnModifierProduit.Visible = true;



            }

            


        }


        private void cbBoxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnShowTsLesProd_Click(object sender, EventArgs e)
        {

            try
            {

                string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                MySqlConnection connection = new MySqlConnection(infoConnection);
                string selectQuery = "SELECT NO_PRODUIT,CATEGORIE_PRODUIT.LIBELLE AS CATEGORIE_PRODUIT, NOM_PRODUIT,MARQUE.LIBELLE AS MARQUE_PRODUIT,PRIX_TARIF,QUANTITE_DISPO,PHOTO_PRODUIT FROM produit,categorie_produit,marque WHERE PRODUIT.CODE_CATEG_PRODUIT = categorie_produit.CODE_CATEG_PRODUIT AND produit.CODE_MARQUE = marque.CODE_MARQUE";
                connection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, connection);
                DataTable dtTable = new DataTable();
                dataAdapter.Fill(dtTable);
                dtGridViewProduits.DataSource = dtTable;

                //dataAdapter.Dispose();
            }


            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                BDD.DeconnectBdd();
            }
        }

        private void btnValiderCriteres_Click(object sender, EventArgs e)
        {



            string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
            MySqlConnection connection = new MySqlConnection(infoConnection);
            string selectQuery = "SELECT NO_PRODUIT,CATEGORIE_PRODUIT.LIBELLE AS CATEGORIE_PRODUIT, NOM_PRODUIT,MARQUE.LIBELLE AS MARQUE_PRODUIT,PRIX_TARIF,QUANTITE_DISPO,PHOTO_PRODUIT FROM produit,categorie_produit,marque WHERE PRODUIT.CODE_CATEG_PRODUIT = categorie_produit.CODE_CATEG_PRODUIT AND produit.CODE_MARQUE = marque.CODE_MARQUE  AND PRIX_TARIF >=" + numUpDownMin.Value + " AND PRIX_TARIF <=" + numUpDownMax.Value;
            connection.Open();

            MySqlDataAdapter dataAdapterPrix = new MySqlDataAdapter(selectQuery, connection);

            DataTable dtTablePrix = new DataTable();
            dataAdapterPrix.Fill(dtTablePrix);
            dtGridViewProduits.AutoGenerateColumns = false;
            dtGridViewProduits.DataSource = dtTablePrix;






        }

        private void btnValiderMarque_Click(object sender, EventArgs e)
        {



            string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
            MySqlConnection connection = new MySqlConnection(infoConnection);
            string selectQuery = "SELECT NO_PRODUIT,CATEGORIE_PRODUIT.LIBELLE AS CATEGORIE_PRODUIT, NOM_PRODUIT,MARQUE.LIBELLE AS MARQUE_PRODUIT,PRIX_TARIF,QUANTITE_DISPO,PHOTO_PRODUIT FROM produit,categorie_produit,marque WHERE PRODUIT.CODE_CATEG_PRODUIT = categorie_produit.CODE_CATEG_PRODUIT AND produit.CODE_MARQUE = marque.CODE_MARQUE AND MARQUE.CODE_MARQUE ='" + cbBoxMarque.SelectedValue + "'";
            connection.Open();
            MySqlDataAdapter dtAdapterMarque = new MySqlDataAdapter(selectQuery, connection);

            DataTable dtTableMarque = new DataTable();
            dtAdapterMarque.Fill(dtTableMarque);
            dtGridViewProduits.AutoGenerateColumns = false;
            dtGridViewProduits.DataSource = dtTableMarque;
        }

        private void btnValiderChoixCategProduit_Click(object sender, EventArgs e)
        {


            string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
            MySqlConnection connection = new MySqlConnection(infoConnection);
            string selectQuery = "SELECT NO_PRODUIT,CATEGORIE_PRODUIT.LIBELLE AS CATEGORIE_PRODUIT, NOM_PRODUIT,MARQUE.LIBELLE AS MARQUE_PRODUIT,PRIX_TARIF,QUANTITE_DISPO,PHOTO_PRODUIT FROM produit,categorie_produit,marque WHERE PRODUIT.CODE_CATEG_PRODUIT = categorie_produit.CODE_CATEG_PRODUIT AND produit.CODE_MARQUE = marque.CODE_MARQUE AND CATEGORIE_PRODUIT.CODE_CATEG_PRODUIT ='" + cbBoxCategProduit.SelectedValue + "'";
            MySqlDataAdapter dtAdapterCategProduit = new MySqlDataAdapter(selectQuery, connection);

            DataTable dtTableCategProduit = new DataTable();
            dtAdapterCategProduit.Fill(dtTableCategProduit);
            dtGridViewProduits.AutoGenerateColumns = false;
            dtGridViewProduits.DataSource = dtTableCategProduit;
        }

    

        

        private void btnAjoutPanier_Click(object sender, EventArgs e)
        {
            if (dtGridViewProduits.SelectedRows.Count == 1)
            {
                BDD.MesProduitsPanier.Add(int.Parse(dtGridViewProduits.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show("Le numéro de produit : "+ int.Parse(dtGridViewProduits.SelectedRows[0].Cells[0].Value.ToString())+" a été enregistré dans votre panier");


            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnConsulterPanier_Click(object sender, EventArgs e)
        {
            FormPanier monPanier = new FormPanier();
            monPanier.ShowDialog();
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjoutCategorie ajoutCateg = new AjoutCategorie();
            ajoutCateg.ShowDialog();

        }

        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";

            string selectQuery = "SELECT CODE_CATEG_PRODUIT, NOM_PRODUIT,CODE_MARQUE,DT_AJOUT_STOCK,PRIX_TARIF,SEUIL_REAPPRO FROM PRODUIT WHERE NO_PRODUIT =?noProduit";
            MySqlConnection connection = new MySqlConnection(infoConnection);
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            connection.Open();
            if (dtGridViewProduits.SelectedRows.Count == 1)
            {
                cmd.Parameters.Add("?noProduit", MySqlDbType.Int32).Value = int.Parse(dtGridViewProduits.SelectedRows[0].Cells[0].Value.ToString());




                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    AjoutCategorie ajoutCateg = new AjoutCategorie();
                    ajoutCateg.btnInsertProduit.Text = "Modifier";
                    ajoutCateg.pctBxImgProduit.Visible = false;
                    ajoutCateg.dtPckrAjoutStock.Visible = false;
                    ajoutCateg.btnAjoutImg.Visible = false;
                    ajoutCateg.txtBoxCodeMarque.Visible = false;
                    ajoutCateg.txtBoxLibelleMarque.Visible = false;
                    ajoutCateg.txtBoxCdeCategProduit.Visible = false;
                    ajoutCateg.txtBoxLibelleCateg.Visible = false;
                    ajoutCateg.btnInsertMarque.Visible = false;
                    ajoutCateg.btnInsertCategorie.Visible = false;
                    ajoutCateg.txtBoxNoProduit.Visible = true;



                    ajoutCateg.cbBoxCodeCategProduit.SelectedValue = rdr.GetString("CODE_CATEG_PRODUIT");
                    ajoutCateg.txtBoxNomProduit.Text = rdr.GetString("NOM_PRODUIT");
                    ajoutCateg.cbBoxCodeMarque.Text = rdr.GetString("CODE_MARQUE");
                    ajoutCateg.numUpDownPrixTarif.Value = decimal.Parse(rdr.GetDouble("PRIX_TARIF").ToString());
                    ajoutCateg.numUpDownSeuilReap.Value = rdr.GetInt32("SEUIL_REAPPRO");
                    ajoutCateg.txtBoxNoProduit.Text = dtGridViewProduits.SelectedRows[0].Cells[0].Value.ToString();


                    ajoutCateg.ShowDialog();
                }
            }
        }
    }
    }

