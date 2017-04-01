using System;

namespace SingletonPattern
{
    public class Vendeur
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }

        private static Vendeur _instance = null;

        private Vendeur()
        {
            
        }

        public static Vendeur Instance
        {
            get { return _instance ?? (_instance = new Vendeur()); }
        }

        public void Affiche()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Adresse : {Adresse}");
            Console.WriteLine($"Email : {Email}");
        }

    }
}