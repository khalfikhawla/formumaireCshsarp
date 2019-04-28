using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formTD4
{
    class etudant
    {
        private int id;
        private string nom, prenom;
        public etudant(int id , string nom , string prenom) {
            this.id = id;
            this.nom =nom;
            this.prenom = prenom;
        }
        public etudant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public etudant(int id) {
            this.id = id;
        }

        public etudant()
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
