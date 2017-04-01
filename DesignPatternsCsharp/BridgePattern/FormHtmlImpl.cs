using System;

namespace BridgePattern
{
    // FormHtmlImpl simule l'affichage et la saisie d'un formulaire HTML.
    public class FormHtmlImpl : IFormulaireImpl
    {
        public void DessineTexte(string texte)
        {
            Console.WriteLine($"HTML : {texte}");
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }

}