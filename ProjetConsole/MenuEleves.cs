using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuEleves : ISousMenu 
    {
        private Ecole ecole; 
        private Eleve eleve;

        private MenuPrincipal menu; 

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

                /*if (choixUtilisateurMenuEleves == 1)
                {
                    // récupérer le nombre d'eleves de l'ecole

                    Ecole ecole = new Ecole();
                    List<Eleve> nombreElevesEcole = ecole.GetNombreEleves();
                    // s'il y a au minimum un eleve -> afficher 
                    if(nombreElevesEcole.Count < 0)
                    {
                        Console.WriteLine("Aucun eleve n'est inscrit dans cette école"); 
                    }
                    foreach(Eleve eleve in nombreElevesEcole)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Voici la liste des élèves :"); 
                        Console.WriteLine(eleve.prenom);
                        Console.WriteLine();

                    }


                    // sinon afficher message d'erreur 
                    break;
                }*/ 
                if (choixUtilisateurMenuEleves == 2) 
                {
                    Console.WriteLine();
                    Console.Write("Nom du nouvel eleve : ");
                    string nomNouvelEleve = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Prenom du nouvel eleve : ");
                    string prenomNouvelEleve = Console.ReadLine();

                    /*Console.Write("Date de naissance du nouvel eleve (format JJ/MM/AAAA): ");  
                    string dateDeNaissanceNouvelEleve = Console.ReadLine();*/
                    Console.WriteLine();
                    Console.Write("Souhaitez-vous confirmer les informations suivantes pour la création de cet eleve ? \n");
                    Console.WriteLine();
                    Console.WriteLine("Nom : " + nomNouvelEleve);
                    Console.WriteLine("Prénom : " + prenomNouvelEleve);
                    Console.WriteLine();
                    Console.Write("Répondre oui/non : "); 
                    string reponseConfirmationCreationEleve = Console.ReadLine();

                    // Convertir la réponse de l'utilisateur en majuscules 
                    string reponseEnMajuscules = reponseConfirmationCreationEleve.ToUpper(); 


                    if (reponseConfirmationCreationEleve == "oui" || reponseConfirmationCreationEleve == reponseEnMajuscules)  
                    {
                        Eleve nouvelEleve = new Eleve(nomNouvelEleve, prenomNouvelEleve); 

                        Ecole ecole = new Ecole();

                        ecole.CreerNouvelEleve(nouvelEleve);
                        Console.WriteLine();
                        Console.WriteLine($"{prenomNouvelEleve} est officiellement admis au sein de l'école");   

                    }
                    // revoir la egstion de la casse + bloc if/else sur la réponse négative
                    /*else if (reponseConfirmationCreationEleve == "non" || reponseConfirmationCreationEleve == reponseEnMajuscules)
                    {
                        Console.WriteLine();
                        Console.WriteLine("la création du nouvel eleve n'a pas été effectuée");
                    }
                    else
                    {
                        Console.WriteLine("Réponse incorrecte, répondez par oui ou non");
                    }*/




                    break;
                }
                if (choixUtilisateurMenuEleves == 3)
                {
                    // à faire 
                    break;
                }
                if (choixUtilisateurMenuEleves == 4)
                {
                    // à faire 
                    
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
    }
}
