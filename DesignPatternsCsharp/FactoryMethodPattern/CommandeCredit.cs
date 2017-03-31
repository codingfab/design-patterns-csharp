using System;

namespace FactoryMethodPattern
{
    public class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant)
        {
        }

        public override bool Valide()
        {
            return (Montant >= 1000.0) && (Montant <= 5000.0);
        }

        public override void Paye()
        {
            Console.WriteLine($"Le paiement de la commande au credit de : {Montant} est effectue.");
        }
    }
}