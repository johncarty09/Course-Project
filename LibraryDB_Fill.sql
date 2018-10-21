INSERT INTO [LibraryDB].[dbo].[Transaction](TransactionID, ISBN, BorrowerID, CheckOutDate)
VALUES (1,1234567894567,12345, GETDATE());
INSERT INTO [LibraryDB].[dbo].[Transaction](TransactionID, ISBN, BorrowerID, CheckOutDate)
VALUES (1,1234567894567,12345, '2018-01-01');
INSERT INTO [LibraryDB].[dbo].[Transaction](TransactionID, ISBN, BorrowerID, CheckOutDate)
VALUES (1,1234567894567,12345, '2018-10-01')


INSERT INTO LibraryDB.[dbo].Author(AuthorID, AuthorFirstName, AuthorLastName, AboutAuthor)
VALUES (101,'JK', 'Rowling', 'Is a British novelist best known for writing the Harry Potter fantasy series.');
INSERT INTO LibraryDB.[dbo].Author(AuthorID, AuthorFirstName, AuthorLastName, AboutAuthor)
VALUES (102,'George RR', 'Martin', 'Is an American novelist best know for writing the A Song of Ice and Fire (Game of Thrones) series.');
INSERT INTO LibraryDB.[dbo].Author(AuthorID, AuthorFirstName, AuthorLastName, AboutAuthor)
VALUES (103,'J. R. R.', 'Tolkien', 'Was an English writer who is best known for writing The Hobbit, and The Lord of the Rings.');
INSERT INTO LibraryDB.[dbo].Author(AuthorID, AuthorFirstName, AuthorLastName, AboutAuthor)
VALUES (104,'Diana', 'Gabaldon', 'Is an American author, known for the Outlander series of novels.');



