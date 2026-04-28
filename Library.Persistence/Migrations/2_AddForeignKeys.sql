ALTER TABLE [Library].[dbo].[Books]

	ADD [AuthorId] INT NOT NULL, 
    CONSTRAINT [FK_Books_Authors] FOREIGN KEY ([AuthorId]) REFERENCES [Authors]([Id])

	ALTER TABLE [Library].[dbo].[Lenders]

	ADD [LendingId] INT NOT NULL, 
    CONSTRAINT [FK_LendingsLenders] FOREIGN KEY ([LendingId]) REFERENCES [Lendings]([Id])

