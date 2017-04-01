using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // Le pattern Singleton a pour but d'assurer qu'une classe ne possede qu'une seule
            // instance et de fournir une methode de classe unique retournant cet instance.

            // Initialisation du vendeur du systeme
            var leVendeur = Vendeur.Instance;
            leVendeur.Nom = "Vendeur Auto";
            leVendeur.Adresse = "Paris";
            leVendeur.Email = "vendeur@vendeur.com";

            // Affichage du vendeur du systeme
            Affiche();

            Console.ReadKey();

        }

        private static void Affiche()
        {
            var leVendeur = Vendeur.Instance;
            leVendeur.Affiche();
        }
    }
}
