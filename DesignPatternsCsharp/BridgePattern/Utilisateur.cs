using System;

namespace BridgePattern
{
    class Utilisateur
    {
        // Les numeros de plaques introduits sont 2345X et CS666FS
        static void Main(string[] args)
        {
            var formulaire1 = 
                new FormImmatriculationLuxembourg(new FormHtmlImpl());
            formulaire1.Affiche();
            if(formulaire1.GereSaisie())
                formulaire1.GenereDocument();
            Console.WriteLine();
            var formulaire2 = 
                new FormImmatriculationFrance(new FormAppletImpl());
            formulaire2.Affiche();
            if(formulaire2.GereSaisie())
                formulaire2.GenereDocument();
            
            Console.ReadKey();
        }
    }
}
