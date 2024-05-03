using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuCours : ISousMenu
    {

        //private MenuPrincipal _menu;
        private Ecole _ecole;

        public MenuCours(Ecole ecole)
        {
            this._ecole = ecole; 
            
        }

        public void AfficherOptionsSousMenu() 
        {
            Console.WriteLine();
            Console.WriteLine("---------- Menu Cours ----------"); 
            Console.WriteLine();
            Console.WriteLine("1. Lister les cours existants\n" +
                "2. Ajouter un nouveau cours au programme\n" + 
                "3. Supprimer un cours par son identifiant (non fonctionnel) \n" +
                "0. Revenir au menu principal (non fonctionnel)");   
            Console.WriteLine();
            Console.WriteLine("--------------------------------"); 
        }

        public void VerifierSaisieUtilisateurSousMenu()   
        {
            int choixUtilisateurMenuCours = 0;

            while (choixUtilisateurMenuCours != 1 || choixUtilisateurMenuCours != 2 || choixUtilisateurMenuCours != 3 || choixUtilisateurMenuCours != 0)
            {
                Console.WriteLine();
                Console.Write("Faites votre choix : "); 
                choixUtilisateurMenuCours = int.Parse(Console.ReadLine());
                
                if (choixUtilisateurMenuCours == 1)
                {
                    Console.Clear();
                    _ecole.ListerCours();
                    RevenirAuSousMenu(); 
                    break;
                }
                if (choixUtilisateurMenuCours == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("Identifiant du cours : "); 
                    int identifiantCours = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Nom du cours : ");
                    string nomCours = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Souhaitez-vous confirmer les informations suivantes pour la création de ce cours ? \n");
                    Console.WriteLine();
                    Console.WriteLine("Identifiant : " + identifiantCours); 
                    Console.WriteLine("Nom : " + nomCours);  
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Répondre oui/non : "); 
                    string reponseConfirmationCreationCours = Console.ReadLine();

                    string reponseEnMajuscules = reponseConfirmationCreationCours.ToUpper();

                    if (reponseConfirmationCreationCours == "oui" || reponseConfirmationCreationCours == reponseEnMajuscules)
                    {

                        Cours nouveauCours = new Cours { Identifiant = identifiantCours, Nom = nomCours };

                        _ecole.AjouterCours(nouveauCours); 

                        Console.WriteLine();

                        Console.WriteLine($"Le cours de {nomCours} est officiellement intégré au programme scolaire"); 

                        RevenirAuSousMenu();

                    }
                    else if (reponseConfirmationCreationCours == "non" || reponseConfirmationCreationCours == reponseEnMajuscules)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Le cours n'a pas été intégré au programme scolaire");
                        RevenirAuSousMenu();
                    }
                    else
                    {
                        Console.WriteLine("Réponse incorrecte, répondez par oui ou non");
                    }

                    //RevenirAuSousMenu();
                    break;
                }
                if (choixUtilisateurMenuCours == 3)
                {
                    // fonctionnalité à faire   
                    Console.Clear();

                    _ecole.ListerCours();

                    // demander à l'utilisateur le numéro du cours à supprimer (l'identifiant du cours
                    // récupérer saisie utilisateur
                    // demander confirmation saisie
                    // si oui -> appeler la fonction supprimerCours()

                    //_ecole.SupprimerCours(); 
                    RevenirAuSousMenu(); 
                    break;
                }
                
                if (choixUtilisateurMenuCours == 0)
                {
                    Console.Clear(); 
                    RevenirAuMenuPrincipal();
                    break;
                }
                if (choixUtilisateurMenuCours > 3)  
                {
                    Console.WriteLine("Valeur incorrecte, veuillez recommencer"); 
                    Console.WriteLine();
                }
                if (choixUtilisateurMenuCours < 0)
                {
                    Console.WriteLine("Vous ne pouvez pas saisir un nombre négatif");
                    Console.WriteLine();
                }
                // borner si l'utilisateur saisit du texte (else)    
                
            }

        }

        public void RevenirAuMenuPrincipal()
        {
            MenuPrincipal menu = new MenuPrincipal(_ecole); 
            Console.Clear();
            menu.AfficherOptionsMenuPrincipal();
            menu.VerifierSaisieUtilisateurMenuPrincipal();
            //_menu.AfficherOptionsMenuPrincipal(); 
            //_menu.VerifierSaisieUtilisateurMenuPrincipal();  

        }


        public void AfficherOptionsMenuPrincipal() 
        {
            Console.WriteLine("1. Elèves" +
                "\n" +
                "2. Cours");
            Console.WriteLine();

        }

        public void RevenirAuSousMenu()
        {
            Console.WriteLine();
            Console.Write("Saisir la touche entrer pour revenir au menu des cours : ");  
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
