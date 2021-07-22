USE [TechSolutions]
GO

/****** Object:  StoredProcedure [dbo].[SpInsertarProductos]    Script Date: 22/7/2021 17:00:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpInsertarProductos]
(
@NombreProducto VARCHAR(100),
@Cantidad INT,
@PrecioUnitario DECIMAL(18,2),
@Marca VARCHAR(50)
)
AS
BEGIN 
	INSERT INTO Producto (NombreProducto,Cantidad,PrecioUnitario,Marca) VALUES (@NombreProducto,
 @Cantidad, @PrecioUnitario, @Marca);
END
GO

