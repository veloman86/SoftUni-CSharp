CREATE TABLE Models (
ModelID INT NOT NULL,
[Name] NVARCHAR(30) NOT NULL,
ManufacturerID INT NOT NULL)

CREATE TABLE Manufacturers (
ManufacturerID INT PRIMARY KEY IDENTITY NOT NULL,
[Name] NVARCHAR(30) NOT NULL,
EstablishedOn DATE NOT NULL)

ALTER TABLE Models
ADD CONSTRAINT PK_Models
PRIMARY KEY (ModelID)

ALTER TABLE Models
ADD CONSTRAINT FK_Models_Manufacturers
FOREIGN KEY (ManufacturerID)
REFERENCES Manufacturers (ManufacturerID)