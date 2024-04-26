using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class Cours
    {
        private int identifiant; 
        private string nom;

        public Cours(string nom, int identifiant) 
        {
            this.nom = nom;
            this.identifiant = identifiant; 

        }
    }
}
