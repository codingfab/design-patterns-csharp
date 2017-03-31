using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le but du pattern Builder est d'abstraire la construction d'objets complexes
            // de leur implantation de sorte qu'un client puisse cree des objets complexes
            // sans devoir se preoccuper des differences d'implantation.

            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire des liasses HTML [1] ou PDF [2] :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }
            Vendeur vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.Construit("Martin");
            liasse.Imprime();

            Console.ReadKey();

        }
    }
}
