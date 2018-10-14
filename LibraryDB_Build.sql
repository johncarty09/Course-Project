--Create the DB
CREATE DATABASE LibraryDB;
;



--Create the Author table
CREATE TABLE [LibraryDB].[dbo].[Author]
(
  [AuthorID] INT NOT NULL PRIMARY KEY
  , AuthorFirstName VARCHAR(50) NOT NULL
  , AuthorLastName VARCHAR(50) NOT NULL
  , AboutAuthor VARCHAR(100)
);

--Create the Books table
CREATE TABLE [LibraryDB].[dbo].[Books]
(
  [ISBN] INT NOT NULL PRIMARY KEY
  , [AuthorID] INT NOT NULL FOREIGN KEY REFERENCES Author(AuthorID)
  , CopywrightYear INT NOT NULL
  , Location VARCHAR(4) NOT NULL
  , CopiesOwned Int NOT NULL
  , CopiesInStock INT NOT NULL
);

--Create the Borrower table
CREATE TABLE [LibraryDB].[dbo].[Borrower]
(
  [BorrowerID] INT NOT NULL PRIMARY KEY
  , BorrowerType VARCHAR(1) NOT NULL
  , BorrowerFirstName VARCHAR(50) NOT NULL
  , BorrowerLastName VARCHAR(50) NOT NULL
  , InventoryOut INT NOT NULL
);

--Create the Transaction table
CREATE TABLE [LibraryDB].[dbo].[Transaction]
(
  [TransactionID] INT NOT NULL PRIMARY KEY
  , [ISBN] INT NOT NULL FOREIGN KEY REFERENCES Books(ISBN)
  , [BorrowerID] INT NOT NULL FOREIGN KEY REFERENCES Borrower(BorrowerID)
  , CheckoutDate DATE NOT NULL
  , DateDue DATE NOT NULL
  , DateReturned DATE
);
