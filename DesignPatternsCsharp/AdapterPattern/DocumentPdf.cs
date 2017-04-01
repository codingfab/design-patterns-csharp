namespace AdapterPattern
{
    // La classe DocumentPdf represente l'adapteur. Elle est associee a la classe ComposantPdf
    // au travers de l'attribut OutilPdf qui associe l'objet adapte.
    // Elle implemente l'interface document et chacune de ses methodes invoque les methodes
    // necessaires de l'objet adapte afin de realiser l'adaptation entre les deux interfaces.
    public class DocumentPdf : IDocument
    {
        protected ComposantPdf OutilPdf = new ComposantPdf();

        public string Contenu
        {
            set
            {
                OutilPdf.PdfFixeContenu(value);
            }
        }

        public void Dessine()
        {
            OutilPdf.PdfPrepareAffichage();
            OutilPdf.PdfRafraichit();
            OutilPdf.PdfTermineAffichage();
        }

        public void Imprime()
        {
            OutilPdf.PdfEnvoieImprimante();
        }
    }
}