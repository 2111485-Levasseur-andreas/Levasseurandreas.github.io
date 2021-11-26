using System;
using System.IO; 

namespace Texte
{

    class Program
    {
        static void Main(string[] args)
        {
            string texte = "";
            
            StreamReader lecteur = new StreamReader("MonTexte.txt");

            while(!lecteur.EndOfStream)
            {
                texte = lecteur.ReadLine(); 
                Console.WriteLine(texte);
            }
            lecteur.Close(); 
            Console.ReadLine(); 
        }
    }
}