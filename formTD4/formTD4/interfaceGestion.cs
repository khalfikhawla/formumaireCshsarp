using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formTD4
{
    interface interfaceGestion 
    {
        void ajouterEtudiant(etudant e);
        void modiferEtudiant(etudant e);
        void supprimeEtudiant(etudant e);
        void chercherEtudiant(etudant e);
    }
}
