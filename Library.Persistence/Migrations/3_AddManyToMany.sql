CREATE TABLE [dbo].[BookLendings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[BookId] INT NOT NULL,
	[LendingId] INT NOT NULL, 
    CONSTRAINT [FK_BookLendings_Lendings] FOREIGN KEY ([BookId]) REFERENCES [Books]([Id]), 
    CONSTRAINT [FK_BookLendings_Books] FOREIGN KEY ([LendingId]) REFERENCES [Lendings]([Id])
)