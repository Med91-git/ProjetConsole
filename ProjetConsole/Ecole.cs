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

        public List<Eleve> Eleves { get; set; } = new List<Eleve>();  
        public List<Cours> Programme { get; set; } = new List<Cours>();

        public void CreerNouvelEleve(Eleve eleve)   
        {
            this.Eleves.Add(eleve);  
            
        }

        private bool RechercherEleve(Eleve eleve)  
        {
            if(this.Eleves.Contains(eleve))
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
                Console.WriteLine(); 
                Console.WriteLine(eleve.Nom);
                Console.WriteLine(eleve.Prenom);
                Console.WriteLine(eleve.DateDeNaissance); 

            }
            // sinon informer l'utilisateur que l'eleve recherché n'existe pas  
            Console.WriteLine("Erreur, cet élève n'est pas inscrit dans cette l'école");   
        }

        public void ListerEleves() // revoir l'algorithme pr garder l'inscirption des eleves en mémoire ou revoir comment gérer la portée des variables
        {
            // Vérifier qu'il y a au minimum un eleve inscrit dans l'école  

            // si l'eleve est inscrit/ajouté dans la liste des eleves -> afficher le ou les éleves inscrits (créeé/admis dans l'école)  


            /*if (eleves.Count >= 1)  
            {
                
                foreach (Eleve eleve in eleves)   
                {
                    Console.WriteLine();
                    Console.WriteLine("Voici la liste des élèves existant :");
                    Console.WriteLine("Nom : " + eleve.nom);
                    Console.WriteLine("Prénom : " + eleve.prenom);
                    Console.WriteLine("Date de naissance : " + eleve.dateDeNaissance);  
                    Console.WriteLine(); 

                }
            }
            // Sinon ne rien afficher aucun eleve + afficher message d'erreur  
            Console.WriteLine("Aucun eleve n'est inscrit dans cette école");*/
            if(Eleves.Count == 0)
            {
                Console.WriteLine("Aucun eleve n'est inscrit dans cette école"); 
            }
            Console.WriteLine("Voici la liste des élèves existant :");
            Console.WriteLine();
            foreach (Eleve eleve in Eleves)    
            {
                Console.WriteLine();
                Console.WriteLine("Nom : " + eleve.Nom);
                Console.WriteLine("Prénom : " + eleve.Prenom);
                Console.WriteLine("Date de naissance : " + eleve.DateDeNaissance);  
                Console.WriteLine();

            }

        }

        public void RecupererNoteEtAppreciation(Eleve eleve, Cours cours, Note note)  
        {
            // Vérifier que l'eleve existe (on peut pas ajouter une note sur un eleve qui n'existe pas) -> appeler fonction ListerEleves 

            // Vérifier si le cours en argument existe bien dans la liste de cours  -> appeler fonction ListerCours 

            // si tout est ok -> ajouter la note dans la liste de notes de l'eleve pour le cours choisit par l'utilisateur
            // rq : réfléchir comment associer la note au cours pour l'eleve
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
