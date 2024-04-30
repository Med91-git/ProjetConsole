using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuCours : ISousMenu
    {

        // appeler attributs de la classe Cours

        private MenuPrincipal menu;

        public void AfficherOptionsSousMenu() 
        {
            Console.WriteLine();
            Console.WriteLine("---------- Menu Cours ----------"); 
            Console.WriteLine();
            Console.WriteLine("1. Lister les cours existants\n" +
                "2. Ajouter un nouveau cours au programme\n" +
                "3. Supprimer un cours par son identifiant\n" +
                "0. Revenir au menu principal");   
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

                // instanciation de la classe ecole pr gérer les actions sur la classe cours 
                Ecole ecole = new Ecole();
                
                if (choixUtilisateurMenuCours == 1)
                {
                    // à faire 
                    Console.Clear(); 
                    RevenirAuSousMenu(); 
                    break;
                }
                if (choixUtilisateurMenuCours == 2)
                {
                    // à faire 
                    Console.Clear();
                    RevenirAuSousMenu();
                    break;
                }
                if (choixUtilisateurMenuCours == 3)
                {
                    // à faire  
                    Console.Clear();
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
                // borner si l'utilisateur ne saisie pas un nombre (else)   
                
            }

        }

        public void RevenirAuMenuPrincipal()
        {
            //Appeler les fonctions de l'interface du menu principal
            MenuPrincipal menu = new MenuPrincipal();
            Console.Clear();
            menu.AfficherOptionsMenuPrincipal();
            menu.VerifierSaisieUtilisateurMenuPrincipal();  

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
