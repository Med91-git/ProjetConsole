using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    internal class Eleve
    {
        public int Identifiant { get; init; }   
        public string Nom { get; init; }  
        public string Prenom { get; init; }
        public DateOnly DateDeNaissance { get; init; }
        public List<Note> Notes { get; set; }   

        public Eleve()
        {
            Notes = new List<Note>(); 
        } 


    }
}
