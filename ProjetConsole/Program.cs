using System.Threading.Channels;

namespace ProjetConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancier la classe ecole
            Ecole ecole = new Ecole();
            // Mettre l'instance de l'ecole en parametre dans le menu principal
            MenuPrincipal menuPrincipal = new MenuPrincipal(ecole);

            menuPrincipal.AfficherOptionsMenuPrincipal();
            menuPrincipal.VerifierSaisieUtilisateurMenuPrincipal(); 

            












        }


    }
}
