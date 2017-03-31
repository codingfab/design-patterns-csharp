namespace BuilderPattern
{
    public class ConstructeurLiasseVehiculeHtml
        : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            Liasse = new LiasseHtml();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = $"<HTML>Bon de commande Client : {nomClient}</HTML>";
            Liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = $"<HTML>Demande d'immatriculation Demandeur : {nomDemandeur}</HTML>";
            Liasse.AjouteDocument(document);
        }
    }
}