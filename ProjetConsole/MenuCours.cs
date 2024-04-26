using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuCours : IMenu
    {
        private MenuPrincipal menuPrincipal;
        public void AfficherOptionsMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Lister les cours existants\n" +
                "2. Ajouter un nouveau cours au programme\n" +
                "3. Supprimer un cours par son identifiant\n" +
                "4. Revenir au menu principal");  
        }

        public void VerifierErreurSaisieUtilisateur() 
        {
            //  
        }

        public void RevenirAuMenuPrincipal()
        {
            menuPrincipal.AfficherOptionsMenu();
        }

    }
}
