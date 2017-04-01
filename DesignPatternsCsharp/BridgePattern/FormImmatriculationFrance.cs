namespace BridgePattern
{
    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(IFormulaireImpl implantation) : base(implantation)
        {
        }

        // Pour la France, verifie que le numero de plaque a une longueur totale de 7.
        protected override bool ControleSaisie(string plaque)
        {
            return plaque.Length == 7;
        }
    }
}