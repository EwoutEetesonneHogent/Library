-- Delete BookLendings linked to the Lender's Lendings
DELETE FROM [Library].[dbo].[BookLendings]
WHERE [LendingId] IN (
    SELECT [Id] FROM [Library].[dbo].[Lendings]
    WHERE [LenderId] = @LenderId
);

-- Delete the Lendings of the Lender
DELETE FROM [Library].[dbo].[Lendings]
WHERE [LenderId] = @LenderId;

-- Delete the Lender itself
DELETE FROM [Library].[dbo].[Lenders]
WHERE [Id] = @LenderId;