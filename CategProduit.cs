using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace PPE2
{
    public class CategProduit
    {
        private string codeCateg;
        private string libelle;
        static List<Produit> lesProduits;
         static List<CategProduit> lesCategories = new List<CategProduit>();
        

        
        public string GetCodeCateg() 
        {
            return this.codeCateg;
        }

        public string Getlibelle() 
        {
            return this.libelle;
        }

        public CategProduit(string unCodeCateg, string unLibelle) 
        {
            codeCateg = unCodeCateg;
            libelle = unLibelle;
            lesProduits = new List<Produit>();


        }

        public void SetCodeCateg( string unNouveauCodeCateg) 
        {
           
            codeCateg = unNouveauCodeCateg;

            
        }
        public void SetLibelle(string unNouveauLibelle)
        {
            libelle = unNouveauLibelle;


        }

        public static void AjouterProduit(Produit p) 
        {
            lesProduits.Add(p);

    
        }
        public static void AjouterCategorie(CategProduit c)
        {
            lesCategories.Add(c);


        }
        public List<Produit> GetProduit() 
        {

            return lesProduits ;
        }

        
                /*
                }*/

              

            
        
    }
}
