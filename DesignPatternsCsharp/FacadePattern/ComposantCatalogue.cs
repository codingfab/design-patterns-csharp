using System.Collections.Generic;

namespace FacadePattern
{
    // La base de donnees constituant le catalogue est remplacee par un simple tableau d'objets.
    // La methode RetrouveVehicules effectue la recherche d'un ou de plusieurs vehicules en fonction
    // de leur prix a l'aide d'une simple boucle.
    public class ComposantCatalogue : ICatalogue
    {
        protected object[] DescriptionsVehicule =
        {
            "Berline 5 portes", 6000, "Compact 3 portes", 4000,
            "Espace 5 portes", 8000, "Break 5 portes", 7000,
            "Coupe 2 portes", 9000, "Utilitaire 3 portes", 5000
        };

        public IList<string> RetrouveVehicules(int prixMin, int prixMax)
        {
            IList<string> resultat = new List<string>();
            var taille = DescriptionsVehicule.Length/2;
            for (int i = 0; i < taille; i++)
            {
                int prix = (int) DescriptionsVehicule[2*i + 1];
                if((prix >= prixMin) && (prix <= prixMax))
                    resultat.Add((string)DescriptionsVehicule[2*i]);
            }
            return resultat;
        }
    }
}