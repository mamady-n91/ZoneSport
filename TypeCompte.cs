using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PPE2
{
    public class TypeCompte
    {
        private string codeTypeCompte;
        private string libelle;
        List<Compte> LesComptes = new List<Compte>();
    }
}
