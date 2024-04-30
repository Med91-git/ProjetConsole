using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ProjetConsole
{
    internal class Ecole
    {
        // créer attributs statiques pr avoir les infos suivantes (nbres de cours, nbres d'eleves) à incrémenter dans les fonctions concerner d'ajout eleve ou cours par exemple 

        
        public List<Eleve> eleves = new List<Eleve>();  
        public List<Cours> programme = new List<Cours>();  
        

        public Eleve CreerNouvelEleve(Eleve eleve)  // renvoyer un resultat pr prevenir a l'école qu'un nouvel eleve est inscrit 
        {
            this.eleves.Add(eleve); 

            return eleve; 

        }

        private bool RechercherEleve(Eleve eleve) 
        {
            if(this.eleves.Contains(eleve))
            {
                return true;  
            }
            return false;

        }

        public void ConsulterEleve(Eleve eleve)
        {
            // Vérifier/Rechercher si l'eleve saisit par l'utilisateur existe bien dans la liste des eleves
            bool eleveRechercheIsExist = RechercherEleve(eleve);  

            // si l'eleve existe -> on affiche les infos sur l'eleve  
            if(eleveRechercheIsExist == true)
            {
                Console.WriteLine("la fonctionnalité pour consulter un eleve a fonctionné");  
                Console.WriteLine(); 
                Console.WriteLine(eleve.nom);
                Console.WriteLine(eleve.prenom);
                Console.WriteLine(eleve.dateDeNaissance); 

            }
            // sinon informer l'utilisateur que l'eleve recherché n'existe pas  
            Console.WriteLine("Erreur, cet élève n'est pas inscrit dans cette l'école"); 
        }

        public void ListerEleves()
        {
            // Vérifier qu'il y a au minimum un eleve inscrit dans l'école (recupérer résultat fonction CreerNouvelEleve)  
            Eleve nouvelEleveInscrit;

            // si inscrit dans l'ecole -> afficher la liste des éleves inscrits (qui ont été créer/admis dans l'école)
            if (this.eleves.Count >= 1) 
            {
                
                foreach (Eleve eleve in this.eleves)
                {
                    Console.WriteLine();
                    Console.WriteLine("Voici la liste des élèves existant :");
                    nouvelEleveInscrit = CreerNouvelEleve(eleve);  
                    Console.WriteLine(nouvelEleveInscrit.prenom);
                    Console.WriteLine(nouvelEleveInscrit.dateDeNaissance); 
                    Console.WriteLine();

                }
            }

            // Sinon ne rien afficher aucun eleve + afficher message d'erreur  
            Console.WriteLine("Aucun eleve n'est inscrit dans cette école");  

        }

        public void RecupererNoteEtAppreciation(Cours cours, Eleve eleve)  
        {
            // Vérifier que l'eleve existe (on peut pas ajouter une note sur un eleve qui n'existe pas) -> appeler la fonction ListerEleves 
            // Vérifier si le cours en argument existe bien dans la liste de cours  

        }

        public void CalculerMoyenneEleve() 
        {

        }

        public void AjouterCours()
        {

        }
        public void SupprimerCours() // mettre en parametre l'identifiant du cours 
        {

        }
        public void ListerCours() 
        {

        }
    } 
}
