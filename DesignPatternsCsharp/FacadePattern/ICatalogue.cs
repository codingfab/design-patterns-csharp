using System.Collections.Generic;

namespace FacadePattern
{
    public interface ICatalogue
    {
        IList<string> RetrouveVehicules(int prixMin, int prixMax);
    }
}