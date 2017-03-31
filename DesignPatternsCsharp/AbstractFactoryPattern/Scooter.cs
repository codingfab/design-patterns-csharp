namespace AbstractFactoryPattern
{
    public abstract class Scooter
    {
        protected string Modele;
        protected string Couleur;
        protected int Puissance;

        protected Scooter(string modele, string couleur, int puissance)
        {
            Modele = modele;
            Couleur = couleur;
            Puissance = puissance;
        }

        public abstract void AfficheCaracteristiques();
    }
}