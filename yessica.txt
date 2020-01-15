USE MASTER 
GO
BEGIN 
CREATE DATABASE BibliotecaS
END

BEGIN
CREATE TABLE Editorial (
CodigoEdit int IDENTITY (1,1) PRIMARY KEY,
NomEdit VARCHAR (30) NOT NULL )
END

CREATE TABLE Libros (
CodLibro int IDENTITY (1,1) PRIMARY KEY,
NomLibro VARCHAR (50) NOT NULL,
CodEdit int FOREIGN KEY (CodEdit) REFERENCES Editorial(CodigoEdit) )
ALTER table Libros drop column NomAutor

INSERT INTO Editorial (NomEdit)VALUES ('McGraw-Hill')
INSERT INTO Editorial (NomEdit)VALUES ('Prentice Hall')
INSERT INTO Editorial (NomEdit)VALUES ('Kimpres')
INSERT INTO Editorial (NomEdit)VALUES ('Eni')

SELECT * FROM Editorial 

INSERT INTO Libros (NomLibro,CodEdit) VALUES ('formacion i orientació laboral. essencial', 1)
INSERT INTO Libros (NomLibro,CodEdit) VALUES ('edición especial microsoft access 2000',2)
INSERT INTO Libros (NomLibro,CodEdit) VALUES ('Dionea', 3)
INSERT INTO Libros (NomLibro,CodEdit) VALUES ('Algoritmia-Técnicas fundamentales de programación',4)

SELECT * FROM Libros
alter procedure pa_Com
@nombre varchar (40)
as
begin 
select NomEdit,CodEdit from Editorial,Libros where NomEdit=@nombre and CodEdit=CodigoEdit
end
go

CREATE PROCEDURE pa_Consultar
AS
BEGIN
SELECT * FROM Editorial
END
GO
EXECUTE pa_Consultar


CREATE PROCEDURE pa_MostrarEdit
AS
BEGIN 
SELECT * FROM Editorial
END 
GO

CREATE PROCEDURE pa_MostrarLibro
AS
BEGIN
SELECT * FROM Libros 
END
GO

CREATE PROCEDURE pa_Inicial
@Pincial varchar (30)
AS
BEGIN
SELECT * FROM Libros WHERE NomLibro like @Pincial +'%'
END
GO

CREATE PROCEDURE pa_CNombre
AS
BEGIN
SELECT NomEdit FROM Editorial
END
GO



CREATE PROCEDURE pa_McGrawH
@codigo int
AS
BEGIN
SELECT *FROM Libros WHERE CodEdit=@codigo
END
GO

CREATE PROCEDURE pa_PrenticeH
@codigo int
AS
BEGIN
SELECT *FROM Libros WHERE CodEdit=@codigo
END
GO

CREATE PROCEDURE pa_Kimpres
@codigo int
AS
BEGIN
SELECT *FROM Libros WHERE CodEdit=@codigo
END
GO

CREATE PROCEDURE pa_Eni
@codigo int
AS
BEGIN
SELECT *FROM Libros WHERE CodEdit=@codigo
END
GO



CREATE PROCEDURE pa_Codlasc
AS
BEGIN
SELECT * FROM Libros ORDER BY CodLibro ASC
END
GO

CREATE PROCEDURE pa_NomLasc
AS
BEGIN
SELECT * FROM Libros ORDER BY NomLibro ASC
END
GO



CREATE PROCEDURE pa_CodEditasc
AS
BEGIN
SELECT * FROM Libros ORDER BY CodEdit ASC
END
GO




CREATE PROCEDURE pa_Codldsc
AS
BEGIN
SELECT * FROM Libros ORDER BY CodLibro DESC
END
GO

CREATE PROCEDURE pa_NomLibrodsc
AS
BEGIN
SELECT * FROM Libros ORDER BY NomLibro DESC
END
GO



CREATE PROCEDURE pa_CodEditdsc
AS
BEGIN
SELECT * FROM Libros ORDER BY CodEdit DESC
END
GO