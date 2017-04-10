using System.Collections.Generic;

namespace FacadePattern
{
    // L'interface de la facade appelee WebServiceAuto introduit la signature de deux
    // methodes destinees aux clients du service Web
    public interface IWebServiceAuto
    {
        string Document(int index);
        IList<string> ChercheVehicules(int prixMoyen, int ecartMax);
    }

    public class WebServiceAutoImpl : IWebServiceAuto
    {
        protected ICatalogue Catalogue = new ComposantCatalogue();
        protected IGestionDocument GestionDocument = new ComposantGestionDocument();

        public string Document(int index)
        {
            return GestionDocument.Document(index);
        }

        public IList<string> ChercheVehicules(int prixMoyen, int ecartMax)
        {
            // Remarquons le calcul du prix minimum et maximum pour pouvoir invoquer la methode
            // RetrouveVehicules de la classe ComposantCatalogue.
            return Catalogue.RetrouveVehicules(prixMoyen - ecartMax, prixMoyen + ecartMax);
        }

    }
}