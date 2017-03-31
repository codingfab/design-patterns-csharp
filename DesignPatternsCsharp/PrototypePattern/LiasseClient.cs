using System.Collections.Generic;

namespace PrototypePattern
{
    public class LiasseClient : Liasse
    {
        public LiasseClient(string informations)
        {
            Documents = new List<Document>();
            LiasseVierge laLiasseVierge = LiasseVierge.Instance;
            IList<Document> documentsVierges = laLiasseVierge.Documents;
            foreach (var document in documentsVierges)
            {
                Document copieDocument = document.Duplique();
                copieDocument.Remplit(informations);
                Documents.Add(copieDocument);
            }
        }

        public void Affiche()
        {
            foreach (var document in Documents)
            {
                document.Affiche();
            }
        }

        public void Imprime()
        {
            foreach (var document in Documents)
            {
                document.Imprime();
            }
        }
    }
}