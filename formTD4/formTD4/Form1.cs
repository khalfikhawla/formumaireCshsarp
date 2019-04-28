using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formTD4
{
    public partial class formTD4 : Form
    {
        public formTD4()
        {
            InitializeComponent();
        }
        private void formTD4_Load(object sender, EventArgs e)
        {

        }

        private void ajoute_Click(object sender, EventArgs e)
        {
            try {
                int id = int.Parse(idTextBox.Text);
                etudant e_ajouter = new etudant
                (id, nomTextBox.Text, prenomTextBox.Text);
                GestionEtudiant ec = new GestionEtudiant();
            }

            
        catch (Exception ex)
    {MessageBox.Show (ex.Message);
    MessageBox.Show("le champ identifiont doit etre un nombre");}
        }

        private void modifer_Click(object sender, EventArgs e)
        {

        }

        private void supprime_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idTextBox.Text);
                etudant e_supprimer = new etudant (id);
                
                GestionEtudiant em = new GestionEtudiant();
                em.supprimeEtudiant(e_supprimer);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("le champ identifiont doit etre un nombre");
            }
        }

        private void cherche_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idTextBox.Text);
                etudant e_chercher = new etudant(id);

                GestionEtudiant ec = new GestionEtudiant();
                ec.supprimeEtudiant(e_chercher);
                etudant e_ch = ec.chercherEtudiant(e_chercher);
                nomTextBox.Text= e_ch.NOM;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("le champ identifiont doit etre un nombre");
            }
        }

        private void prenomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chercheBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void effacer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
