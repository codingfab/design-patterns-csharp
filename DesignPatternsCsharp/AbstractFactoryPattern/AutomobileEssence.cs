using System;

namespace AbstractFactoryPattern
{
    public class AutomobileEssence : Automobile
    {
        public AutomobileEssence(string modele, string couleur, int puissance, double espace) 
            : base(modele, couleur, puissance, espace)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine($"Automobile a essence\n" +
                              $"modele: {Modele}\n" +
                              $"couleur: {Couleur}\n" +
                              $"puissance:{Puissance}\n" +
                              $"espace:{Espace}");
        }
    }
}