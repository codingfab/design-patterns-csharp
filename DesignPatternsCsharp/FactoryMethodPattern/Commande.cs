namespace FactoryMethodPattern
{
    public abstract class Commande
    {
        protected double Montant;

        protected Commande(double montant)
        {
            Montant = montant;
        }

        public abstract bool Valide();
        public abstract void Paye();
    }
}