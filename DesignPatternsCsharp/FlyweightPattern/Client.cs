using System;

namespace FlyweightPattern
{
    // Le but du pattern Flyweight est de partager de facon efficace un ensemble
    // important d'objets de grain fin.
    class Client
    {
        static void Main(string[] args)
        {
            FabriqueOption fabrique = new FabriqueOption();
            VehiculeCommande vehicule = new VehiculeCommande();
            vehicule.AjouteOptions("air bag",80,fabrique);
            vehicule.AjouteOptions("direction assistee",90,fabrique);
            vehicule.AjouteOptions("vitres electriques",85,fabrique);
            vehicule.AfficheOptions();

            Console.ReadKey();
        }
    }
}
