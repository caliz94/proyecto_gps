USE [TechSolutions]
GO

/****** Object:  StoredProcedure [dbo].[login]    Script Date: 22/7/2021 16:59:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[login]
(@usuario varchar(50),@contraseña varchar(50))
as
select usuario,contraseña from usuarios where usuario = @usuario and contraseña = @contraseña
GO

