using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuPrincipal : IMenu 
    {
        private MenuEleves menuEleves = new MenuEleves();  // autre bug  
        private MenuCours menuCours = new MenuCours();  

        public void AfficherOptionsMenu()
        {
            Console.WriteLine("1. Elèves" +
                "\n" +
                "2. Cours");
            Console.WriteLine(); 

        }

        public void VerifierErreurSaisieUtilisateur()   
        {

            int choixUtilisateurMenuprincipal = 0; 

            while (choixUtilisateurMenuprincipal != 1 || choixUtilisateurMenuprincipal != 2)
            {
                Console.Write("Faites votre choix : "); 
                choixUtilisateurMenuprincipal = int.Parse(Console.ReadLine()); 

                if (choixUtilisateurMenuprincipal == 1)
                {
                    menuEleves.AfficherOptionsMenu(); 
                    menuEleves.VerifierErreurSaisieUtilisateur();  
                    break;
                }
                else if (choixUtilisateurMenuprincipal == 2)
                {
                    menuCours.AfficherOptionsMenu();
                    // ajouter Verifier erreur saisie Utilisateur
                    break;
                }
                else if (choixUtilisateurMenuprincipal > 2 || choixUtilisateurMenuprincipal == 0)
                {
                    Console.WriteLine("Valeur incorrecte, veuillez recommencer"); 
                    Console.WriteLine();  
                }
                else if (choixUtilisateurMenuprincipal < 0)
                {
                    Console.WriteLine("Vous ne pouvez pas saisir un nombre négatif");
                    Console.WriteLine();
                }
                
                 
                
                
            }


        }
    }
}
