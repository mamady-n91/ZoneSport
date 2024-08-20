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
    public class Commande
    {
        private string noCommande;
        private Compte compte;
        private DateTime dateCommande;



        public Commande(string unNoCommande, DateTime laDateCommande)
        {
            noCommande = unNoCommande;
            dateCommande = laDateCommande;

        }
        public string GetNoCommande()
        {
            return this.noCommande;
        }
        public DateTime GetDateCommande()
        {
            return this.dateCommande;
        }
    }
}
