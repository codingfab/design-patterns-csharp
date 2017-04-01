namespace CompositePattern
{
    public abstract class Societe
    {
        protected static double CoutUnitVehicule = 5d;
        protected int NbrVehicules;

        public void AjouteVehicule()
        {
            NbrVehicules++;
        }

        public abstract double CalculeCoutEntretien();

        // AjouteFiliale renvoie un booleen qui indique si l'ajout a pu ou non etre realise.
        public abstract bool AjouteFiliale(Societe filiale);
    }
}