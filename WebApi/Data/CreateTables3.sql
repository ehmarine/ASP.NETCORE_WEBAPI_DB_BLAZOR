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

INSERT INTO Categories 
VALUES ('Records');
INSERT INTO Categories 
VALUES ('Hardware');
INSERT INTO Categories 
VALUES ('Merchandise');

INSERT INTO Products
VALUES (
1,
'DJ KHALED - Suffering from Success',
'Is DJ Khaled really suffering from success?',
'From his extensive work as a DJ, BLAVBLALBALBALAL',
'https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.tiBhpht_pDv9fSncRaXcqgHaEK%26pid%3DApi&f=1',
1337,
1
);

INSERT INTO Products
VALUES (
2,
'Roland Cloud TR-808',
'Europas största återförsäljare av Virtuella instrument och sampler',
'Autentisk programkopia av den legendariska Roland TR-808 trumdator från 1980
11 Generering av röstljud med enkla redigeringsalternativ
Step sequencer med 11 instrumentdelar
16 steg per mått och 8 variationer per mönster
Utökat grafiskt användargränssnitt erbjuder ett separat spår för varje',
'https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.0bk0lBlg9PPQtK64Dt5muAHaE7%26pid%3DApi&f=1',
2000,
1
);

INSERT INTO Products
VALUES (
3,
'Sjuk jävla T-shirt',
'fyfan vad sjuk',
'Passform/Topp
Vardaglig
Produktämne
Humor, Uttryck
Skötselråd
Maskintvätt',
'https://www.emp-shop.se/dw/image/v2/BBQV_PRD/on/demandware.static/-/Sites-master-emp/default/dw75708c79/images/4/5/1/5/451590a.jpg?sw=1000&sh=800&sm=fit&sfrm=png',
549,
0
);

INSERT INTO Products
VALUES (
1,
'Banankontakt',
'trasan och bananen är en av dom sjukaste artisterna, groovy och häftigt på samma gång!',
'Barnprogram med Trazan Apansson (Lasse Åberg) och Banarne (Klasse Möllberg). Dessa 8 delar, sända 1999, är redigerade avsnitt av de som gick i början av ...',
'https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.WGYkXERH21MXwgTIiVPy2AHaHa%26pid%3DApi&f=1',
549,
0
);

INSERT INTO Products
VALUES (
1,
'Salladskrydda',
'väldigt trevlig vitaminrik krydda',
'Salt
Vitamin B1 (Tiamin)
Vitamin B2 (Riboflavin)
Vitamin B3 (Niacin)
VitaminB5 (Pantotenstyra",
"Innehåll: 
Salt
Vitamin B1 (Tiamin)
Vitamin B2 (Riboflavin)
Vitamin B3 (Niacin)
VitaminB5 (Pantotenstyra)
Vitamin B6 (Pyridoxin)
Vitamin B7 (Biotin)
Vitamin B9 (Folsyra)
Vitamin B12 (kobalamin)
Vitamin D3 (Kolekalciferol)
Vitamin C (Askorbinsyra)
Kolin
Inositol
PABA',
'https://finestseasoning.se/wp-content/uploads/2021/08/ljus-salt-683x1024.jpg',
14,
1
);

INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
	'Robert',
	'Dunder',
	'dunder@dunder.com',
	'Bytmig123'
)