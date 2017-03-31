namespace BuilderPattern
{
    public class ConstructeurLiasseVehiculePdf
        : ConstructeurLiasseVehicule
    {

        public ConstructeurLiasseVehiculePdf()
        {
            Liasse = new LiassePdf();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = $"<PDF>Bon de commande client : {nomClient}</PDF>";
            Liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = $"<PDF>Demande d'immatriculation demandeur : {nomDemandeur}</PDF>";
            Liasse.AjouteDocument(document);
        }
    }
}