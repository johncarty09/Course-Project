--LibraryDBConnectionString
--Create the DB
CREATE DATABASE LibraryDB; --Crate the database

--Uncomment drop the tables if the already exist to clear any
--old data if it remains
--DROP TABLE [LibraryDB].[dbo].[Courses;
--DROP TABLE [LibraryDB].[dbo].[Instructors];



--Create the Instructors table
CREATE TABLE [LibraryDB].[dbo].[Author]
(
  [AuthorID] INT NOT NULL PRIMARY KEY
  , AuthorFirstName VARCHAR(50) NOT NULL
  , AuthorLastName VARCHAR(50) NOT NULL
  , AboutAuthor VARCHAR(100)
);

CREATE TABLE [LibraryDB].[dbo].[Books]
(
  [ISBN] INT NOT NULL PRIMARY KEY
  , [AuthorID] INT NOT NULL FOREIGN KEY REFERENCES Author(AuthorID)
  , CopywrightYear INT NOT NULL
  , Location VARCHAR(4) NOT NULL
  , CopiesOwned Int NOT NULL
  , CopiesInStock INT NOT NULL
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
  , [ISBN] INT NOT NULL FOREIGN KEY REFERENCES Books(ISBN)
  , [AuthorID] INT NOT NULL FOREIGN KEY REFERENCES Author(AuthorID)
);

--Create the Courses tabble
CREATE TABLE [LibraryDB].[dbo].[Courses]
(
  [CourseID] INT NOT NULL PRIMARY KEY
  , [InstructorID] INT NOT NULL FOREIGN KEY REFERENCES Instructors(InstructorID)
  , CourseTitle VARCHAR(100) NOT NULL
)


--Populate both tables
INSERT INTO [LibraryDB].[dbo].[Instructors](InstructorID, InstructorName)
VALUES (1,'John Carty');
INSERT INTO [LibraryDB].[dbo].[Instructors](InstructorID, InstructorName)
VALUES (2,'Michale Miracle');
INSERT INTO [LibraryDB].[dbo].[Instructors](InstructorID, InstructorName)
VALUES (3,'Jane Doe');

INSERT INTO [LibraryDB].[dbo].[Courses] (CourseID, InstructorID, CourseTitle)
VALUES (100,1,'Intro to Computers');
INSERT INTO [LibraryDB].[dbo].[Courses] (CourseID, InstructorID, CourseTitle)
VALUES (200,2,'Agile Programming');
INSERT INTO [LibraryDB].[dbo].[Courses] (CourseID, InstructorID, CourseTitle)
VALUES (300,2,'Advanced Agile Programming');
INSERT INTO [LibraryDB].[dbo].[Courses] (CourseID, InstructorID, CourseTitle)
VALUES (400,3,'Intro to Databases');
INSERT INTO [LibraryDB].[dbo].[Courses] (CourseID, InstructorID, CourseTitle)
VALUES (500,3,'Advanced Database');
INSERT INTO [LibraryDB].[dbo].[Courses] (CourseID, InstructorID, CourseTitle)
VALUES (600,3,'Web Programming');

--*/
