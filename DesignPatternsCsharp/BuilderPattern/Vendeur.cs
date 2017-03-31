namespace BuilderPattern
{
    public class Vendeur
    {
        protected ConstructeurLiasseVehicule Constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            Constructeur = constructeur;
        }

        public Liasse Construit(string nomClient)
        {
            Constructeur.ConstruitBonDeCommande(nomClient);
            Constructeur.ConstruitDemandeImmatriculation(nomClient);
            Liasse liasse = Constructeur.Resultat;
            return liasse;
        }
    }
}