namespace AdapterPattern
{
    public interface IDocument
    {
        string Contenu { set; }
        void Dessine();
        void Imprime();
    }
}