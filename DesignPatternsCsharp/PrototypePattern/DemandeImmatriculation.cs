using System;

namespace PrototypePattern
{
    public class DemandeImmatriculation : Document
    {
        public override void Imprime()
        {
            Console.WriteLine($"Affiche la demande d'immatriculation {Contenu}");
        }

        public override void Affiche()
        {
            Console.WriteLine($"Imprime la demande d'immatriculation {Contenu}");
        }
    }
}