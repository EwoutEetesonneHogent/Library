using Library.Domain;

namespace Library.Presentation
{
    public class LibraryApplication
    {
        private DomainManager _domainManager;

        public LibraryApplication(DomainManager domainManager)
        {
            _domainManager = domainManager;
        }
    }
}
