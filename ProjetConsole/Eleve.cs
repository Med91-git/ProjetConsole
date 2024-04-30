using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class Eleve
    {
        private int identifiant; // pour cet attribut -> utiliser une variable static (variable de classe) 
        public string nom; 
        public string prenom;
        public DateOnly dateDeNaissance;
        private List<Note> notes = new List<Note>();   

        public Eleve(string nom, string prenom, DateOnly dateDeNaissance) 
        {
            
            this.nom = nom;
            this.prenom = prenom;  
            this.dateDeNaissance = dateDeNaissance; 
            

        }
        // créer un 2eme constructeur pr récupérer la note de l'eleve et l'ajouter dans sa liste de notes (voir fonctionnalité RecupererNoteEtAppreciation) 

    }
}
