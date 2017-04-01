using System;

namespace BridgePattern
{
    // Le but du pattern Bridge est de separer l'aspect d'implantation d'un objet de son
    // aspect de representation et d'interface.
    // Ainsi, d'une part l'implantation peut etre totalement encapsulee et d'autre part
    // l'implantation et la representation peuvent evoluer independamment et sans que
    // l'une exerce une contrainte sur l'autre.

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
