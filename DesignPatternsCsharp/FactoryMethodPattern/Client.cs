using System.Collections.Generic;

namespace FactoryMethodPattern
{
    public abstract class Client
    {
        protected IList<Commande> Commandes = new List<Commande>();

        protected abstract Commande CreeCommande(double montant);

        public void NouvelleCommande(double montant)
        {
            Commande commande = CreeCommande(montant);
            if (commande.Valide())
            {
                commande.Paye();
                Commandes.Add(commande);
            }
        }
    }
}