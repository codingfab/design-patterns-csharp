using System;

namespace FlyweightPattern
{
    public class OptionVehicule
    {
        protected string Nom;
        protected string Description;
        protected int PrixStandard;

        public OptionVehicule(string nom)
        {
            Nom = nom;
            Description = "Description de " + nom;
            PrixStandard = 100;
        }

        public void Affiche(int prixDeVente)
        {
            Console.WriteLine("Option");
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine(Description);
            Console.WriteLine($"Prix standard : {PrixStandard}");
            Console.WriteLine($"Prix de vente : {prixDeVente}");
        }

    }
}