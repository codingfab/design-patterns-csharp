using System;

namespace AbstractFactoryPattern
{
    public class ScooterElectricite : Scooter
    {
        public ScooterElectricite(string modele, string couleur, int puissance) 
            : base(modele, couleur, puissance)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine($"Scooter electrique\n" +
                              $"modele: {Modele}\n" +
                              $"couleur:{Couleur}\n" +
                              $"puissance:{Puissance}"); ;
        }
    }
}