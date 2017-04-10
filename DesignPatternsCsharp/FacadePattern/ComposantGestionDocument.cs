namespace FacadePattern
{
    public class ComposantGestionDocument : IGestionDocument
    {
        public string Document(int index)
        {
            return "Document numero " + index;
        }
    }
}