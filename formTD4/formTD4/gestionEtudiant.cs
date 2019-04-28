using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace formTD4
{
    class GestionEtudiant : interfaceGestion
    {
        MySqlConnection conn;
        MySqlConnection connexion()
        {
            //localhost;username=root;password=;database=lfig2;
            conn = new MySqlConnection("server=localhost;username=root;password=;database=lfig2;"); 
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Connection établie");
                    return conn;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Probleme de connexion");
                return null;
            }
            return conn;
        }

        public void ajouterEtudiant(etudant e)
        {
            conn = connexion();
            MySqlCommand cmd = new MySqlCommand("insert into etudiant1 (id,nom,prenom) values (@id , @nom, @prenom)", conn);

            cmd.Parameters.AddWithValue("@id", e.ID);
            cmd.Parameters.AddWithValue("@nom", e.NOM);
            cmd.Parameters.AddWithValue("@prenom", e.PRENOM);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Ajouter");
            conn.Close();
        }
        public void supprimeEtudiant(etudant e)
        {
            conn = connexion();
            MySqlCommand cmd = new MySqlCommand("delet form etudiant1 wher id=@id ", conn);
            cmd.Parameters.AddWithValue("@id", e.ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("supprimer");
            conn.Close();
        }
        public void chercherEtudiant(etudant e)
        {
            etudant e_ch = new etudant();
            conn = connexion();
            MySqlCommand cmd = new MySqlCommand("select * form etudiant1 wher id=@id ", conn);
            cmd.Parameters.AddWithValue("@id", e.ID);
            using (MySqlDataReader lire = cmd.ExecuteReader())
            {
                if (lire.HasRows)
                {
                    while (lire.Read())
                    {
                        e_ch.NOM = lire["nom"].ToString();
                        e_ch.PRENOM = lire["prenom"].ToString();
                    }
                    lire.Close();
                }
                else
                {
                    MessageBox.Show("l'etudiant n'existe pas dans la base");
                }
                conn.Close();
               
            }
           // return e_ch;
        }
    }
}
