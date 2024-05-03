using System.Threading.Channels;

namespace ProjetConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ecole ecole = new Ecole();
            MenuPrincipal menuPrincipal = new MenuPrincipal(ecole);
            menuPrincipal.AfficherOptionsMenuPrincipal(); 
            menuPrincipal.VerifierSaisieUtilisateurMenuPrincipal(); 
            
            












        }


    }
}
