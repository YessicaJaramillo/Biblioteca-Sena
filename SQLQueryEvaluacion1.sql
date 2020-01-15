USE MASTER
GO

BEGIN 
CREATE DATABASE Biblioteca
END

BEGIN 
CREATE TABLE Editorial (
codEdi int IDENTITY (1,1) PRIMARY KEY, 
nomEdi varchar (40)not null)
END


CREATE TABLE Libro (
codLib int IDENTITY (1,1) PRIMARY KEY,
nomLib varchar (40)not null,
nomAutor varchar (40)not null,
nomEditorial varchar (40)not null,
codEdi int foreign key (codEdi) references Editorial (codEdi))

INSERT INTO Editorial (nomEdi) values ('McGraw-Hill')
INSERT INTO Editorial (nomEdi) values ('Prentice Hall')
INSERT INTO Editorial (nomEdi) values ('Kimpres')

select*from Editorial


INSERT INTO Libro (nomLib,nomAutor,nomEditorial,codEdi) values ('Los juegos','Juan','McGraw-Hill',1)
INSERT INTO Libro (nomLib,nomAutor,nomEditorial,codEdi) values ('Atena','Catalina','McGraw-Hill',1)
INSERT INTO Libro (nomLib,nomAutor,nomEditorial,codEdi) values ('Niño','Angie','Prentice Hall',2)
INSERT INTO Libro (nomLib,nomAutor,nomEditorial,codEdi) values ('Hp','Anderson','Prentice Hall',2)
INSERT INTO Libro (nomLib,nomAutor,nomEditorial,codEdi) values ('Sofia','Felipe','Kimpres',3)
INSERT INTO Libro (nomLib,nomAutor,nomEditorial,codEdi) values ('Lou','Carlos','Kimpres',3)

select*from Libro
DELETE Libro F

CREATE PROCEDURE pa_Inicial
@nombre varchar (40)
AS
BEGIN
SELECT*FROM Libro where nomLib like @nombre+'%'
END
GO


CREATE PROCEDURE pa_Mlibro
AS
BEGIN
SELECT*FROM Libro
END
GO
exec pa_Mlibro
CREATE PROCEDURE pa_Meditorial
AS
BEGIN
SELECT*FROM Editorial
END
GO
exec pa_Meditorial	



create procedure pa_Nombres
AS
BEGIN 
SELECT nomEdi from Editorial
end
go

create procedure pa_McGraw
@codigo int
as
begin
select *from Libro where codEdi=@codigo
end
go

create procedure pa_Prentice
@codigo int
as
begin
select *from Libro where codEdi=@codigo
end
go

create procedure pa_Kimpres
@codigo int
as
begin
select *from Libro where codEdi=@codigo
end
go