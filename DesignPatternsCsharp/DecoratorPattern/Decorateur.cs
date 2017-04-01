namespace DecoratorPattern
{
    // Implemente la methode affiche en deleguant l'appel. Elle detient un attribut qui 
    // contient une reference vers un composant. Ce dernier est passe en parametre au 
    // constructeur de Decorateur.
    public abstract class Decorateur : IComposantGraphiqueVehicule
    {
        protected IComposantGraphiqueVehicule Composant;

        protected Decorateur(IComposantGraphiqueVehicule composant)
        {
            Composant = composant;
        }

        public virtual void Affiche()
        {
            Composant.Affiche();
        }
    }
}