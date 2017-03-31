using System;

namespace AbstractFactoryPattern
{
    public class ScooterEssence : Scooter
    {
        public ScooterEssence(string modele, string couleur, int puissance) : base(modele, couleur, puissance)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine($"Scooter a essence\n" +
                              $"modele:{Modele}\n" +
                              $"couleur:{Couleur}\n" +
                              $"puissance:{Puissance}");
        }
    }
}