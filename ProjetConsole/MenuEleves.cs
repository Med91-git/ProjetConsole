using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuEleves : ISousMenu 
    {
        private MenuPrincipal _menu; 
        private Ecole _ecole;

        public MenuEleves(Ecole ecole) 
        {
            this._ecole = ecole; 
            

        }
        public void AfficherOptionsSousMenu()    
        {
            Console.WriteLine();
            Console.WriteLine("---------- Menu Eleves ----------");   
            Console.WriteLine();
            Console.WriteLine("1. Lister les élèves\n" +
                "2. Créer un nouvel élève\n" +
                "3. Consulter un élève existant\n" +
                "4. Ajouter une note et une appréciation pour un cours sur un élève existant\n" +
                "0. Revenir au menu principal");
            Console.WriteLine();
            Console.WriteLine("---------------------------------"); 
        }

        public void VerifierSaisieUtilisateurSousMenu()    
        {
            int choixUtilisateurMenuEleves = 0; 

            while (choixUtilisateurMenuEleves != 1 || choixUtilisateurMenuEleves != 2 || choixUtilisateurMenuEleves != 3 || choixUtilisateurMenuEleves != 4 || choixUtilisateurMenuEleves != 0)
            {
                Console.WriteLine();
                Console.Write("Faites votre choix : ");  
                choixUtilisateurMenuEleves = int.Parse(Console.ReadLine()); 

                
                Note noteEleve; 
                Cours coursEleve;

                if (choixUtilisateurMenuEleves == 1)   
                {
                    Console.Clear();
                    // garder en mémoire la liste des eleves existants (ceux qui sont inscrits via la fonctionnalité CreerNouvelEleve)  
                    
                    Console.WriteLine();
                    _ecole.ListerEleves();   
                    RevenirAuSousMenu(); 
                     
                    break;
                } 
                if (choixUtilisateurMenuEleves == 2)  
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Identifiant du nouvel élève : ");
                    int identifiantNouvelEleve = int.Parse(Console.ReadLine());
                    Console.Write("Nom du nouvel élève : "); 
                    string nomNouvelEleve = Console.ReadLine(); 

                    Console.WriteLine();
                    Console.Write("Prénom du nouvel élève : ");
                    string prenomNouvelEleve = Console.ReadLine();

                    Console.Write("Date de naissance du nouvel élève (format JJ/MM/AAAA): ");  

                    DateOnly dateDeNaissanceNouvelEleve = DateOnly.Parse(Console.ReadLine());  
                    
                    Console.WriteLine();
                    Console.Write("Souhaitez-vous confirmer les informations suivantes pour la création de cet élève ? \n");
                    Console.WriteLine();
                    Console.WriteLine("Identifiant : " + identifiantNouvelEleve); 
                    Console.WriteLine("Nom : " + nomNouvelEleve);
                    Console.WriteLine("Prénom : " + prenomNouvelEleve);
                    Console.WriteLine("Date de naissance : " + dateDeNaissanceNouvelEleve);   
                    Console.WriteLine();
                    Console.Write("Répondre oui/non : "); 
                    string reponseConfirmationCreationEleve = Console.ReadLine();

                    // Convertir la réponse de l'utilisateur en majuscules ou en minuscules (revoir l'algorithme)

                    string reponseEnMajuscules = reponseConfirmationCreationEleve.ToUpper(); 
                    string reponseEnMinuscules = reponseConfirmationCreationEleve.ToLower(); 

                    if (reponseConfirmationCreationEleve == "oui" || reponseConfirmationCreationEleve == reponseEnMajuscules)    
                    {
                        // tant que l'utilisateur n'a pas quitter -> on lui propose d'ajouter un nouvel élève

                        Eleve nouvelEleve = new Eleve { Identifiant = identifiantNouvelEleve, Nom = nomNouvelEleve, Prenom = prenomNouvelEleve, DateDeNaissance = dateDeNaissanceNouvelEleve };

                        // ajouter l'eleve dans la liste des eleves

                        _ecole.CreerNouvelEleve(nouvelEleve);

                        Console.WriteLine();

                        Console.WriteLine($"{prenomNouvelEleve} est officiellement admis au sein de l'école");   

                        RevenirAuSousMenu();  

                    }
                    else if (reponseConfirmationCreationEleve == "non" || reponseConfirmationCreationEleve == reponseEnMajuscules)
                    {
                        Console.WriteLine();
                        Console.WriteLine("la création du nouvel élève n'a pas été effectuée");   
                        RevenirAuSousMenu();
                    }
                    else 
                    {
                        Console.WriteLine("Réponse incorrecte, répondez par oui ou non");  
                    }


                    break;
                }
                if (choixUtilisateurMenuEleves == 3) 
                {
                    Console.Clear();
                    Console.WriteLine();
                    // demander à l'utilisateur de saisir l'identifiant de l'eleve  
                    //Console.Write("Saisir le prénom de l'elève à consulter : ");
                    //string prenomEleveAConsulter = Console.ReadLine();  
                    // comment gerer le type de l'eleve au niveau de la saisie utilisateur et au niveau du parametre de la fonction consulterEleve ?
                    // Afficher le nom de l'eleve 
                    RevenirAuSousMenu();

                    break;
                }
                if (choixUtilisateurMenuEleves == 4)
                {
                    Console.Clear();
                    Console.WriteLine();


                    // demander à l'utilisateur sur quel élève (identifiant de l'élève) ajouter la note
                    // demander à l'utilisateur sur quel cours (identifiant du cours) ajouter une note 
                    // demander à l'utilisateur d'ajouter une note à l'élève -> instancier les classes notes + cours 
                    // demander confirmation à l'utilisateur des infos saisies (eleve + cours + note)
                    // si confirmation -> appeler la methode de classe ecole "RecupererNoteEtAppreciation" 

                    // tant que l'utilisateur n'a pas quitter -> proposer d'ajouter une note à l'élève 

                    RevenirAuSousMenu(); 

                    break;
                }
                if (choixUtilisateurMenuEleves == 0) 
                {
                    //RevenirAuMenuPrincipal(); 
                    return;
                    //break;
                }
                if (choixUtilisateurMenuEleves > 4)  
                {
                    Console.WriteLine("Valeur incorrecte, veuillez recommencer");  
                    Console.WriteLine(); 
                }
                if (choixUtilisateurMenuEleves < 0)
                {
                    Console.WriteLine("Vous ne pouvez pas saisir un nombre négatif");   
                    Console.WriteLine();
                }
                // borner si l'utilisateur ne saisie pas un nombre (else)   
            }
        }

        public void RevenirAuMenuPrincipal() 
        {
            //MenuPrincipal menu = new MenuPrincipal(_ecole); 
            Console.Clear(); 
            _menu.AfficherOptionsMenuPrincipal(); 
            _menu.VerifierSaisieUtilisateurMenuPrincipal();    

        }

        public void RevenirAuSousMenu()
        {
            Console.WriteLine();
            Console.Write("Revenir au sous-menu (saisir la touche entrer) : ");  
            string saisieutilisateurRetourSousMenuEleves = Console.ReadLine();
            if (saisieutilisateurRetourSousMenuEleves == "")
            {
                Console.Clear();
                AfficherOptionsSousMenu();
                VerifierSaisieUtilisateurSousMenu();   
            }

        }
    }
}
