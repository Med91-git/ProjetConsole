using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class Ecole
    {
        // créer attributs statiques pr avoir les infos suivantes (nbres de cours, nbres d'eleves) à incrémenter dans les fonctions concerner d'ajout eleve ou cours par exemple 

        
        private List<Eleve> eleves = new List<Eleve>(); // faire uniquement la déclaration (l'instance est dans le constructeur) 
        private List<Cours> programme = new List<Cours>(); // faire uniquement la déclaration (l'instance est dans le constructeur) 

        public List<Eleve> GetNombreEleves()
        {
            return eleves; 
        } 


        public Ecole() 
        {
            
            // voir ultérieurement pour le constructeur 
        }

        public void CreerNouvelEleve(Eleve eleve) // mettre en parametre un eleve    
        {
            this.eleves.Add(eleve); 
        }

        public void RecupererNoteEtAppreciation() // mettre en parametre un eleve et un cours
        {

        }


    } 
}
