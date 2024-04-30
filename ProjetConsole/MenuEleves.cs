using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuEleves : ISousMenu 
    {

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
                
                // instancier l'école car c'est elle qui va gérer toutes les actions du menu sur les eleves, les cours etc ...
                Ecole ecole = new Ecole(); 
                

                if (choixUtilisateurMenuEleves == 1)  
                {
                    Console.Clear();
                    // garder en mémoire la liste des eleves existant (y compris ceux qui sont inscrit via la fonctionnalité CreerNouvelEleve) 
                    Console.WriteLine();
                    ecole.ListerEleves();
                    RevenirAuSousMenu(); 
                     

                    break;
                } 
                if (choixUtilisateurMenuEleves == 2)  
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Nom du nouvel eleve : "); 
                    string nomNouvelEleve = Console.ReadLine(); 

                    Console.WriteLine();
                    Console.Write("Prenom du nouvel eleve : ");
                    string prenomNouvelEleve = Console.ReadLine();

                    Console.Write("Date de naissance du nouvel eleve (format JJ/MM/AAAA): ");  

                    DateOnly dateDeNaissanceNouvelEleve = DateOnly.Parse(Console.ReadLine());  
                    
                    Console.WriteLine();
                    Console.Write("Souhaitez-vous confirmer les informations suivantes pour la création de cet eleve ? \n");
                    Console.WriteLine();
                    Console.WriteLine("Nom : " + nomNouvelEleve);
                    Console.WriteLine("Prénom : " + prenomNouvelEleve);
                    Console.WriteLine("Date de naissance : " + dateDeNaissanceNouvelEleve);   
                    Console.WriteLine();
                    Console.Write("Répondre oui/non : "); 
                    string reponseConfirmationCreationEleve = Console.ReadLine();

                    // Convertir la réponse de l'utilisateur en majuscules 
                    string reponseEnMajuscules = reponseConfirmationCreationEleve.ToUpper();
                    string reponseEnMinuscules = reponseConfirmationCreationEleve.ToLower(); 

                    // probleme -> gérer la casse 
                    if (reponseConfirmationCreationEleve == "oui" || reponseConfirmationCreationEleve == reponseEnMajuscules)   
                    {
                        // tant que l'utilisateur n'a pas quitter -> on lui propose d'ajouter de nouveaux élèves
                        
                        Eleve nouvelEleve = new Eleve(nomNouvelEleve, prenomNouvelEleve, dateDeNaissanceNouvelEleve); 

                        ecole.CreerNouvelEleve(nouvelEleve);
                        Console.WriteLine();
                        Console.WriteLine($"{prenomNouvelEleve} est officiellement admis au sein de l'école");

                        RevenirAuSousMenu(); 

                    }
                    else if (reponseConfirmationCreationEleve == "non" || reponseConfirmationCreationEleve == reponseEnMajuscules)
                    {
                        Console.WriteLine();
                        Console.WriteLine("la création du nouvel eleve n'a pas été effectuée");     
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
                    Console.Write("Saisir le prénom de l'elève à consulter : ");
                    string prenomEleveAConsulter = Console.ReadLine();
                    // comment gerer le type de l'eleve au niveau de la saisie utilisateur et au niveau du parametre de la focntion consulterEleve ?
                    // appeler la méthode ConsulterEleve 
                    //ecole.ConsulterEleve();
                    RevenirAuSousMenu();

                    break;
                }
                if (choixUtilisateurMenuEleves == 4)
                {
                    Console.Clear();
                    Console.WriteLine();
                    // initialiser l'instance de la classe note 
                    Note noteEleve;


                    // tant que l'utilisateur n'a pas quitter -> on lui propose d'ajouter une note à l'élève 
                    
                    RevenirAuSousMenu();

                    break;
                }
                if (choixUtilisateurMenuEleves == 0) 
                {
                    RevenirAuMenuPrincipal(); 
                    break;
                }
                if (choixUtilisateurMenuEleves > 4)  
                {
                    Console.WriteLine("Valeur incorrecte, veuillez recommencer");
                    Console.WriteLine();
                    //menuPrincipal.VerifierErreurSaisieUtilisateur();
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
            MenuPrincipal menu = new MenuPrincipal(); 
            Console.Clear(); 
            menu.AfficherOptionsMenuPrincipal();
            menu.VerifierSaisieUtilisateurMenuPrincipal();  

        }

        public void RevenirAuSousMenu()
        {
            Console.WriteLine();
            Console.Write("Saisir la touche Entrer pour revenir au sous-menu : ");
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
