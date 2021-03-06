CREATE DATABASE TechSolutions
GO
USE [TechSolutions]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 25/7/2021 5:04:49 p. m. ******/
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
/****** Object:  Table [dbo].[roles]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[IdRol] [int] NOT NULL,
	[DescripcionRol] [varchar](100) NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuario] [varchar](100) NULL,
	[contraseña] [varchar](250) NULL,
	[IdRol] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] NOT NULL,
	[NombreCliente] [varchar](100) NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[SubTotal] [money] NULL,
	[Descuento] [decimal](18, 0) NULL,
	[IVA] [decimal](18, 2) NULL,
	[Total] [money] NULL,
	[Fecha] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (1, N'M-0231', N'', 21, CAST(2.00 AS Decimal(18, 2)), N'')
INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (2, N'M-0002', N'Switch de 40 puertos', 6785, CAST(232.00 AS Decimal(18, 2)), N'CISCO')
INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (5, N'M-0454', N'producto', 10, CAST(10.00 AS Decimal(18, 2)), N'hjhghfghfgh')
INSERT [dbo].[Producto] ([IdProducto], [CodProducto], [NombreProducto], [Cantidad], [PrecioUnitario], [Marca]) VALUES (6, N'M-01212', N'jhjk', 45, CAST(12.00 AS Decimal(18, 2)), N'dfgdgf')
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
INSERT [dbo].[roles] ([IdRol], [DescripcionRol]) VALUES (1, N'Administrador')
INSERT [dbo].[roles] ([IdRol], [DescripcionRol]) VALUES (2, N'Vendedor')
GO
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'danny', N'123', 1)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'JAMBLEX', N'Nicaragua009', 2)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'', N'hola12P34*', NULL)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'sdf', N'sS5*144444', 1)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'sfsadfasdf', N'a1f+asSD*s', 1)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'sdsdjjksdhkjs', N'44444a*aaVVV', 1)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'qweqweewrtrt', N'ddddddKJ@HH545', 1)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'asdsadsa', N'saasassasasa@AA444sasa', 2)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'KRAUSER', N'Nicaragua009+*', 1)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'hgjhhggh', N'1111hh/Shhhhh', NULL)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'dsfasdfasdf', N'asdfasdfasdf12*SDD', 1)
INSERT [dbo].[usuarios] ([usuario], [contraseña], [IdRol]) VALUES (N'SDFASDFASD', N'ASF*A1SDsFDF', NULL)
GO
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (1, N'Danny Caliz Machete', 1, 100, 3650.0000, CAST(0 AS Decimal(18, 0)), CAST(548.00 AS Decimal(18, 2)), 4197.5000, CAST(N'2021-07-24T13:15:05.120' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (2, N'José Krauser Martinez', 2, 1, 232.0000, CAST(0 AS Decimal(18, 0)), CAST(35.00 AS Decimal(18, 2)), 266.8000, CAST(N'2021-07-24T13:33:12.560' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (3, N'Perla Jiron Mendoza', 2, 499, 7300.0000, CAST(0 AS Decimal(18, 0)), CAST(0.00 AS Decimal(18, 2)), 7300.0000, CAST(N'2021-07-24T16:58:47.990' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (4, N'Perla Jiron Mendoza', 1, 200, 7300.0000, CAST(0 AS Decimal(18, 0)), CAST(0.00 AS Decimal(18, 2)), 7300.0000, CAST(N'2021-07-24T16:58:47.993' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (5, N'Jeffrey Jiron Mendoza', 2, 500, 116000.0000, CAST(20880 AS Decimal(18, 0)), CAST(14268.00 AS Decimal(18, 2)), 109388.0000, CAST(N'2021-07-24T20:38:44.447' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (12, N'dfgsdfgsd', 2, 10, 2320.0000, CAST(0 AS Decimal(18, 0)), CAST(348.00 AS Decimal(18, 2)), 2668.0000, CAST(N'2021-07-25T04:36:39.373' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (6, N'danny', 2, 10, 2320.0000, CAST(0 AS Decimal(18, 0)), CAST(348.00 AS Decimal(18, 2)), 2668.0000, CAST(N'2021-07-25T04:19:01.743' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (7, N'danny', 2, 10, 2320.0000, CAST(0 AS Decimal(18, 0)), CAST(348.00 AS Decimal(18, 2)), 2668.0000, CAST(N'2021-07-25T04:19:16.893' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (8, N'danny', 2, 10, 2320.0000, CAST(0 AS Decimal(18, 0)), CAST(348.00 AS Decimal(18, 2)), 2668.0000, CAST(N'2021-07-25T04:19:17.813' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (9, N'danny', 2, 10, 2320.0000, CAST(0 AS Decimal(18, 0)), CAST(348.00 AS Decimal(18, 2)), 2668.0000, CAST(N'2021-07-25T04:19:18.330' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (10, N'da', 2, 60, 23200.0000, CAST(0 AS Decimal(18, 0)), CAST(3480.00 AS Decimal(18, 2)), 26680.0000, CAST(N'2021-07-25T04:26:27.443' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (11, N'da', 2, 100, 23200.0000, CAST(0 AS Decimal(18, 0)), CAST(3480.00 AS Decimal(18, 2)), 26680.0000, CAST(N'2021-07-25T04:26:27.450' AS DateTime))
INSERT [dbo].[Venta] ([IdVenta], [NombreCliente], [IdProducto], [Cantidad], [SubTotal], [Descuento], [IVA], [Total], [Fecha]) VALUES (13, N'dfd', 2, 5, 1160.0000, CAST(0 AS Decimal(18, 0)), CAST(174.00 AS Decimal(18, 2)), 1334.0000, CAST(N'2021-07-25T04:43:47.003' AS DateTime))
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles] FOREIGN KEY([IdRol])
REFERENCES [dbo].[roles] ([IdRol])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_roles]
GO
/****** Object:  StoredProcedure [dbo].[Sp_GrabarVenta]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_GrabarVenta]
@IdProducto INT,
@NombreCliente VARCHAR(250),
@Cantidad INT,
@SubTotal MONEY,
@Descuento DECIMAL,
@IVA DECIMAL,
@Total MONEY
AS
BEGIN
DECLARE @IdVenta INT, @Fecha DATETIME
    SELECT @IdVenta = ISNULL((MAX(IdVenta)),0)+1 FROM dbo.Venta;
	--SELECT @IdVenta


	INSERT INTO dbo.Venta
	(
	    IdVenta,
		NombreCliente,
	    IdProducto,
	    Cantidad,
	    SubTotal,
	    Descuento,
	    IVA,
	    Total,
	    Fecha
	)
	VALUES
	(   @IdVenta,        -- IdVenta - int
		@NombreCliente,
	    @IdProducto,        -- IdProducto - int
	    @Cantidad,        -- Cantidad - int
	    @SubTotal,     -- SubTotal - money
	    @Descuento,     -- Descuento - decimal(18, 0)
	    @IVA,     -- IVA - decimal(18, 2)
	    @Total,     -- Total - money
	    GETDATE() -- Fecha - datetime
	    )
	
	IF EXISTS(SELECT IdVenta FROM dbo.Venta WHERE IdVenta = @IdVenta)
	BEGIN
	    UPDATE dbo.Producto
		SET Cantidad = Cantidad - @Cantidad
		WHERE IdProducto = @IdProducto
	END
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_login]
(@usuario varchar(50),@contraseña varchar(50))
as
select usuario,contraseña from usuarios where usuario = @usuario and contraseña = @contraseña
GO
/****** Object:  StoredProcedure [dbo].[SpActualizarProductos]    Script Date: 25/7/2021 5:04:49 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SpBuscarProducto]    Script Date: 25/7/2021 5:04:49 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SpCargarComboRol]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpCargarComboRol]
AS
SELECT DescripcionRol FROM dbo.roles
GO
/****** Object:  StoredProcedure [dbo].[SpEliminarProducto]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpEliminarProducto]
(
@IdProducto INT
)
AS
BEGIN
	DELETE FROM dbo.Producto WHERE IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SpInsertarProductos]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpInsertarProductos]
(
@CodProducto VARCHAR(10) NULL,
@NombreProducto VARCHAR(100),
@Cantidad INT,
@PrecioUnitario DECIMAL(18,2),
@Marca VARCHAR(50)
)
AS
BEGIN 
	INSERT INTO Producto (CodProducto,NombreProducto,Cantidad,PrecioUnitario,Marca) VALUES ('M-0'+@CodProducto,@NombreProducto,@Cantidad, @PrecioUnitario, @Marca);
END
GO
/****** Object:  StoredProcedure [dbo].[SpMostrarProductos]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpMostrarProductos]
AS 
SELECT * FROM Producto
GO
/****** Object:  StoredProcedure [dbo].[SpRegistrarUsuario]    Script Date: 25/7/2021 5:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpRegistrarUsuario]
@Usuario VARCHAR(100),
@Contraseña VARCHAR(250),
@NombreRol VARCHAR(150)
AS
BEGIN
DECLARE @IdRol INT
SELECT @IdRol = IdRol FROM dbo.roles WHERE DescripcionRol = @NombreRol
 IF NOT EXISTS(SELECT usuario FROM dbo.usuarios WHERE usuario = @Usuario)
 BEGIN
     INSERT INTO dbo.usuarios
    (
        usuario,
        contraseña,
		IdRol
    )
    VALUES
    (   
		@Usuario, -- usuario - varchar(100)
        @Contraseña,  -- contraseña - varchar(250)
		@IdRol --idrol - int
    )
 END 
END
GO
