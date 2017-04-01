using System;

namespace BridgePattern
{
    // FormAppletImpl simule l'affichage et la saisie d'un formulaire a l'aide d'une applet.
    public class FormAppletImpl : IFormulaireImpl
    {
        public void DessineTexte(string texte)
        {
            Console.WriteLine($"Applet : {texte}");
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}