USE [master]
GO
/****** Object:  Database [2022-2C-Enciclopedia-Darwin]    Script Date: 10/12/2022 7:28:05 PM ******/
CREATE DATABASE [2022-2C-Enciclopedia-Darwin]
 
GO

USE [2022-2C-Enciclopedia-Darwin]
GO
/****** Object:  Table [dbo].[Especie]    Script Date: 10/12/2022 7:28:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especie](
	[IdEspecie] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[PesoPromedioKg] [decimal](18, 2) NULL,
	[EdadPromedioAños] [int] NULL,
	[IdTipoEspecie] [int] NOT NULL,
 CONSTRAINT [PK_Especie] PRIMARY KEY CLUSTERED 
(
	[IdEspecie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEspecie]    Script Date: 10/12/2022 7:28:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEspecie](
	[IdTipoEspecie] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoEspecie] PRIMARY KEY CLUSTERED 
(
	[IdTipoEspecie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Especie]  WITH CHECK ADD  CONSTRAINT [FK_Especie_TipoEspecie] FOREIGN KEY([IdTipoEspecie])
REFERENCES [dbo].[TipoEspecie] ([IdTipoEspecie])
GO
ALTER TABLE [dbo].[Especie] CHECK CONSTRAINT [FK_Especie_TipoEspecie]
