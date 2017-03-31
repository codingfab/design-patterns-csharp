using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le but du pattern est la creation de nouveaux objets par duplication
            // d'objets existants appeles prototypes qui disposent de la capacite 
            // de clonage.

            LiasseVierge liasseVierge = LiasseVierge.Instance;
            liasseVierge.Ajoute(new BonDeCommande());
            liasseVierge.Ajoute(new CertificatCession());
            liasseVierge.Ajoute(new DemandeImmatriculation());
            // Creation d'une nouvelle liasse pour deux clients
            LiasseClient liasseClient1 = new LiasseClient("Martin");
            LiasseClient liasseClient2 = new LiasseClient("Durant");

            liasseClient1.Affiche();
            liasseClient2.Affiche();

            Console.ReadKey();

        }
    }
}
