--LibraryDBConnectionString
--Create the DB
CREATE DATABASE LibraryDB; --Crate the database

--Uncomment drop the tables if the already exist to clear any
--old data if it remains
--DROP TABLE [LibraryDB].[dbo].[Courses;
--DROP TABLE [LibraryDB].[dbo].[Instructors];



--Create the [Author] table
CREATE TABLE [LibraryDB].[dbo].[Author]
(
  [AuthorID] INT NOT NULL PRIMARY KEY
  , AuthorFirstName VARCHAR(50) NOT NULL
  , AuthorLastName VARCHAR(50) NOT NULL
  , AboutAuthor VARCHAR(100)
);


CREATE TABLE [LibraryDB].[dbo].[Books]
(
  [ISBN] BIGINT NOT NULL PRIMARY KEY
  , [AuthorID] INT NOT NULL FOREIGN KEY REFERENCES Author(AuthorID)
  , CopywrightYear INT NOT NULL
  , Location VARCHAR(4) NOT NULL
  , CopiesOwned Int NOT NULL
  , CopiesInStock INT NOT NULL
  , Title VARCHAR(100) NOT NULL
);


CREATE TABLE [LibraryDB].[dbo].[Borrower]
(
  [BorrowerID] INT NOT NULL PRIMARY KEY
  , BorrowerType VARCHAR(1) NOT NULL
  , BorrowerFirstName VARCHAR(50) NOT NULL
  , BorrowerLastName VARCHAR(50) NOT NULL
  , CopiesOwned Int NOT NULL
  , CopiesInStock INT NOT NULL
);


CREATE TABLE [LibraryDB].[dbo].[Transaction]
(
  [TransactionID] INT NOT NULL PRIMARY KEY
  , [ISBN] BIGINT NOT NULL FOREIGN KEY REFERENCES Books(ISBN)
  , [BorrowerID] INT NOT NULL FOREIGN KEY REFERENCES Borrower(BorrowerID)
  , [CheckOutDate] DATE NOT NULL
  , [ReturnDate] DATE
);

INSERT INTO [LibraryDB].[dbo].[Transaction](TransactionID, ISBN, BorrowerID, CheckOutDate)
VALUES (1,1234567894567,12345, GETDATE());



/*
--Populate both tables
INSERT INTO [LibraryDB].[dbo].[Instructors](InstructorID, InstructorName)
VALUES (1,'John Carty');
INSERT INTO [LibraryDB].[dbo].[Instructors](InstructorID, InstructorName)
VALUES (2,'Michale Miracle');
INSERT INTO [LibraryDB].[dbo].[Instructors](InstructorID, InstructorName)
VALUES (3,'Jane Doe');


--*/
