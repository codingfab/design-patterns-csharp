namespace FactoryMethodPattern
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant)
        {
        }

        public override bool Valide()
        {
            return true;
        }

        public override void Paye()
        {
            System.Console.WriteLine($"Le paiement de la commande au comptant de : {Montant} est effectue.");
        }
    }
}