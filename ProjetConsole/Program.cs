using System.Threading.Channels;

namespace ProjetConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MenuPrincipal menuPrincipal = new MenuPrincipal();

            menuPrincipal.AfficherOptionsMenu();



            int choixUtilisateurMenuprincipal = 0;

            while(choixUtilisateurMenuprincipal != 1 || choixUtilisateurMenuprincipal != 2)
            {
                Console.Write("Faites votre choix : "); 
                choixUtilisateurMenuprincipal = int.Parse(Console.ReadLine()); 

                if(choixUtilisateurMenuprincipal == 1)
                {
                    Console.WriteLine("afficher le menu des eleves");
                    break;
                }
                if (choixUtilisateurMenuprincipal == 2)
                {
                    Console.WriteLine("afficher le menu des cours"); 
                    break;
                }
                if (choixUtilisateurMenuprincipal > 2)
                {
                    menuPrincipal.VerifierErreurSaisieUtilisateur();  
                }
                /*if (choixUtilisateurMenuprincipal < 0)
                {
                    Console.WriteLine("Vous ne pouvez pas saisir un nombre négatif");
                }
                if (choixUtilisateurMenuprincipal != 0)
                {
                    Console.WriteLine("Erreur, vous devez saisir un nombre"); 
                }*/ 
            }
             

            









        } 


    }
}
