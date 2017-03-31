using System.Collections.Generic;

namespace PrototypePattern
{
    public abstract class Liasse
    {
        public IList<Document> Documents { get; protected set; }
    }
}