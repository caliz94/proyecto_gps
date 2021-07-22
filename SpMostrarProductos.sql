USE [TechSolutions]
GO

/****** Object:  StoredProcedure [dbo].[SpMostrarProductos]    Script Date: 22/7/2021 17:00:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpMostrarProductos]
AS 
SELECT * FROM Producto
GO

