using System.Collections.Generic;

namespace CompositePattern
{
    public class SocieteMere : Societe
    {
        protected IList<Societe> Filiales = new List<Societe>();

        // Le resultat de CalculeCoutEntretien est la somme du cout des filiales
        // et du cout de la societe mere.
        public override double CalculeCoutEntretien()
        {
            double cout = 0.0d;
            foreach (Societe filiale in Filiales)
                cout = cout + filiale.CalculeCoutEntretien();
            return cout + NbrVehicules*CoutUnitVehicule;
        }

        public override bool AjouteFiliale(Societe filiale)
        {
            Filiales.Add(filiale);
            return true;
        }
    }
}