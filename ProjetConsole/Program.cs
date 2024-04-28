using System.Threading.Channels;

namespace ProjetConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MenuPrincipal menuPrincipal = new MenuPrincipal();

            menuPrincipal.AfficherOptionsMenuPrincipal();
            menuPrincipal.VerifierSaisieUtilisateurMenuPrincipal();  

            // faire en sorte que dans le menu eleve (ou menu cours) l'appel du menu principal soit optionnel -> gérer ce parametre dans la fonction adpatée (revenir au menu principal) et la classe adaptée














        }


    }
}
