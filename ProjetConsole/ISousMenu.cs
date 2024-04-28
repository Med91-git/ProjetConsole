using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal interface ISousMenu
    {

        void AfficherOptionsSousMenu();
        void VerifierSaisieUtilisateurSousMenu();
        void RevenirAuMenuPrincipal();  
    }
}
