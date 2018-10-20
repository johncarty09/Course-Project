--INSERT INTO LibraryDB.dbo.Borrower (BorrowerID, BorrowerType, BorrowerFirstName, BorrowerLastName, InventoryOut) VALUES (12345, 'F', 'John', 'Carty', 0)
--select concat(b.BorrowerFirstName, ' ', b.BorrowerLastName) as 'Name', b.InventoryOut from LibraryDB.dbo.Borrower b
--select max(b.BorrowerID) from LibraryDB.dbo.Borrower b
--select AuthorID from LibraryDB.dbo.Author where AuthorFirstName = 'George RR' and AuthorLastName = 'Martin'
--INSERT INTO LibraryDB.dbo.Author (AuthorID, AuthorFirstName, AuthorLastName, AboutAuthor) VALUES (45678, 'JK', 'Rowling', 'is a British novelist best known for writing the Harry Potter fantasy series.')
--select * from LibraryDB.dbo.Author

--DROP TABLE LibraryDB.dbo.[Transaction];
--DROP TABLE LibraryDB.dbo.Books;
--ALTER TABLE LibraryDB.dbo.[Transaction] ALTER COLUMN ISBN bigint
--ALTER TABLE LibraryDB.dbo.Books ADD Title VARCHAR(50)

select * from LibraryDB.dbo.Books
