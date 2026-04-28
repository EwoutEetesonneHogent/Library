using Library.Domain;
using Library.Domain.Repository;
using Library.Persistence;
using Library.Presentation;

// Arnout was here

IBookRepository bookRepository = new BookRepository();
ILendingRepository lendingRepository = new LendingRepository();

DomainManager domainManager = new(bookRepository, lendingRepository);

LibraryApplication libraryApplication = new(domainManager);