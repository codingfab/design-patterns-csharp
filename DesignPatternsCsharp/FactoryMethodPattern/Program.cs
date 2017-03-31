using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

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
