using System;

namespace AbstractFactoryPattern
{
    public class AutomobileElectricite : Automobile
    {
        public AutomobileElectricite(string modele, string couleur, int puissance, double espace) 
            : base(modele, couleur, puissance, espace)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine($"Automobile electrique\n" +
                              $"modele: {Modele}\n" +
                              $"couleur: {Couleur}\n" +
                              $"puissance:{Puissance}\n" +
                              $"espace:{Espace}");
        }
    }
}