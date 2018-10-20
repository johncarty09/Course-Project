--INSERT INTO LibraryDB.dbo.Borrower (BorrowerID, BorrowerType, BorrowerFirstName, BorrowerLastName, InventoryOut) VALUES (12345, 'F', 'John', 'Carty', 0)
--select concat(b.BorrowerFirstName, ' ', b.BorrowerLastName) as 'Name', b.InventoryOut from LibraryDB.dbo.Borrower b
--select max(b.BorrowerID) from LibraryDB.dbo.Borrower b
--select AuthorID from LibraryDB.dbo.Author where AuthorFirstName = 'George RR' and AuthorLastName = 'Martin'
--INSERT INTO LibraryDB.dbo.Author (AuthorID, AuthorFirstName, AuthorLastName, AboutAuthor) VALUES (45678, 'JK', 'Rowling', 'is a British novelist best known for writing the Harry Potter fantasy series.')
--select * from LibraryDB.dbo.Author

--DROP TABLE LibraryDB.dbo.[Transaction];
/*
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


select t.TransactionID, t.CheckOutDate , b.BorrowerFirstName, b.BorrowerLastName, k.Title
from LibraryDB.dbo.[Transaction] t 
join LibraryDB.dbo.Borrower b on t.BorrowerID = b.BorrowerID
join LibraryDB.dbo.Books k on k.ISBN = t.ISBN


--DROP TABLE LibraryDB.dbo.Books;
--ALTER TABLE LibraryDB.dbo.[Transaction] ALTER COLUMN ISBN bigint
--ALTER TABLE LibraryDB.dbo.Books ADD Title VARCHAR(50)

select b.ISBN 
from LibraryDB.dbo.Books b 
join LibraryDB.dbo.Author a on b.AuthorID = a.AuthorID
where a.AuthorFirstName = 'JK'
and   a.AuthorLastName = 'Rowling'
and   b.Title = 'Harry Potter: Sorcerer''s Stone'


select b.BorrowerID from LibraryDB.dbo.Borrower b 
where b.BorrowerFirstName =  'John' and b.BorrowerLastName = 'Carty' 
and b.BorrowerType = 'F' 

*/

select * from LibraryDB.dbo.Books
