using System;
using System.Collections.Generic;

namespace FacadePattern
{
    // L'objectif du pattern Facade est de regrouper les interfaces d'un ensemble d'objets en une interface
    // unifiee rendant cet ensemble plus simple a utiliser pour un client.

    // Le pattern Facade encapsule l'interface de chaque objet consideree comme interface de bas niveau
    // dans une interface unique de niveau plus eleve. La construction de l'interface unifiee peut necessiter
    // d'implementer des methodes destinees a composer les interfaces de bas niveau.

    class UtilisateurServiceWeb
    {
        static void Main(string[] args)
        {
            IWebServiceAuto webServiceAuto = new WebServiceAutoImpl();
            Console.WriteLine(webServiceAuto.Document(0));
            Console.WriteLine(webServiceAuto.Document(1));
            IList<string> resultats = webServiceAuto.ChercheVehicules(6000, 1000);
            if (resultats.Count > 0)
            {
                Console.WriteLine("Vehicule(s) dont le prix est compris entre 5000 et 7000");
                foreach (var resultat in resultats)
                    Console.WriteLine(" " + resultat);
            }

            Console.ReadKey();
        }
    }
}
