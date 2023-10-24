CREATE DATABASE MyLibrary;
USE MyLibrary;

CREATE TABLE Categories
(
    Id INT Identity(1,1) PRIMARY KEY,
    Name VARCHAR(200),
    Details VARCHAR(1000)
); 

CREATE TABLE PublishingHouses
(
    Id INT Identity(1,1) PRIMARY KEY,
    Name VARCHAR(200),
    Details VARCHAR(1000)
); 

CREATE TABLE BooksDetails
(
    Id INT Identity(1,1) PRIMARY KEY,
    Details VARCHAR(4000),
    Picture IMAGE
); 

CREATE TABLE Books
(
    Id INT Identity(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Author VARCHAR(100),
    PublishingYear INT,
    Stock INT,
    CategoryId INT REFERENCES Categories(Id),
    PublishingHouseId INT REFERENCES PublishingHouses(Id),
    BookDetailId INT REFERENCES BooksDetails(Id)
); 

CREATE TABLE Statuses
(
    Id INT Identity(1,1) PRIMARY KEY,
    Name VARCHAR(20),
    NoOfDays INT 
);

CREATE TABLE Users
(
    Id INT Identity(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Phone INT,
    Email VARCHAR(20)
);

CREATE TABLE Orders
(
    Id INT Identity(1,1) PRIMARY KEY,
    StartDate DATE,
    ReturnDate DATE,
    Details VARCHAR(100),
    UserId INT REFERENCES Users(Id),
    BookId INT REFERENCES Books(Id),
    StatusId INT REFERENCES Statuses(Id)
);

