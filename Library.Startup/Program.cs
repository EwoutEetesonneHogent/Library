using Library.Domain;
using Library.Domain.Repository;
using Library.Persistence;
using Library.Presentation;
using static Library.Startup.SecretManager;

string connectionString = SecretsManager.GetSecret("ConnectionString");

IBookRepository bookRepository = new BookRepository(connectionString);
ILendingRepository lendingRepository = new LendingRepository(connectionString);

DomainManager domainManager = new(bookRepository, lendingRepository);

LibraryApplication libraryApplication = new(domainManager);


