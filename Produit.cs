using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE2
{
    public class Produit
    {
        private string noProduit;
        CategProduit codeCategP;
        private string codeCateg;
        private string nomProduit;
        private int quantiteDispo;
        private DateTime dateAjoutStock;
        private double prixTarif;
        private int seuilReappro;
        private string imageProduit;
        

        public Produit(string unNoProduit, string unCodeCateg, string unNomProduit, int uneQuantiteDispo, float unPrixTarif, int unSeuilReapro, string uneImageProduit) 
        {
            noProduit = unNoProduit;
            codeCateg = unCodeCateg;
            nomProduit = unNomProduit;
            quantiteDispo = uneQuantiteDispo;
           // dateAjoutStock = uneDtAjoutStock;
            prixTarif = unPrixTarif;
            imageProduit = uneImageProduit;
        }
        
        public string GetNoProduit() 
        {
            return this.noProduit;
        }
        public string GetNomProduit()
        {
            return this.nomProduit;
        }
        public int GetQuantiteDispo()
        {
            return this.quantiteDispo;
        }
        public DateTime GetDateAjoutStock()
        {
            return this.dateAjoutStock;
        }
        public double GetPrixTarif()
        {
            return prixTarif;

        }
        public int GetSeuilReappro()
        {
            return seuilReappro;
        }
        
        public Image GetImage() 
        {
            return Image.FromFile(imageProduit);
        }

        public void SetNoProduit(string unNoProduit) 
        {
            noProduit = unNoProduit;
        }
        public void SetNomProduit(string unNomProduit)
        {
            nomProduit = unNomProduit;
        }
        public void SetQuantiteDispo(int uneQuantiteDispo)
        {
            quantiteDispo = uneQuantiteDispo;
        }
        public void SetDateAjoutStock(DateTime uneDtAjoutStock)
        {
            dateAjoutStock = uneDtAjoutStock;

        }
        public void SetPrixTarif(float unPrixTarif)
        {
            prixTarif = unPrixTarif;
        }
        public void SetSeuilReappro(int unSeuilReappro)
        {
            seuilReappro = unSeuilReappro;
        }
        public void SetImageProduit(string uneImageProduit)
        {
            imageProduit = uneImageProduit;
        }
        

    }
}
