using System.Collections.Generic;

namespace FlyweightPattern
{
    public class FabriqueOption
    {
        protected IDictionary<string, OptionVehicule> Options =
            new Dictionary<string, OptionVehicule>();

        public OptionVehicule GetOption(string nom)
        {
            OptionVehicule resultat;
            if (Options.ContainsKey(nom))
                resultat = Options[nom];
            else
            {
                resultat = new OptionVehicule(nom);
                Options.Add(nom, resultat);
            }
            return resultat;
        }
    }
}