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

        /*private bool RechercherEleve(Eleve eleve)  
        {
            if(this.Eleves.Contains(eleve))
            {
                return true;  
            }
            return false;

        }*/

        public void ConsulterEleve(Eleve eleve)
        {
            // Vérifier/Rechercher si l'eleve saisit par l'utilisateur existe bien dans la liste des eleves 
            //bool eleveRechercheIsExist = RechercherEleve(eleve);  

            // si l'eleve existe -> on affiche les infos sur l'eleve  
            /*if(eleveRechercheIsExist == true)
            {
                Console.WriteLine(); 
                Console.WriteLine(eleve.Nom);
                Console.WriteLine(eleve.Prenom);
                Console.WriteLine(eleve.DateDeNaissance);   

            }*/

            // sinon informer l'utilisateur que l'eleve recherché n'existe pas  
            Console.WriteLine("Erreur, cet élève n'est pas inscrit dans cette l'école");   
        }

        public void ListerEleves() 
        {

            if(Eleves.Count == 0)
            {
                Console.WriteLine("Aucun eleve n'est inscrit dans cette école");  
            }
            if (Eleves.Count >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("Voici la liste des élèves existants :");
                Console.WriteLine();
                foreach (Eleve eleve in Eleves)
                {
                    Console.WriteLine();
                    Console.WriteLine("    Nom : " + eleve.Nom);
                    Console.WriteLine("    Prénom : " + eleve.Prenom);
                    Console.WriteLine("    Date de naissance : " + eleve.DateDeNaissance); 
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------");  

                }


            }
            

        }

        public void RecupererNoteEtAppreciation(Eleve eleve, Cours cours, Note note)  
        {
            // Vérifier que l'eleve existe (on peut pas ajouter une note sur un eleve qui n'existe pas) -> appeler fonction ListerEleves 

            // Vérifier si le cours en argument existe bien dans la liste de cours  -> appeler fonction ListerCours 


            // si tout est ok -> récupérer la note et le cours saisie par l'utilisateur
            // ajouter la note dans la liste de notes de l'eleve pour le cours choisit par l'utilisateur
            // rq : réfléchir comment associer la note au cours pour l'eleve 
        }

        public void CalculerMoyenneEleve() 
        {

        }

        public void AjouterCours(Cours cours)
        {
            this.Programme.Add(cours); 
        }
        public void SupprimerCours(int identifiantCours)  //mettre en parametre l'identifiant du cours  
        {
            // récupérer saisie utilisateur 

            //this.Programme.Remove(cours);
            
            // supprimer notes + appréciations du cours pour chaque eleve 

        }
        public void ListerCours() 
        {
            if (Programme.Count == 0) 
            {
                Console.WriteLine(); 
                Console.WriteLine("Aucun cours de disponible pour le moment.");
            }
            if (Programme.Count >= 1)  
            {
                Console.WriteLine();
                Console.WriteLine("Voici la liste des cours existants :");
                Console.WriteLine();
                foreach (Cours cours in Programme) 
                {
                    Console.WriteLine();
                    Console.WriteLine("    Cours n° " + cours.Identifiant + " : " + cours.Nom);    

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------"); 
                }  


            }
        }
    } 
}
