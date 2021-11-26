using System;
using System.IO; 

namespace TourZorkpremierePartie
{
    public class GenerateurClasse
    {
        public string[] Questions {get; set;}
        public Acteur[] Classes {get; set;}
        public int Guerrier {get; set;}
        public int Magicien {get; set;}
        public int Voleur {get; set;}
    

        public GenerateurClasse()
        {
            string message=""; 
            this.Questions[i] = message;
            int++; 
        }
        private Acteur DecoderClasses(string[] tableau) 
        {
            //Texte= lecteur.ReadLine();
            //stats=Texte.split(;);
            //Acteur[i]=DecoderClasse(stats); 
        }

        public void GenererClasse()
        {

        }

        public void PoserQuestion()
        {
            //poser questions 1-2-3 et faire voleur++ si réponse concorde avec cette classe etc.  
        }
    }
 }