using System; 

namespace POOActeur
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

                public Acteur( string nom, string description, double maxHp, double Hp, double maxArmure, double armure, double regenArmure, double agilite, double dommage, double tauxCritique)
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
                    this.TauxCritique = tauxCritique; 
                }
                
             public void Attaquer(Acteur autreActeur)
             {
                 Random aleatoire = new Random(1-100); 
                 if(aleatoire<=100)
                 {
                    Dommage*=Dommage/1.5; 
                 }
                 if(aleatoire<=Agilite)
                 {
                     Dommage==0; 
                 }
                 else
                 {
                     Dommage==Dommage; 
                 }
             }

             public void Defendre(double Dommage)
             {

             }

             public void estVivant()
             {
                 bool vivant= false; 
                if(Hp>0)
                {
                    vivant+=true; 
                }
                else
                {
                    vivant+=false; 
                }
             }

             public void AfficherEtat()
             {
                

             }

             

    }
}