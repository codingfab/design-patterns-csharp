namespace BridgePattern
{

    // Interface decrivant l'implantation des formulaires qui contient
    // deux methodes, l'une pour afficher un texte et l'autre pour gerer
    // une zone de saisie.
    public interface IFormulaireImpl
    {
        void DessineTexte(string texte);
        string GereZoneSaisie();
    }
}