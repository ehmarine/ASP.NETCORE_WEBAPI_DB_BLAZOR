DROP TABLE OrderLines
DROP TABLE Orders
DROP TABLE Users
DROP TABLE Adresses
DROP TABLE Products
DROP TABLE Categories
GO
CREATE Table Categories (
Id int not null identity primary key,
CategoryName nvarchar(33) not null
)
GO
CREATE TABLE Products (
Id int not null identity primary key,
CategoryId int not null references Categories(Id),
ProductName nvarchar(100) not null,
ShortDescription nvarchar(300) not null,
LongDescription nvarchar(max),
ImgUrl nvarchar(max),
Price money default 0,
InStock bit default 1 not null

)

CREATE TABLE Adresses (
Id int not null identity primary key,
AdressLine nvarchar(100),
ZipCode nvarchar(5),
City nvarchar(100)
)
GO

CREATE TABLE Users (
Id int not null identity primary key,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Email nvarchar(100) not null,
Password nvarchar(max) not null,
AdressId int references Adresses(Id)
)

GO

CREATE TABLE Orders (
Id int not null identity primary key,
Status bit not null default 0,
UserId int not null references Users(Id)
)
GO
CREATE TABLE OrderLines(
ProductId int not null primary key references Products(Id),
Quantity int not null,
OrderId int not null references Orders(Id)
)