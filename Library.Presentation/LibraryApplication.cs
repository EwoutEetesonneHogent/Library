using Library.Domain;
using Spectre.Console;

namespace Library.Presentation
{
    public class LibraryApplication
    {
        private DomainManager _domainManager;

        public LibraryApplication(DomainManager domainManager)
        {
            _domainManager = domainManager;
            StartApplication();
        }

        private void StartApplication()
        {
            bool running = true;
            while (true)
            {
                string choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[bold yellow]Library - select an option:")
                        .AddChoices(
                        "Find book(s) by author",
                        "Show lenders with loans on alphabetic order",
                        "Show books that are overdue",
                        "Extend lending due date by 14 days",
                        "Close"
                        ));

                Console.Clear();

                switch (choice)
                {
                    case "Find book(s) by author":
                        ShowBooksByAuthor();
                        break;
                    case "Show lenders with loans on alphabetic order":
                        ShowLendersWithLoans();
                        break;
                    case "Show books that are overdue":
                        ShowOverdueBooks();
                        break;
                    case "Extend lending due date by 14 days":
                        ExtendLendingDueDate();
                        break;
                        break;
                    case "Close":
                        running = false;
                        break;
                }
            }
        }

        private void ShowBooksByAuthor()
        {
            string author = AnsiConsole.Ask<string>("Enter the name of the author: ");

            var books = _domainManager.GetBooksByAuthor(author);

            if (!books.Any())
            {
                AnsiConsole.MarkupLine("[red]No books found for the specified author.");
                return;
            }

            Table table = new Table();
            table.Title("[bold]Book(s) from author");
            table.AddColumn("Title");
            table.AddColumn("Publication year");
            table.AddColumn("Author");

            table.AddRow("Title");
            table.AddRow("2026");
            table.AddRow("Author");

            AnsiConsole.Write(table);
        }

        private void ShowLendersWithLoans()
        {
            var lenders = _domainManager.GetLendersWithLoans();

            if (!lenders.Any())
            {
                AnsiConsole.MarkupLine("[red]No lenders with loans found.");
                return;
            }

            Table table = new Table();
            table.Title("[bold]Lenders with loans");
            table.AddColumn("Name");
            table.AddColumn("Loaned books");

            table.AddRow("Name");
            table.AddRow("Loaned books");

            AnsiConsole.Write(table);
        }

        private void ShowOverdueBooks()
        {
            var books = _domainManager.GetOverdueBooks();

            if (!books.Any())
            {
                AnsiConsole.MarkupLine("[red]No overdue books found.");
                return;
            }

            Table table = new Table();
            table.Title("[bold]Overdue books");
            table.AddColumn("Title");
            table.AddColumn("Loaner");
            table.AddColumn("Date loan");
            table.AddColumn("Due date");

            table.AddRow("Title");
            table.AddRow("Loaner");
            table.AddRow("Date loan");
            table.AddRow("Due date");
            
            AnsiConsole.Write(table);
        }

        private void ExtendLendingDueDate()
        {
            int lendingId = AnsiConsole.Ask<int>("Enter the ID of the lending to extend: ");

            bool isExtended = _domainManager.ExtendLendingDueDate(lendingId);

            if (isExtended)
            {
                AnsiConsole.MarkupLine("[green]Lending due date has been extended by 14 days.");
            } else
            {
                AnsiConsole.MarkupLine("[red]Could not extend lending date. Check the lending ID.");
            }

            AnsiConsole.MarkupLine("[grey]Press any key to return to the main menu...");
            Console.ReadKey(true);
        }
    }
}
