using System;

namespace CompositePattern
{
    class Utilisateur
    {
        // Le pattern Composite est d'offrir un cadre de conception d'une composition d'objets
        // dont la profondeur est variable, cette conception etant basee sur un arbre.
        // Par ailleurs, cette composition est encapsulee vis-a-vis des clients des objets
        // qui peuvent interagir sans devoir connaitre la profondeur de la composition.

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
            Console.WriteLine(
                $"Cout d'entretien total du groupe : {groupe.CalculeCoutEntretien()}");

            Console.ReadKey();
        }
    }
}
