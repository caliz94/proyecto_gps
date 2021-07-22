USE [TechSolutions]
GO

/****** Object:  StoredProcedure [dbo].[SpBuscarProducto]    Script Date: 22/7/2021 17:00:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpBuscarProducto]
(
@IdProducto INT
)
AS
BEGIN
	SELECT NombreProducto,Cantidad,PrecioUnitario,Marca FROM Producto WHERE IdProducto = @IdProducto
END
GO

