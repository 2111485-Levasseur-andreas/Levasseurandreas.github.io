using System; 

namespace TourZorkpremierePartie
{
    class Acteur
    {
               public string Nom{get; set;}
               public string Description{get; set;}
                public double MaxHp{get; set;}
                public double Hp{get; set;}
                public double MaxArmure{get; set;}
                public double Armure{get; set;}
                public double RegenArmure{get; set;}
                public double Agilite{get; set;}
                public double Dommage{get; set;}
                public double TauxCritique{get; set;}     

                public Acteur(string nom, string description, double maxHp, double Hp, double maxArmure, double armure, double regenArmure, double agilite, double dommage, double tauxCritique)
                {
                    this.Nom = nom; 
                    this.Description = description; 
                    this.MaxHp = maxHp; 
                    this.Hp = Hp;
                    this.MaxArmure = maxArmure; 
                    this.Armure = armure;
                    this.RegenArmure = regenArmure;
                    this.Agilite = agilite;
                    this.Dommage = dommage; 
                    this.TauxCritique = Agilite/2; 
                }

                
                
             public void Attaquer(Acteur autreActeur)
             {
                 Random aleatoire = new Random();
                 double touche = aleatoire.Next(1, 101);  
                 double DommageQuiFontMal = this.Dommage; 

                 if(touche >= this.TauxCritique)
                 {
                    Dommage*=Dommage/1.5; 
                    autreActeur.Defendre(DommageQuiFontMal); 
                    Console.WriteLine($"{this.Nom} A fait un coup qui fait mal ! {autreActeur.Nom} A eu très très bobo car il a reçus {DommageQuiFontMal} points de dommage !!"); 

                 }
                 else if (touche <=autreActeur.Agilite)

                 {
                     Console.WriteLine($"{autreActeur.Nom} A manqué ton attaque... peut être qu'une prochaine fois il rentrera dedans...");
                 }
                 else
                 {
                     autreActeur.Defendre(DommageQuiFontMal);
                     Console.WriteLine($"{autreActeur.Nom} A eu dans sa face {DommageQuiFontMal} points de dommage");
                 }
             }

             public void Defendre(double Dommage)
             {  
                 this.Armure -=this.Dommage;

                if(this.Armure <=0){
                 this.Armure=0; 
                 this.Hp-=this.Dommage;
             }
             this.Armure +=this.RegenArmure; 
             }

             public bool  estVivant()
        {
            return !(this.Hp <= 0);
        }

             public void AfficherEtat()
             {
                 System.Console.WriteLine($"{this.Hp}{this.Armure}"); 
                 System.Console.ReadLine(); 

             }

             

    }
}