namespace PrototypePattern
{
    public abstract class Document
    {
        protected string Contenu = "";
        
        public Document Duplique()
        {
            Document resultat;
            resultat = (Document) this.MemberwiseClone();
            return resultat;
        }

        public void Remplit(string informations)
        {
            Contenu = informations;
        }

        public abstract void Imprime();
        public abstract void Affiche();
    }
}