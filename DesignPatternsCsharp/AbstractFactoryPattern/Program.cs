using System;

namespace AbstractFactoryPattern
{
    class Program
    {

        public static int NbAutos = 3;
        public static int NbScooters = 2;

        static void Main(string[] args)
        {
            // Abstract Factory: Le but du pattern Abstract Factory est la creation d'objets regroupes 
            // en familles sans devoir connaitre les classes  concretes destinees a la creation de ces
            // objets.

            IFabriqueVehicule fabrique;

            Automobile[] autos = new Automobile[NbAutos];
            Scooter[] scooters = new Scooter[NbScooters];

            Console.WriteLine("Voulez-vous utiliser des vehicules electriques [1] ou a essence [2]:");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                fabrique = new FabriqueVehiculeElectricite();
            }
            else
            {
                fabrique = new FabriqueVehiculeEssence();
            }
            for (int i = 0; i < NbAutos; i++)
                autos[i] = fabrique.CreeAutomobile("standard", "jaune", 6 + i, 3.2);
            for (int i = 0; i < NbScooters; i++)
                scooters[i] = fabrique.CreeScooter("classic", "rouge", 2 + i);

            foreach (var auto in autos)
                auto.AfficheCaracteristiques();
            foreach (var scooter in scooters)
                scooter.AfficheCaracteristiques();

            Console.ReadKey();
        }
    }
}
