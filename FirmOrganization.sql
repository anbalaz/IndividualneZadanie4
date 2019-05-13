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
	('ZVLProjekt',8,2,2);

SELECT * FROM Structure WHERE OrganizationLevel=2 AND StructureID=1;
SELECT * FROM Structure WHERE OrganizationLevel=1 AND StructureID=null

INSERT INTO Structure (Name,Code,OrganizationLevel,StructureID) 
VALUES('ZVLDivision',9,3,7),
	('ZVLProjekt',10,3,7),
	('ZVLDepartment',11,3,8);