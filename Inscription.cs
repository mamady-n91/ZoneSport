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
using System.Net.Mail;

namespace PPE2
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }



        private void Inscription_Load(object sender, EventArgs e)
        {
            try
            {
                string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                MySqlConnection connection = new MySqlConnection(infoConnection);
                //MySqlDataReader reader;
                string selectQuery = "SELECT NomVille,IdVille FROM VILLE ORDER BY NomVille";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable("myTable");
                //reader= cmd.ExecuteReader();
                dataAdapter.Fill(table);




                cbBoxVille.DisplayMember = "NomVille";
                cbBoxVille.ValueMember = "IdVille";
                cbBoxVille.DataSource = table;




            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxTel_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void txtBoxNomClt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtBoxPrenomClt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btnValiderInscription_Click(object sender, EventArgs e)
        {

            var age = BDD.GetAge(dtPckrDtNaiss.Value);

            MessageBox.Show(Convert.ToString(DateTime.Today));
            if (txtBoxPseudo.Text!=""&& txtBoxPrenomClt.Text != "" && txtBoxNomClt.Text != "" && txtBoxAdresse.Text != "" && string.IsNullOrEmpty(cbBoxVille.Text) == false && cbBoxCp.Text != "" && txtBoxTel.Text != "" && txtBoxMail.Text != "" && txtBoxMdp.Text != "")

            {

                if (BDD.VerifCpVille(cbBoxCp.Text,cbBoxVille.Text)==false)
                {
                    MessageBox.Show("Attention,la ville entrée ne correspond pas");
                }
                else if (txtBoxPseudo.TextLength <4 || txtBoxNomClt.TextLength < 2 || txtBoxPrenomClt.TextLength < 3 || txtBoxAdresse.TextLength < 6 || txtBoxTel.TextLength < 10)
                {
                    MessageBox.Show("Attention à bien respecter le bon nombre de caractères");

                }
                else if (txtBoxMail.Text.Contains("@") == false) 
                {
                    MessageBox.Show("L'adresse mail n'est pas valide.");
                }

                else if (age < 18)
                {
                    MessageBox.Show("Vous devez avoir 18 ans pour vous inscrire");
                }
                else              
                {

                    BDD.AjouterCompteClient(txtBoxPseudo.Text, txtBoxNomClt.Text, txtBoxPrenomClt.Text, dtPckrDtNaiss.Value, txtBoxAdresse.Text, cbBoxVille.Text, cbBoxCp.Text, int.Parse(txtBoxTel.Text), txtBoxMail.Text, txtBoxMdp.Text);
                }
            }
            if (txtBoxPseudo.Text=="" || txtBoxNomClt.Text == "" || txtBoxPrenomClt.Text == "" || txtBoxAdresse.Text == "" || string.IsNullOrEmpty(cbBoxVille.Text) == true || cbBoxCp.Text == "0" || txtBoxTel.Text == "" && txtBoxMail.Text == "" && txtBoxMdp.Text == "")
            {
                MessageBox.Show("Vérifiez que tous les champs sont saisis");
            }
        }


        private void cbBoxVille_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBoxVille.Text != "")
            {


                try
                {
                    string infoConnection = " server = localhost; user = root; database = commerce; pwd = ";
                    MySqlConnection connection = new MySqlConnection(infoConnection);
                    string selectQuery = "SELECT CodePostal FROM VILLE WHERE IdVille=" + cbBoxVille.SelectedValue;
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                    //MessageBox.Show(cmd.CommandText);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        cbBoxCp.Items.Add(reader.GetInt32("CodePostal"));
                        while (cbBoxCp.Items.Count > 1)
                        {
                            cbBoxCp.Items.RemoveAt(0);

                        }
                    }


                }
                catch (MySqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
    
        
    
        

        




      

             


    


