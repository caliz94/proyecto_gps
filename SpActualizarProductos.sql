USE [TechSolutions]
GO

/****** Object:  StoredProcedure [dbo].[SpActualizarProductos]    Script Date: 22/7/2021 17:00:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpActualizarProductos]
(
@IdProducto INT,
@NombreProducto VARCHAR(100),
@Cantidad INT,
@PrecioUnitario DECIMAL(18,2),
@Marca VARCHAR(50)
)
AS
BEGIN 
	UPDATE Producto 
	SET NombreProducto = @NombreProducto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Marca = @Marca
	WHERE IdProducto = @IdProducto;
END
GO

