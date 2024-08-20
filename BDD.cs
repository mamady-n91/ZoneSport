using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using System.IO;
using Google.Protobuf;
using System.Runtime.InteropServices;

namespace PPE2
{
    public static class BDD
    {
        private static MySqlConnection connection;
        private static string infoConnection;
        private static MySqlDataReader reader;
        public static int utilisateur;
        public static List<int> MesProduitsPanier = new List<int>();
        public static int noCommande;
        public static string typeCompte;


        public static bool ConnexionBdd()
        {
            infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
            connection = new MySqlConnection(infoConnection);
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message + "Impossible de se connecter à la base, veuillez réesayez !");
                return false;
            }
        }

        public static bool DeconnectBdd()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException err)
            {

                MessageBox.Show(err.Message);
                return false;

            }

        }


        public static bool Authentification (string pseudo, string mdp)
        {
            bool CompteExiste = false;
            ConnexionBdd();
            string VerifCompte = "SELECT NO_COMPTE,PSEUDO, MDP,CODE_TYPE_COMPTE FROM COMPTE WHERE PSEUDO = ?pseudo AND MDP= ?mdp";
            MySqlCommand cmd = new MySqlCommand(VerifCompte, connection);
            cmd.Parameters.Add("?pseudo", MySqlDbType.VarChar).Value = pseudo;
            cmd.Parameters.Add("?mdp", MySqlDbType.VarChar).Value = mdp;

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                typeCompte = reader.GetString("CODE_TYPE_COMPTE");
                CompteExiste= true;
                
            }
            reader.Close();
            return CompteExiste;
        }

        public static int GetNoCompte(string pseudo, string mdp)
        {
            int noCompte = 0;
            
            ConnexionBdd();
            string VerifCompte = "SELECT NO_COMPTE FROM COMPTE WHERE PSEUDO = ?pseudo AND MDP= ?mdp AND CODE_TYPE_COMPTE = 'CLT'";
            MySqlCommand cmd = new MySqlCommand(VerifCompte, connection);
            cmd.Parameters.Add("?pseudo", MySqlDbType.VarChar).Value = pseudo;
            cmd.Parameters.Add("?mdp", MySqlDbType.VarChar).Value = mdp;

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                noCompte = reader.GetInt32("NO_COMPTE");
                reader.Close();
            }

            return noCompte;
        }

        public static void ModifProduit (int noProduit,string unCodeCateg, string unNomProduit, string unCodeMarque, float unPrixTarif, int unSeuilReappro) 
        {

            ConnexionBdd();
            string requeteModif = "UPDATE PRODUIT SET CODE_CATEG_PROODUIT = ?codeCateg, NOM_PRODUIT = ?nomProduit, CODE_MARQUE = ?codeMarque, PRIX_TARIF = ?prixTarif, SEUIL_REAPPRO = ?seuilReappro WHERE NO_PRODUIT = ?noProduit";
            MySqlCommand cmd = new MySqlCommand(requeteModif, connection);
            MessageBox.Show(requeteModif);
            cmd.Parameters.Add("?codeCateg", MySqlDbType.VarChar).Value = unCodeCateg;
            cmd.Parameters.Add("?nomProduit", MySqlDbType.VarChar).Value = unNomProduit;
            cmd.Parameters.Add("?codeMarque", MySqlDbType.VarChar).Value = unCodeMarque;
            cmd.Parameters.Add("?prixTarif", MySqlDbType.Float).Value = unPrixTarif;
            cmd.Parameters.Add("?seuilReappro", MySqlDbType.Int32).Value = unSeuilReappro;
            cmd.Parameters.Add("?noProduit", MySqlDbType.Int32).Value = noProduit;


            if (cmd.ExecuteNonQuery() ==1)
            {
                MessageBox.Show("La modification a bien fonctionné");
            }
            



        }
        
        public static void SelectInfoProduit(int noProduit) 
        {
            string selectQuery = "SELECT CODE_CATEG_PRODUIT, NOM_PRODUIT,CODE_MARQUE,DT_AJOUT_STOCK,PRIX_TARIF,SEUIL_REAPPRO FROM PRODUIT WHERE NO_PRODUIT =?noProduit";
        }


        
        public static void AjouterCodeLibelle(string nomTable, string nomClePrimaire, string code, string libelle)
        {

            ConnexionBdd();
            string selectCategorie = "SELECT" + " " + nomClePrimaire + " FROM " + nomTable + " " + "WHERE" + " " + nomClePrimaire + " = " + "'" + code + "'";
            MySqlCommand select = new MySqlCommand(selectCategorie, connection);

            MessageBox.Show(select.CommandText);

            reader = select.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Oups le code existe déjà");

            }



            else if (reader.Read() == false)
            {
                ConnexionBdd();
                string insertCategorie = "INSERT INTO" + " " + nomTable + "   (" + nomClePrimaire + ",LIBELLE) VALUES ('" + code + "'," + "'" + libelle + "')";

                MySqlCommand cmd = new MySqlCommand(insertCategorie, connection);
                MessageBox.Show(cmd.CommandText);


                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("L'insertion a bien fonctionné");
                    CategProduit c = new CategProduit(code, libelle);
                    CategProduit.AjouterCategorie(c);
                   
                }
                else if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Oups l\'insertion n\'a pas fonctionnée, veuillez réesayez");
                    
                }
                reader.Close();
            }

        }
        public static void AjouterNouveauProduit(string unCodeCateg, string unNomProduit, string unCodeMarque, DateTime uneDtStock, float unPrixTarif, int unSeuilReappro, FileStream uneImage)
        {
            ConnexionBdd();
            string selectProduit = "SELECT CODE_CATEG_PRODUIT,NOM_PRODUIT,CODE_MARQUE FROM PRODUIT WHERE CODE_CATEG_PRODUIT=?codeCategProduit AND NOM_PRODUIT=?nomProduit AND CODE_MARQUE=?codeMarque";
            MySqlCommand select = new MySqlCommand(selectProduit, connection);

            select.Parameters.Add("?codeCategProduit", MySqlDbType.VarChar).Value = unCodeCateg;
            select.Parameters.Add("?nomProduit", MySqlDbType.VarChar).Value = unNomProduit;
            select.Parameters.Add("?codeMarque", MySqlDbType.VarChar).Value = unCodeMarque;

            reader = select.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Oups un produit avec les mêmes informations précises existe");
               
            }



            else if (!reader.Read())
            {
                ConnexionBdd();

                byte[] picbyte = new byte[uneImage.Length];
                uneImage.Read(picbyte, 0, Convert.ToInt32(uneImage.Length));
                uneImage.Close();
                string insertProduit = "INSERT INTO PRODUIT (CODE_CATEG_PRODUIT, NOM_PRODUIT,CODE_MARQUE,DT_AJOUT_STOCK,PRIX_TARIF,SEUIL_REAPPRO,PHOTO_PRODUIT) " +
                    "VALUES (?codeCategProduit ,?nomProduit,?codeMarque,?dtStock,?prixTarif,?seuilReappro,?imageProduit)";
                MySqlCommand cmd = new MySqlCommand(insertProduit, connection);

                cmd.Parameters.Add("?codeCategProduit", MySqlDbType.VarChar).Value = unCodeCateg;
                cmd.Parameters.Add("?nomProduit", MySqlDbType.VarChar).Value = unNomProduit;
                cmd.Parameters.Add("?codeMarque", MySqlDbType.VarChar).Value = unCodeMarque;
                cmd.Parameters.Add("?dtStock", MySqlDbType.Date).Value = uneDtStock; ;
                cmd.Parameters.Add("?prixTarif", MySqlDbType.Float).Value = unPrixTarif;
                cmd.Parameters.Add("?seuilReappro", MySqlDbType.Int32).Value = unSeuilReappro;
                cmd.Parameters.Add("?imageProduit", MySqlDbType.LongBlob).Value = picbyte;
                MessageBox.Show(cmd.CommandText);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("L'insertion a bien fonctionné");
                    //Produit p = new Produit(unNomProduit, unCodeCateg, unNomProduit, uneQuantiteDispo, unPrixTarif, unSeuilReapro, uneImage);
                    // Produit.AjouterProduit(p);
                    BDD.DeconnectBdd();
                }
                else if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Oups l\'insertion n\'a pas fonctionnée, veuillez réesayez");
                    DeconnectBdd();
                }


            }
            reader.Close();
        }

        public static void AjouterCompteClient(string pseudo,string nomCompte, string prenomCompte, DateTime dtNaissance, string adresse, string ville, string cp, int tel, string mail, string mdp)
        {
            ConnexionBdd();
            
            string selectCompte = "SELECT CODE_TYPE_COMPTE,MAIL,MDP FROM COMPTE WHERE CODE_TYPE_COMPTE = 'CLT' AND MAIL =?mail AND MDP =?mdp OR PSEUDO=?pseudo AND DT_DESINSCRIPTION IS NULL";
            MySqlCommand testCompte = new MySqlCommand(selectCompte, connection);
            testCompte.Parameters.Add("?pseudo", MySqlDbType.VarChar).Value = pseudo;
            testCompte.Parameters.Add("?mail", MySqlDbType.VarChar).Value = mail;
            testCompte.Parameters.Add("?mdp", MySqlDbType.VarChar).Value = mdp;

            reader = testCompte.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Attention, un compte avec les mêmes informations précises existe");
                DeconnectBdd();
            }
            else if (reader.Read() == false)
            {
                ConnexionBdd();
                string selectCompte2 = "SELECT CODE_TYPE_COMPTE,NOM_COMPTE,PRENOM_COMPTE,ADRESSE,VILLE,CODE_POSTAL,TELEPHONE FROM COMPTE WHERE CODE_TYPE_COMPTE='CLT' AND NOM_COMPTE = ?nom AND PRENOM_COMPTE = ?prenom AND ADRESSE = ?adresse AND VILLE = ?ville AND CODE_POSTAL =?cp AND DT_INSCRIPTION IS NOT NULL";
                MySqlCommand cmd = new MySqlCommand(selectCompte2, connection);                cmd.Parameters.Add("?nom", MySqlDbType.VarChar).Value = nomCompte;
                cmd.Parameters.Add("?prenom", MySqlDbType.VarChar).Value = prenomCompte;
                cmd.Parameters.Add("?adresse", MySqlDbType.VarChar).Value = adresse;
                cmd.Parameters.Add("?ville", MySqlDbType.VarChar).Value = ville;
                cmd.Parameters.Add("?cp", MySqlDbType.Int16).Value = cp;
                MessageBox.Show(cmd.CommandText);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Vérifiez que vous n'êtes pas déjà inscrit, les informations entrées existent déjà");
                    
                }

                else if (reader.Read() == false)
                {
                    ConnexionBdd();
                    string infoCompteInsert = "INSERT INTO COMPTE (PSEUDO,CODE_TYPE_COMPTE,NOM_COMPTE,PRENOM_COMPTE,DT_NAISSANCE,ADRESSE,VILLE,CODE_POSTAL,TELEPHONE,MAIL,MDP,DT_INSCRIPTION) VALUES(?pseudo,'CLT',?nom,?prenom,?dtNaiss,?adresse,?ville,?codePostal,?telephone,?mail,?mdp,CURDATE()) ";
                    MySqlCommand insertCompte = new MySqlCommand(infoCompteInsert, connection);
                    insertCompte.Parameters.Add("?pseudo", MySqlDbType.VarChar).Value = pseudo;
                    insertCompte.Parameters.Add("?nom", MySqlDbType.VarChar).Value = nomCompte;
                    insertCompte.Parameters.Add("?prenom", MySqlDbType.VarChar).Value = prenomCompte;
                    insertCompte.Parameters.Add("?dtNaiss", MySqlDbType.Date).Value = dtNaissance;
                    insertCompte.Parameters.Add("?adresse", MySqlDbType.VarChar).Value = adresse;
                    insertCompte.Parameters.Add("?ville", MySqlDbType.VarChar).Value = ville;
                    insertCompte.Parameters.Add("?telephone", MySqlDbType.Int32).Value = tel;
                    insertCompte.Parameters.Add("?codePostal", MySqlDbType.Int16).Value = cp;
                    insertCompte.Parameters.Add("?mail", MySqlDbType.VarChar).Value = mail;
                    insertCompte.Parameters.Add("?mdp", MySqlDbType.VarChar).Value = mdp;
                    MessageBox.Show(insertCompte.CommandText);

                    if (insertCompte.ExecuteNonQuery() == 1)
                    {
                        const string message =
                        "Excellent, l'insertion a bien, fonctionné";
                        const string caption = "Form Closing";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Information);
                        
                    }

                }

            }

            reader.Close();


        }

        public static DataTable tablePanier(List<int> lesNoProduits) 
        {
            string lesNumerosProduit = "";
            for (int i = 0; i< lesNoProduits.Count; i++)
            {
                lesNumerosProduit += "," + lesNoProduits[i] ;
            }
            string lesNumero2 = "";
            for (int i = 1; i < lesNumerosProduit.Length; i++)
            {
                lesNumero2 += lesNumerosProduit[i];
            }
            string query = "SELECT NO_PRODUIT,CATEGORIE_PRODUIT.LIBELLE AS CATEGORIE_PRODUIT, NOM_PRODUIT,MARQUE.LIBELLE AS MARQUE_PRODUIT,PRIX_TARIF,QUANTITE_DISPO,PHOTO_PRODUIT FROM produit,categorie_produit,marque WHERE produit.CODE_CATEG_PRODUIT = categorie_produit.CODE_CATEG_PRODUIT AND produit.CODE_MARQUE = marque.CODE_MARQUE AND NO_PRODUIT IN(" + lesNumero2 + ")";
            MySqlDataAdapter dtAdapterPanier = new MySqlDataAdapter(query, connection);

            DataTable dtTablePanier = new DataTable();
            dtAdapterPanier.Fill(dtTablePanier);
            return dtTablePanier;
        }

        public static int GetAge(DateTime dtNaissance)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dtNaissance.Year;
            if (dtNaissance > today.AddYears(-age))
                age--;

            return age;
        }

        public static bool VerifCpVille(string cp, string ville)
        {
            bool cpExiste = false;
            ConnexionBdd();
            string reqVerifCpVille = "SELECT NomVille,CodePostal FROM VILLE WHERE NomVille = ?ville AND CodePostal =?cp";
            MySqlCommand cmd = new MySqlCommand(reqVerifCpVille, connection);
            cmd.Parameters.Add("?ville", MySqlDbType.VarChar).Value = ville;
            cmd.Parameters.Add("?cp", MySqlDbType.Int32).Value = cp;

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cpExiste= true;
            }

            reader.Close();
            return cpExiste;

        }
        public static int AjouterCommande(int noCompte, DateTime dtCommande) 
        {
            MySqlDataReader reader;
            int noCommande = 0;
            ConnexionBdd();
            string insertCommande = "INSERT INTO COMMANDE (NO_COMPTE,DT_COMMANDE) VALUES(?noCompte,?dtCommande)";
            MySqlCommand cmd = new MySqlCommand(insertCommande, connection);

            cmd.Parameters.Add("?noCompte", MySqlDbType.Int32).Value = noCompte;
            cmd.Parameters.Add("?dtCommande", MySqlDbType.Date).Value = dtCommande;
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("L'insertion a bien fonctionné");
            }

            string selectCommandeRecent = "SELECT NO_COMMANDE FROM COMMANDE WHERE NO_COMPTE =?noCompte AND DT_COMMANDE = ?dtCommande ORDER BY NO_COMMANDE DESC LIMIT 1";

            MySqlCommand selectNoCommandLigne = new MySqlCommand(selectCommandeRecent, connection);

            selectNoCommandLigne.Parameters.Add("?noCompte", MySqlDbType.Int32).Value = noCompte;
            selectNoCommandLigne.Parameters.Add("?dtCommande", MySqlDbType.Date).Value = dtCommande;
            reader =selectNoCommandLigne.ExecuteReader();

            if (reader.Read())
            {
                 noCommande = reader.GetInt32("NO_COMMANDE");

            }
            reader.Close();
            return noCommande;



            
        }
        
        public static bool AjoutLigneCommande(int noProduit, int noCommande, int quantite, DateTime dtLivraison) 
        {
            bool ligneAffectee = false;
            string insertCommande = "INSERT INTO LIGNE_COMMANDE (NO_PRODUIT,NO_COMMANDE,QUANTITE_COMMANDE,DT_LIVRAISON) VALUES(?noProduit,?noCommande,?qtCommande,?dtLivraison)";

            MySqlCommand insertLigneCommande = new MySqlCommand(insertCommande, connection);

            insertLigneCommande.Parameters.Add("?noProduit", MySqlDbType.Int32).Value = noProduit;
            insertLigneCommande.Parameters.Add("?noCommande", MySqlDbType.Int32).Value = noCommande;
            insertLigneCommande.Parameters.Add("?qtCommande", MySqlDbType.Int32).Value = quantite;
            insertLigneCommande.Parameters.Add("?dtLivraison", MySqlDbType.Date).Value = dtLivraison.AddDays(4);
            insertLigneCommande.ExecuteNonQuery();

            return ligneAffectee;
        }

        public static List<string>[] Select()
        {
            string query = "SELECT LIBELLE FROM CATEGORIE_PRODUIT ORDER BY LIBELLE";
            List<string>[] listLibelleCateg = new List<string>[1];
            listLibelleCateg[0] = new List<string>();


            if (ConnexionBdd())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listLibelleCateg[0].Add(reader["libelle"] + "");
                }


                reader.Close();

                

                

            }


            return listLibelleCateg;



        }

        public static void SelectProduitPrix (float prixMin, float prixMax)
        {
           

            
            {
                string selectQuery = "SELECT NO_PRODUIT,CATEGORIE_PRODUIT.LIBELLE AS CATEGORIE_PRODUIT, NOM_PRODUIT,MARQUE.LIBELLE AS MARQUE_PRODUIT,PRIX_TARIF,QUANTITE_DISPO FROM produit,categorie_produit,marque WHERE PRODUIT.CODE_CATEG_PRODUIT = categorie_produit.CODE_CATEG_PRODUIT AND produit.CODE_MARQUE = marque.CODE_MARQUE AND PRIX_TARIF >= ?prixMin AND PRIX_TARIF <= ?prixMax";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(selectQuery, connection);
                DataTable dtTable = new DataTable();
                dataAdapter.SelectCommand.Parameters.Add("?prixMin", MySqlDbType.Float).Value = prixMin;
                dataAdapter.SelectCommand.Parameters.Add("?prixMax", MySqlDbType.Float).Value = prixMax;
                dataAdapter.Fill(dtTable);
                
            }

           

        }

        public static bool RechercherElement(string element) 
        {
            ConnexionBdd();
            string rechercheElement = "SELECT ";
            return true;
            
        }

        public static void updateElementNumero(string nomTable, string champConcerne, string nouvValeur, int idElement)
        {
            ConnexionBdd();
            string requete = "UPDATE SET  ?champConcerne = nouvValeur  WHERE NO_+ ?table = ?idElement";
            MySqlCommand majElement = new MySqlCommand(requete,connection);
            majElement.Parameters.Add("?table", MySqlDbType.VarChar).Value = nomTable;
            majElement.Parameters.Add("?champConcerne", MySqlDbType.VarChar).Value = champConcerne;
            majElement.Parameters.Add("?nouvelleValeur", MySqlDbType.VarChar).Value = nouvValeur ;
            majElement.Parameters.Add("?idElement", MySqlDbType.VarChar).Value = idElement;

            if (majElement.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("La mise à jour à correctement fonctionnée");
                DeconnectBdd();
            }

            else if (majElement.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("La mise à jour ne s'est pas bien déroulée,réesayez ");
                DeconnectBdd();
            }

           
            
        }

        public static void updateElementType(string nomTable, string champConcerne, string nouvValeur, string idType)
        {
            ConnexionBdd();
            string requete = "UPDATE " + nomTable + "SET" + champConcerne + "=" + nouvValeur + "WHERE NO_+" + nomTable + "=" + idType;
            MySqlCommand majType = new MySqlCommand(requete,connection);

            majType.Parameters.Add("?table", MySqlDbType.VarChar).Value = nomTable;
            majType.Parameters.Add("?champConcerne", MySqlDbType.VarChar).Value = champConcerne;
            majType.Parameters.Add("?nouvelleValeur", MySqlDbType.VarChar).Value = nouvValeur;
            majType.Parameters.Add("?idType", MySqlDbType.VarChar).Value = idType;

            if (majType.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("La mise à jour à correctement fonctionnée");
                DeconnectBdd();
            }

            else if (majType.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("La mise à jour ne s'est pas bien déroulée,réesayez ");
                DeconnectBdd();
            }



        }

    }
}
  

