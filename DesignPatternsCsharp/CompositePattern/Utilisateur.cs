using System;

namespace CompositePattern
{
    class Utilisateur
    {
        static void Main(string[] args)
        {
            Societe societe1 = new SocieteSansFiliale();
            societe1.AjouteVehicule();
            Societe societe2 = new SocieteSansFiliale();
            societe2.AjouteVehicule();
            societe2.AjouteVehicule();
            Societe groupe = new SocieteMere();
            groupe.AjouteFiliale(societe1);
            groupe.AjouteFiliale(societe2);
            groupe.AjouteVehicule();
            Console.WriteLine($"Cout d'entretien total du groupe : {groupe.CalculeCoutEntretien()}");

            Console.ReadKey();
        }
    }
}
