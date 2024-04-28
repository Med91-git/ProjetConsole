using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuPrincipal : IMenuPrincipal 
    {
        public MenuPrincipal menuPrincipal;
        public MenuEleves menuEleves = new MenuEleves();  
        public MenuCours menuCours = new MenuCours();  
        
        public MenuPrincipal()    
        {
            this.menuPrincipal = menuPrincipal; 
             
        }

        public void AfficherOptionsMenuPrincipal() 
        {
            Console.WriteLine();
            Console.WriteLine("---------- Menu Principal ----------"); 
            Console.WriteLine();
            Console.WriteLine("1. Elèves" +
                "\n" +
                "2. Cours");
            Console.WriteLine();
            Console.WriteLine("--------------------------------"); 
        }

        public virtual void VerifierSaisieUtilisateurMenuPrincipal()    
        {

            int choixUtilisateurMenuprincipal = 0; 

            while (choixUtilisateurMenuprincipal != 1 || choixUtilisateurMenuprincipal != 2)
            {
                Console.WriteLine();
                Console.Write("Faites votre choix : "); 
                choixUtilisateurMenuprincipal = int.Parse(Console.ReadLine()); 

                if (choixUtilisateurMenuprincipal == 1)
                {
                    Console.Clear();
                    menuEleves.AfficherOptionsSousMenu();  
                    menuEleves.VerifierSaisieUtilisateurSousMenu();  
                    break;
                }
                else if (choixUtilisateurMenuprincipal == 2)
                {
                    Console.Clear();
                    menuCours.AfficherOptionsSousMenu();
                    menuCours.VerifierSaisieUtilisateurSousMenu();  
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
