namespace FactoryMethodPattern
{
    public class ClientComptant : Client
    {
        protected override Commande CreeCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}