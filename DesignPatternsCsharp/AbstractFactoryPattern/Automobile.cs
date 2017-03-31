namespace AbstractFactoryPattern
{
    public abstract class Automobile
    {
        protected string Modele;
        protected string Couleur;
        protected int Puissance;
        protected double Espace;

        protected Automobile(string modele, string couleur, int puissance, double espace)
        {
            Modele = modele;
            Couleur = couleur;
            Puissance = puissance;
            Espace = espace;
        }

        public abstract void AfficheCaracteristiques();
    }
}