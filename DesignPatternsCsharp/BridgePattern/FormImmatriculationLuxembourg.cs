namespace BridgePattern
{
    public class FormImmatriculationLuxembourg : FormulaireImmatriculation
    {
        public FormImmatriculationLuxembourg(IFormulaireImpl implantation) : base(implantation)
        {
        }

        // Verifie que le numero de la plaque a une longueur de 5.
        protected override bool ControleSaisie(string plaque)
        {
            return plaque.Length == 5;
        }
    }
}