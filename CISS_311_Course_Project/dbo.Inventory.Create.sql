DROP TABLE dbo.Inventory
DROP TABLE dbo.Authors;
DROP TABLE dbo.Borrowers;
DROP TABLE dbo.Transactions;



CREATE TABLE [dbo].[Inventory]
(
	[ISBN] INT IS NOT NULL PRIMARY KEY
	, [AuthorID] INT IS NOT NULL FOREIGN KEY REFERENCES Authors(AuthorID)
	, [Title] VARCHAR(25)
	, [CopyrightYear] INT
	, [Location] VARCHAR(5)
	, [Copies] INT
);

CREATE TABLE [dbo].[Authors]
(
	[AuthorID] INT NOT NULL PRIMARY KEY
	, [FirstName] VARCHAR(25) IS NOT NULL 
	, [LastName] VARCHAR(25) IS NOT NULL 
	, [FullName] VARCHAR(50) IS NOT NULL 
	, [AboutTheAuthor] VARCHAR(75) IS NOT NULL 
);

CREATE TABLE [dbo].[Borrowers]
(
	[BorrowerID] INT NOT NULL PRIMARY KEY
	, [FirstName] VARCHAR(25) IS NOT NULL 
	, [LastName] VARCHAR(25) IS NOT NULL 
	, [FullName] VARCHAR(50) IS NOT NULL
	, [InventoryHeld] INT IS NOT NULL
);

CREATE TABLE [dbo].[Transactions]
(
	[TransactionID] INT NOT NULL PRIMARY KEY
	, [BorrowID] INT IS NOT NULL FOREIGN KEY REFERENCES Borrowers(BorrowerID)
	, [AuthorID] VARCHAR(25) IS NOT NULL FOREIGN KEY REFERENCES Authors(AuthorID)
	, [CheckoutDate] DATETIME IS NOT NULL
	, [DueDate] DATETIME IS NOT NULL
	, [ReturnedDate] DATETIME
);