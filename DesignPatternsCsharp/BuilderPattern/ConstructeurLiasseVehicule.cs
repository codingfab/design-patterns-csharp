namespace BuilderPattern
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse Liasse;

        public abstract void ConstruitBonDeCommande(string nomClient);

        public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);

        public Liasse Resultat
        {
            get
            {
                return Liasse;
            }
        }
    }
}