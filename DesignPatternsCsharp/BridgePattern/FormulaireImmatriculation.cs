namespace BridgePattern
{

    public abstract class FormulaireImmatriculation
    {
        protected string Contenu;
        protected IFormulaireImpl Implantation;

        // Le constructeur prend en parametre une instance gerant l'implantation et qui
        // est utilisee dans les autres methodes pour dessiner du texte ou gerer la saisie
        // d'entrees au clavier.
        protected FormulaireImmatriculation(IFormulaireImpl implantation)
        {
            Implantation = implantation;
        }

        public void Affiche()
        {
            Implantation.DessineTexte("numero de plaque existante : ");
        }

        public void GenereDocument()
        {
            Implantation.DessineTexte("Demande d'immatriculation");
            Implantation.DessineTexte($"numero de plaque : {Contenu}");
        }

        public bool GereSaisie()
        {
            Contenu = Implantation.GereZoneSaisie();
            return ControleSaisie(Contenu);
        }

        // ControleSaisie verifie que le numero de d'une plaque d'immatriculation est correct,
        // ce qui depend du pays. Cette methode est donc abstraite et implantee dans les sous-classes.
        protected abstract bool ControleSaisie(string plaque);
    }
}