using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ProjetConsole
{
    internal class Cours
    {
        public int Identifiant { get; init; }    
        public string Nom { get; init; }  
        public Note note { get; init; } 

        public Cours()   
        {
            
            note = new Note(); // lors de la création d'un cours, il y aura forcément une note associée pour evaluer l'élève 

        }
    }
}
