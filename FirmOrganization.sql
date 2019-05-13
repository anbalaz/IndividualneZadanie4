CREATE DATABASE FirmOrganization;
GO
 
USE FirmOrganization;
GO

CREATE TABLE [Structure]
(
	[ID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Code] [int] UNIQUE NOT NULL,
	[OrganizationLevel] INT NOT NULL,
	[EmployeeID] INT,
	[StructureID] INT 
	);
 GO
 
 CREATE TABLE[Employee]
 (
	[ID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[Title] [nvarchar](30) NULL,
	[PhoneNumber] [nvarchar](24) NULL,
	[EmailAddress] [nvarchar](100) NULL,
	[StructureID] [int] FOREIGN KEY REFERENCES [Structure] (ID) NOT NULL,
 );


ALTER TABLE [Structure]
ADD FOREIGN KEY ([EmployeeID])
REFERENCES [Employee](ID);

ALTER TABLE [Structure]
ADD FOREIGN KEY ([StructureID])
REFERENCES [Structure](ID);

INSERT INTO Structure (Name,Code,OrganizationLevel) 
VALUES('ZVL',1,1),
	('Farmet',2,1),
	('Lambert',3,1);

INSERT INTO Structure (Name,Code,OrganizationLevel,StructureID) 
VALUES('ZVLDivision',4,2,1),
	('ZVLProjekt',5,3,2),
	('ZVLDepartment',6,4,3),
	('ZVLProjekt',7,2,2),
	('ZVLProjekt',8,2,2),
	('ZVLDivision',9,3,7),
	('ZVLProjekt',10,3,7),
	('ZVLDepartment',11,3,8),
	('ZVLDepartment',12,4,9),
	('ZVLDepartment',13,4,10);

INSERT INTO Employee(LastName,FirstName,Title,PhoneNumber,EmailAddress,StructureID) 
VALUES('Marincin','Marek','Ing.','094568477','smelinar@gmail.com',12),
		('Bartos','Miroslav','Mgr.','0364646456','hafanana@gmail.com',12),
		('Marincin','Marek','Bc.','78465331','eeeeeoooo@gmail.com',12),
		('Bodnar','Samuel','Ing.','09345646','lalalla@gmail.com',12),
		('Simon','Dezider','Bc.','3540654','smejd@gmail.com',13),
		('Simundsen','Ladislav','Ing.','3540654','hajaa@gmail.com',13),
		('Edmundson','Romualdo','Mgr.','3540654','strelec@gmail.com',13),
		('Bires','Juraj','Bc.','95604646','samozyrejme@gmail.com',13);

SELECT * FROM Structure WHERE OrganizationLevel=2 AND StructureID=1;
SELECT * FROM Structure WHERE OrganizationLevel=1 AND StructureID=null
SELECT * FROM Employee WHERE StructureID =12


