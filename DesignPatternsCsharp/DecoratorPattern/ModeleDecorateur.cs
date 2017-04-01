using System;

namespace DecoratorPattern
{
    // La methode Affiche du decorateur concret ModeleDecorateur appelle l'affichage
    // du composant (au travers de la methode Affiche de Decorateur) puis affiche les 
    // informations techniques du modele.
    public class ModeleDecorateur : Decorateur
    {
        public ModeleDecorateur(IComposantGraphiqueVehicule composant) 
            : base(composant)
        {
        }

        protected void AfficheInfosTechniques()
        {
            Console.WriteLine("Informations techniques du modele");
        }

        public override void Affiche()
        {
            base.Affiche();
            AfficheInfosTechniques();
        }
    }

    public class MarqueDecorateur : Decorateur
    {
        public MarqueDecorateur(IComposantGraphiqueVehicule composant) 
            : base(composant)
        {
        }

        protected void AfficheLogo()
        {
            Console.WriteLine("Logo de la marque");
        }

        public override void Affiche()
        {
            base.Affiche();
            AfficheLogo();
        }
    }
}