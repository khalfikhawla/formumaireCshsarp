using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace formTD4
{
    class gestionEtudiant :interfaceGestion
    {
        MySqlConnection conn;
        MySqlConnection connexion()
        {
            conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=lfig2;"); 
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

        public void ajouterEtudiant(etudiant e)
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
        /*public void supprimeEtudiant(etudiant e)
        {
            conn = this.connexion();
            MySqlCommand cmd = new MySqlCommand("delet form etudiant1 wher id=@id ", conn);
            cmd.Parameters.AddWithValue("@id", e.ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("supprimer");
            conn.Close();
        }*/
        public void supprimeEtudiant(etudiant e)
        {
            conn = this.connexion();
            try
            {
                MySqlCommand cmd = new MySqlCommand("delet form etudiant1 wher id=@id ", conn);
                cmd.Parameters.AddWithValue("@id", e.ID);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("supprimer");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Le champ identifiant doit etre un nombre " + e.ID + " ?");
            }
        }
        public void chercherEtudiant(etudiant e)
        {
            etudiant e_ch = new etudiant();
            conn = connexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM etudiant1 where id=@id ", conn);
            //Select * from TableName where "+ColumnName+"="'"+txtSearch.Text+"'" // Example

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
            
        }


        
    }
}
