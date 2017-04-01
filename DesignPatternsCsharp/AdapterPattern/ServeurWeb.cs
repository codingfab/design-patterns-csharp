// Le but du pattern Adapter est de convertir l'interface d'une classe 
// existante en l'interface attendue par des clients egalement existants
// afin qu'ils puissent travailler ensemble. Il s'agit de conferer a une 
// classe existante une nouvelle interface pour repondre aux besoin de clients.

using System;

namespace AdapterPattern
{
    // Le programme principal correspond a la classe ServeurWeb qui cree un document HTML, en fixe
    // le contenu puis le dessine.
    // Ensuite le programme fait la meme chose avec un document PDF. 
    class ServeurWeb
    {
        static void Main(string[] args)
        {
            IDocument document1, document2;
            document1 = new DocumentHtml {Contenu = "Hello"};
            document1.Dessine();
            Console.WriteLine();
            document2 = new DocumentPdf {Contenu = "Bonjour"};
            document2.Dessine();

            Console.ReadKey();
        }
    }
}
