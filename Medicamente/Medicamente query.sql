USE Medicamente_DB
GO


CREATE TABLE Medicamente(
Id INT PRIMARY KEY IDENTITY, 
Nume VARCHAR(50), 
Buc VARCHAR(50),  
Tip VARCHAR(50),
DataExpirarii DATE NOT NULL,
Imagine varbinary(max))

DROP TABLE Medicamente

SELECT * FROM Medicamente

INSERT INTO Medicamente(Nume, Buc, Tip, DataExpirarii, Imagine) VALUES ('Coldrex MaxGrip Lemon', 10, 'Pastila', '05-01-2021', (
	SELECT BulkColumn 
	FROM Openrowset( Bulk 'F:\Photos\Medicamente\coldrex.jpg', Single_Blob) as img )
	 )
