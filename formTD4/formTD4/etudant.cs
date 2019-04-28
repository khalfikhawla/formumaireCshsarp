using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formTD4
{
    class etudiant
    {
        private int id;
        private string nom, prenom;
        public etudiant(int id , string nom , string prenom) {
            this.id = id;
            this.nom =nom;
            this.prenom = prenom;
        }
        public etudiant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public etudiant(int id) {
            this.id = id;
        }

        public etudiant()
        {
            // TODO: Complete member initialization
        }

        public int ID {
            get { return id; }
            set { id = value; }
        }
        public string NOM
        {
            get { return nom; }
            set { nom = value; }
        }
        public string PRENOM
        {
            get { return prenom; }
            set { prenom = value; }
        }

    }
}
