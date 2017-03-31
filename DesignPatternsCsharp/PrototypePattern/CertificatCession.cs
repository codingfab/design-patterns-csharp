using System;

namespace PrototypePattern
{
    public class CertificatCession : Document
    {
        public override void Imprime()
        {
            Console.WriteLine($"Imprime le certificat de cession : {Contenu}");
        }

        public override void Affiche()
        {
            Console.WriteLine($"Affiche le certificat de cession : {Contenu}");
        }
    }
}