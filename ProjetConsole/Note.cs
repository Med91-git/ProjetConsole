using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class Note
    {
        private int valeur;
        private string appreciation;

        public Note(int valeur, string appreciation = null) 
        {
            this.valeur = valeur;
            this.appreciation = appreciation; 
        } 

    }
}
