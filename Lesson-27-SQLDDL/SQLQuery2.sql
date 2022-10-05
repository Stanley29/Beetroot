CREATE TABLE Phone_Book
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	SecondName NVARCHAR(50) NOT NULL,
	Phone CHAR(10) UNIQUE
);

CREATE TABLE School_Schedule
(
	Id INT PRIMARY KEY IDENTITY,
	Teacher NVARCHAR(50) NOT NULL,
	Lesson NVARCHAR(50) NOT NULL,
	LessonTime TIME NOT NULL
);

CREATE TABLE Login_History
(
	Id INT PRIMARY KEY IDENTITY,
	LastLoginTime DATETIME,
	UserName NVARCHAR(50) NOT NULL
);

CREATE TABLE Bank_Account
(
	Id INT PRIMARY KEY IDENTITY,
	NameOfHolder NVARCHAR(50) NOT NULL,
	HolderNumber INT UNIQUE NOT NULL
);

CREATE TABLE Transaction_Data
(
	Id INT PRIMARY KEY IDENTITY,
	UserId INT NOT NULL,
	TransactionDate DATETIME NOT NULL,
	Amount FLOAT,
		CONSTRAINT FK_BankAccount_UserId FOREIGN KEY (UserId) REFERENCES Bank_Account (Id)
);