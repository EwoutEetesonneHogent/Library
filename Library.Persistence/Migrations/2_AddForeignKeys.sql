ALTER TABLE [Library].[dbo].[Books]

	ADD [AuthorId] INT NOT NULL, 
    CONSTRAINT [FK_Books_Authors] FOREIGN KEY ([AuthorId]) REFERENCES [Authors]([Id])

	ALTER TABLE [Library].[dbo].[Lenders]

	ADD [LendingId] INT NOT NULL, 
    CONSTRAINT [FK_Lendings_Lenders] FOREIGN KEY ([LendingId]) REFERENCES [Lendings]([Id])

