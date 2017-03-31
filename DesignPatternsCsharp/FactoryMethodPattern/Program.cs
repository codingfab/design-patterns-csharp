using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le but du pattern Factory Method est d'introduire une methode abstraite
            // de creation d'un objet en reportant aux sous-classes concretes la creation 
            // effective.

            Client client;
            client = new ClientComptant();
            client.NouvelleCommande(2000d);
            client.NouvelleCommande(10000d);
            client = new ClientCredit();
            client.NouvelleCommande(2000d);
            client.NouvelleCommande(10000d);

            Console.ReadKey();

        }
    }
}
