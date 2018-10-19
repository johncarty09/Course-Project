--INSERT INTO LibraryDB.dbo.Borrower (BorrowerID, BorrowerType, BorrowerFirstName, BorrowerLastName, InventoryOut) VALUES (12345, 'F', 'John', 'Carty', 0)
--select concat(b.BorrowerFirstName, ' ', b.BorrowerLastName) as 'Name', b.InventoryOut from LibraryDB.dbo.Borrower b
select max(b.BorrowerID) from LibraryDB.dbo.Borrower b