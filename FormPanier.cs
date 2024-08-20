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

namespace PPE2
{
    public partial class FormPanier : Form
    {
        public FormPanier()
        {
            InitializeComponent();
        }

        private void FormPanier_Load(object sender, EventArgs e)
        {
            try
            {
                dtGridViewPanier.DataSource = BDD.tablePanier(BDD.MesProduitsPanier);
                dtGridViewPanier.RowTemplate.Height = 125;
                if (dtGridViewPanier.Rows.Count == 0)
                {
                    btnValiderCommande.Enabled = false;

                }
                else
                {
                    btnValiderCommande.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            BDD.noCommande = BDD.AjouterCommande(BDD.utilisateur, DateTime.Today);


        }

        private void btnAnnulerCommande_Click(object sender, EventArgs e)
        {
            dtGridViewPanier.Rows.Clear();
            btnValiderCommande.Enabled = false;
            
        }

        private void btnConfirmerQt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGridViewPanier.SelectedRows.Count == 1 && numUpDownQtCommandee.Value.ToString() != "") ;
                {
                    BDD.AjoutLigneCommande(int.Parse(dtGridViewPanier.SelectedRows[0].Cells[0].Value.ToString()), BDD.noCommande, int.Parse(numUpDownQtCommandee.Value.ToString()), DateTime.Today);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void numUpDownQtCommandee_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Text = (double.Parse(dtGridViewPanier.SelectedRows[0].Cells[4].Value.ToString()) * double.Parse(numUpDownQtCommandee.Value.ToString())).ToString() ;
        }

        private void numUpDownQtCommandee_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
