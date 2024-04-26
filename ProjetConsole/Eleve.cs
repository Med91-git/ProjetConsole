using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class Eleve
    {
        private int identifiant;
        public string nom;
        public string prenom;
        public DateTime dateDeNaissance;
        private List<Note> notes = new List<Note>();   

        public Eleve(string nom, string prenom)
        {
            
            this.nom = nom;
            this.prenom = prenom; 
            

        }




        // voir plus tard si besoin de plusieurs constructeurs 
    }
}
