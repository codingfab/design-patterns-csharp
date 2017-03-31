using System.Collections.Generic;

namespace BuilderPattern
{
    public abstract class Liasse
    {
        protected IList<string> Contenu = new List<string>();

        public abstract void AjouteDocument(string document);
        public abstract void Imprime();
    }
}