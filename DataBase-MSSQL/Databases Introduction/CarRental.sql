CREATE DATABASE CarRental

CREATE TABLE Categories
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	category VARCHAR(50)  NOT NULL,
	DailyRate INT,
	WeeklyRate INT,
	MonthlyRate INT,
	WeekendRate INT
);

CREATE TABLE Cars
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	PlateNumber VARCHAR(50) not null,
	Manufacturer VARCHAR(50),
    Model VARCHAR(50),
	CarYear INT,
	CategoryId INT,
	Doors INT,
	Picture IMAGE,
	Condition VARCHAR(50),
	Available CHAR(1)
);

CREATE TABLE Employees
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(50) not null,
	LastName VARCHAR(50) not null,
	Title varchar(50),
	Notes text
);

CREATE TABLE Customers
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	DriverLicenceNumber INT not null,
	FullName VARCHAR(50),
	[Address] VARCHAR(50),
	City VARCHAR(50),
	ZIPCode INT,
	Notes text
);
 

CREATE TABLE RentalOrders 
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	EmployeeId INT not null,
	CustomerId INT,
	CarId INT not null, 
	TankLevel INT,
	KilometrageStart INT,
	KilometrageEnd INT,
	TotalKilometrage INT,
	[StartDate] date,
	[EndDate] date,
	TotalDays INT,
	RateApplied INT,
	TaxRate INT,
	OrderStatus varchar(50),
	Notes text
);

insert into Cars(PlateNumber)
values ('123'),('1234'),('12345');
insert into Categories(category)
values ('Classic'),('Limuzine'),('Sport');
insert into Customers(DriverLicenceNumber)
values ('2232'),('232323'),('111');
insert into Employees(FirstName,LastName)
values ('Ivan', 'Ivanov'),('Ivan1', 'Ivanov1'), ('Ivan2', 'Ivanov2');
insert into RentalOrders (EmployeeId,CarId)
values (1, 1),(1, 2), (2, 3);