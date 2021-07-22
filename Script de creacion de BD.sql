USE [master]
GO
/****** Object:  Database [TechSolutions]    Script Date: 22/7/2021 16:52:21 ******/
CREATE DATABASE [TechSolutions]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechSolutions', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TechSolutions.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechSolutions_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TechSolutions_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TechSolutions] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechSolutions].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechSolutions] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechSolutions] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechSolutions] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechSolutions] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechSolutions] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechSolutions] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechSolutions] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechSolutions] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechSolutions] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechSolutions] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechSolutions] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechSolutions] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechSolutions] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechSolutions] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechSolutions] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TechSolutions] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechSolutions] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechSolutions] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechSolutions] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechSolutions] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechSolutions] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechSolutions] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechSolutions] SET RECOVERY FULL 
GO
ALTER DATABASE [TechSolutions] SET  MULTI_USER 
GO
ALTER DATABASE [TechSolutions] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechSolutions] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechSolutions] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechSolutions] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TechSolutions', N'ON'
GO
USE [TechSolutions]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[CodProducto] [varchar](10) NULL,
	[NombreProducto] [varchar](100) NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [decimal](18, 2) NULL,
	[Marca] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[Total] [money] NULL,
	[Fecha] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (1, NULL, N'CONECTORES RJ-45 DE 8 HILOS', 1000, CAST(0.14 AS Decimal(18, 2)), N'GENERICO')
INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (2, NULL, N'CABLE UTP/CAT 6A 10GB 1000TF(305m) BLUE', 500, CAST(0.08 AS Decimal(18, 2)), N'GENERICO')
INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (1002, NULL, N'Salsa', 100, CAST(36.50 AS Decimal(18, 2)), N'Kenns')
INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (1003, NULL, N'Salsa Tomato', 100, CAST(36.50 AS Decimal(18, 2)), N'Kenns')
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [usuario], [contraseña]) VALUES (1, N'danny', N'123')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([IdVenta], [IdProducto], [Cantidad], [Total], [Fecha]) VALUES (1, 1, 2, 0.2800, CAST(N'2021-07-20T22:33:09.640' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [IdProducto], [Cantidad], [Total], [Fecha]) VALUES (2, 2, 2, 0.1600, CAST(N'2021-07-20T22:33:09.640' AS DateTime))
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[login]
(@usuario varchar(50),@contraseña varchar(50))
as
select usuario,contraseña from usuarios where usuario = @usuario and contraseña = @contraseña
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_login]
(@usuario varchar(50),@contraseña varchar(50))
as
select usuario,contraseña from usuarios where usuario = @usuario and contraseña = @contraseña
GO
/****** Object:  StoredProcedure [dbo].[Sp_OperacionProductos]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_OperacionProductos]
(
@Operacion VARCHAR(2),
@IdProducto INT NULL,
@NombreProducto VARCHAR(100),
@Cantidad INT,
@PrecioUnitario DECIMAL(18,2),
@Marca VARCHAR(50)
--@Message VARCHAR(250) NULL OUTPUT
)
AS
BEGIN
	IF (@Operacion = 'S')
	BEGIN
		SELECT * FROM Producto;
	END
	ELSE IF (@Operacion = 'I')
	BEGIN
		IF	NOT EXISTS(SELECT IdProducto FROM Producto WHERE IdProducto = @IdProducto )
			INSERT INTO Producto VALUES (@NombreProducto, @Cantidad, @PrecioUnitario, @Marca)
		--ELSE
		--	SELECT @Message = 'El IdProducto Ingresado YA Existe.'		
	END
	ELSE IF (@Operacion = 'U')
	BEGIN
		IF	EXISTS(SELECT IdProducto FROM Producto WHERE IdProducto = @IdProducto )
			UPDATE Producto SET NombreProducto = @NombreProducto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Marca = @Marca WHERE IdProducto = @IdProducto;
		--ELSE 
		--	SELECT @Message = 'El IdProducto Ingresado no Existe.'
	END	
	ELSE IF (@Operacion = 'D')
	BEGIN
		IF	EXISTS(SELECT IdProducto FROM Producto WHERE IdProducto = @IdProducto )
			DELETE FROM Producto	WHERE IdProducto = @IdProducto
		--ELSE	
		--	SELECT @Message = 'El IdProducto Ingresado no Existe.'
	END
	ELSE IF (@Operacion = 'BP')
	BEGIN
		--DECLARE @NombreProducto VARCHAR(50) = 'BLUE'
		SELECT * FROM Producto where NombreProducto LIKE '%'+@NombreProducto+'%';
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_OperacionVentas]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_OperacionVentas]
(
@Operacion VARCHAR(2),
@IdVenta INT NULL,
@IdProducto INT,
@Cantidad INT,
@Total MONEY,
@Fecha DATETIME--,
--@Message VARCHAR(250) NULL OUTPUT
)
AS
BEGIN
	IF (@Operacion = 'S')
	BEGIN
		SELECT * FROM Venta;
	END
	ELSE IF (@Operacion = 'I')
	BEGIN
		IF	EXISTS(SELECT IdProducto FROM Producto WHERE IdProducto = @IdProducto )
			INSERT INTO Venta VALUES (@IdProducto, @Cantidad, @Total, @Fecha)
		--ELSE
		--	SELECT @Message = 'El IdProducto Ingresado no Existe.'
	END
	ELSE IF (@Operacion = 'U')
	BEGIN
		IF	EXISTS(SELECT IdProducto FROM Producto WHERE IdProducto = @IdProducto )
			UPDATE Venta SET IdProducto = @IdProducto, Cantidad = @Cantidad, Total = @Total, Fecha = @Fecha	WHERE IdVenta = @IdVenta
		--ELSE
		--	SELECT @Message = 'El IdProducto Ingresado no Existe.'
	END
	ELSE IF (@Operacion = 'D')
		IF	EXISTS(SELECT IdVenta FROM Venta WHERE IdVenta = @IdVenta )
			DELETE FROM Venta	WHERE IdVenta = @IdVenta
		--ELSE
		--	SELECT @Message = 'El IdVenta Ingresado no Existe.'
END
GO
/****** Object:  StoredProcedure [dbo].[SpActualizarProductos]    Script Date: 22/7/2021 16:52:21 ******/
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
/****** Object:  StoredProcedure [dbo].[SpBuscarProducto]    Script Date: 22/7/2021 16:52:21 ******/
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
/****** Object:  StoredProcedure [dbo].[SpInsertarProductos]    Script Date: 22/7/2021 16:52:21 ******/
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
/****** Object:  StoredProcedure [dbo].[SpMostrarProductos]    Script Date: 22/7/2021 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpMostrarProductos]
AS 
SELECT * FROM Producto
GO
USE [master]
GO
ALTER DATABASE [TechSolutions] SET  READ_WRITE 
GO
