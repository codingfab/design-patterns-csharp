using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class VehiculeCommande
    {
        protected IList<OptionVehicule> Options = new List<OptionVehicule>();
        protected IList<int> PrixDeVenteOptions = new List<int>();

        public void AjouteOptions(string nom, int prixDeVente, FabriqueOption fabrique)
        {
            Options.Add(fabrique.GetOption(nom));
            PrixDeVenteOptions.Add(prixDeVente);
        }

        public void AfficheOptions()
        {
            int taille = Options.Count;
            for (int i = 0; i < taille; i++)
            {
                Options[i].Affiche(PrixDeVenteOptions[i]);
                Console.WriteLine();
            }
        }
    }
}