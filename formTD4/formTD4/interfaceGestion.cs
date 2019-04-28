using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formTD4
{
    interface interfaceGestion 
    {
        void ajouterEtudiant(etudiant e);
        //void modiferEtudiant(etudant e);
        void supprimeEtudiant(etudiant e);
        void chercherEtudiant(etudiant e);
    }
}
