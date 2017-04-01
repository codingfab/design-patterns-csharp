using System;

namespace AdapterPattern
{
    // La classe DocumentHtml est l'exemple de classe implementant l'interface IDocument.
    public class DocumentHtml : IDocument
    {
        public string Contenu { get; set; }
        
        public void Dessine()
        {
            Console.WriteLine($"Dessine document HTML : {Contenu}");
        }

        public void Imprime()
        {
            Console.WriteLine($"Imprime le document HTML : {Contenu}");
        }
    }
}