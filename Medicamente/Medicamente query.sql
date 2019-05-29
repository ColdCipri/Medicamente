USE Medicamente_DB
GO


CREATE TABLE Medicamente(
Id INT PRIMARY KEY IDENTITY, 
Nume VARCHAR(50), 
Buc VARCHAR(50),  
Tip VARCHAR(50),
DataExpirarii DATE,
Imagine varbinary(max),
SubstantaBaza VARCHAR(50),
SubstBazaCantitate INT,
Descriere VARCHAR(100))








DROP TABLE Medicamente

SELECT * FROM Medicamente

INSERT INTO Medicamente(Nume, Buc, Tip, DataExpirarii, Imagine) VALUES ('Coldrex MaxGrip Lemon', 10, 'Pastila', '05-01-2021', (
	SELECT BulkColumn 
	FROM Openrowset( Bulk 'F:\Photos\Medicamente\coldrex.jpg', Single_Blob) as img )
	 )

INSERT INTO Medicamente(Nume, Buc, Tip, DataExpirarii) VALUES ('ABC',1,'Sirop','01-01-2020')
