ALTER TABLE [Library].[dbo].[Lendings]
    ADD [LenderId] INT NOT NULL
        CONSTRAINT [FK_Lendings_Lenders] FOREIGN KEY REFERENCES [Lenders]([Id]);