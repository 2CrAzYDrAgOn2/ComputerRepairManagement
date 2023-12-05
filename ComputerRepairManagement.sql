CREATE DATABASE ComputerRepairManagement;
USE ComputerRepairManagement;

CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE Technicians (
    TechnicianID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100)
);

CREATE TABLE RepairOrders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT,
    TechnicianID INT,
    OrderDate DATE,
    Description NVARCHAR(MAX),
    Status NVARCHAR(50),
	FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
	FOREIGN KEY (TechnicianID) REFERENCES Technicians(TechnicianID)
);

CREATE TABLE SoftwareInstallation (
    InstallationID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT,
    TechnicianID INT,
    InstallationDate DATE,
    SoftwareName NVARCHAR(100),
    LicenseKey NVARCHAR(50),
	FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
	FOREIGN KEY (TechnicianID) REFERENCES Technicians(TechnicianID)
);

CREATE TABLE Registration (
	UserID INT PRIMARY KEY IDENTITY(1,1),
	UserLogin VARCHAR(50),
	UserPassword VARCHAR(50)
);

INSERT INTO Clients (FirstName, LastName, PhoneNumber, Email)
VALUES
    ('Иван', 'Иванов', '123-456-7890', 'ivan@example.com'),
    ('Мария', 'Петрова', '987-654-3210', 'maria@example.com');

INSERT INTO Technicians (FirstName, LastName, PhoneNumber, Email)
VALUES
    ('Алексей', 'Смирнов', '555-123-4567', 'alex@example.com'),
    ('Елена', 'Козлова', '555-987-6543', 'elena@example.com');

INSERT INTO RepairOrders (ClientID, TechnicianID, OrderDate, Description, Status)
VALUES
    (1, 1, '2023-01-15', 'Проблема с жестким диском', 'В ожидании'),
    (2, 2, '2023-02-01', 'Проблема с операционной системой', 'В обработке');

INSERT INTO SoftwareInstallation (ClientID, TechnicianID, InstallationDate, SoftwareName, LicenseKey)
VALUES
    (1, 1, '2023-03-10', 'Microsoft Office', 'ABCDE-12345-FGHIJ'),
    (2, 2, '2023-03-20', 'Adobe Photoshop', 'FGHIJ-67890-KLMNO');

INSERT INTO Registration (UserLogin, UserPassword)
VALUES
	('admin', 'admin');

SELECT * FROM Clients;
SELECT * FROM Technicians;
SELECT * FROM RepairOrders;
SELECT * FROM SoftwareInstallation;
SELECT * FROM Registration;

DROP DATABASE ComputerRepairManagement;