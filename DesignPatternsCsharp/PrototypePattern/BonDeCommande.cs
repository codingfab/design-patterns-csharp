using System;

namespace PrototypePattern
{
    public class BonDeCommande : Document
    {
        public override void Imprime()
        {
            Console.WriteLine($"Imprime le bon de commande : {Contenu}");
        }

        public override void Affiche()
        {
            Console.WriteLine($"Affiche le bon de commande : {Contenu}");
        }
    }
}