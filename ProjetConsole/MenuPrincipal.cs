using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class MenuPrincipal : IMenu
    {
        public void AfficherOptionsMenu()
        {
            Console.WriteLine("1. Elèves" +
                "\n" +
                "2. Cours");
            Console.WriteLine();

        }

        public void VerifierErreurSaisieUtilisateur() // optimiser cette fonction pr couvrir tous les cas d'erreur du menu principal (voir programme main) 
        {
            Console.WriteLine("Valeur incorrecte, veuillez recommencer");


        }
    }
}
