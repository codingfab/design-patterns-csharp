using System;

namespace DecoratorPattern
{
    // Le but du pattern Decorator est d'ajouter dynamiquement des fonctionnalites supplementaires
    // a un objet. Cet ajout de fonctionnalites ne modifie pas l'interface de l'objet et reste
    // donc transparent vis-a-vis des clients.
    // Le pattern Decorator constitue une alternative par rapport a la creation d'une sous-classe
    // pour enrichir un objet.

    class VueCatalogue
    {
        static void Main(string[] args)
        {
            VueVehicule vueVehicule = new VueVehicule();
            ModeleDecorateur modeleDecorateur = new ModeleDecorateur(vueVehicule);
            MarqueDecorateur marqueDecorateur = new MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.Affiche();

            Console.ReadKey();
        }
    }
}
