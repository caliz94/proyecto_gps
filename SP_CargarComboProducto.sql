USE [TechSolutions]
GO

/****** Object:  StoredProcedure [dbo].[SpCargarComboProducto]    Script Date: 23/7/2021 00:35:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpCargarComboProducto]
AS
SELECT NombreProducto FROM Producto
GO

