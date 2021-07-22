USE master
GO

CREATE DATABASE TechSolutions
GO

USE TechSolutions
GO

CREATE TABLE Venta
(
	IdVenta INT IDENTITY(1,1) NOT NULL,
	IdProducto INT,
	Cantidad INT,
	Total MONEY,
	Fecha DATETIME
)
GO

CREATE TABLE Producto
(
IdProducto INT IDENTITY(1,1) NOT NULL,
NombreProducto VARCHAR(100),
Cantidad INT,
PrecioUnitario DECIMAL(18,2),
Marca VARCHAR(50)
)
GO
--TRUNCATE TABLE Venta
--TRUNCATE TABLE Producto
--SELECT * FROM Venta
--SELECT * FROM Producto

--INSERT INTO TechSolutions..Producto VALUES ('CONECTORES RJ-45 DE 8 HILOS', 1000,0.14, 'GENERICO')
--INSERT INTO TechSolutions..Producto VALUES ('CABLE UTP/CAT 6A 10GB 1000TF(305m) BLUE', 500,0.08, 'GENERICO')
--INSERT INTO TechSolutions..Venta VALUES (1,2,0.28,GETDATE())
--INSERT INTO TechSolutions..Venta VALUES (2,2,0.16,GETDATE())



--DROP DATABASE TechSolutions