using System;

namespace AdapterPattern
{
    // La classe ComposantPdf represente le composant existant qui est integre dans l'application.
    // Sa conception est independante de l'application et, en particulier, de l'interface IDocument.
    // Cette classe devra etre adaptee par la suite.
    public class ComposantPdf
    {
        protected string Contenu;

        public void PdfFixeContenu(string contenu)
        {
            Contenu = contenu;
        }

        public void PdfPrepareAffichage()
        {
            Console.WriteLine("Affichage PDF : Debut");
        }

        public void PdfRafraichit()
        {
            Console.WriteLine($"Affichage contenu PDF : {Contenu}");
        }

        public void PdfTermineAffichage()
        {
            Console.WriteLine("Affichage PDF : Fin");
        }

        public void PdfEnvoieImprimante()
        {
            Console.WriteLine($"Impression PDF : {Contenu}");
        }

    }
}