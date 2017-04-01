namespace CompositePattern
{
    // Les instances de cette classe ne peuvent pas ajouter de filiales.
    public class SocieteSansFiliale : Societe
    {
        public override double CalculeCoutEntretien()
        {
            return NbrVehicules * CoutUnitVehicule;
        }

        public override bool AjouteFiliale(Societe filiale)
        {
            return false;
        }
    }
}