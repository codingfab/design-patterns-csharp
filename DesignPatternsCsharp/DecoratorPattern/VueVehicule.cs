using System;

namespace DecoratorPattern
{
    // Implemente la methode affiche de l'interface IComposantGraphiqueVehicule
    public class VueVehicule : IComposantGraphiqueVehicule
    {
        public void Affiche()
        {
            Console.WriteLine("Affichage du vehicule");
        }
    }
}