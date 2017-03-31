using System;

namespace BuilderPattern
{
    public class LiassePdf : Liasse
    {
        public override void AjouteDocument(string document)
        {
            if(document.StartsWith("<PDF>"))
                Contenu.Add(document);
        }

        public override void Imprime()
        {
            Console.WriteLine("Liasse PDF");
            foreach (var s in Contenu)
                Console.WriteLine(s);
        }
    }
}