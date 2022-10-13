USE [2022-2C-Enciclopedia-Darwin]
GO
INSERT [dbo].[TipoEspecie] ([IdTipoEspecie], [Nombre]) VALUES (1, N'Carnivoro')
GO
INSERT [dbo].[TipoEspecie] ([IdTipoEspecie], [Nombre]) VALUES (2, N'Herbivoro')
GO
SET IDENTITY_INSERT [dbo].[Especie] ON 
GO
INSERT [dbo].[Especie] ([IdEspecie], [Nombre], [PesoPromedioKg], [EdadPromedioAños], [IdTipoEspecie]) VALUES (1, N'Tortuga Marina', CAST(2.00 AS Decimal(18, 2)), 20, 2)
GO
INSERT [dbo].[Especie] ([IdEspecie], [Nombre], [PesoPromedioKg], [EdadPromedioAños], [IdTipoEspecie]) VALUES (2, N'Leon', CAST(300.00 AS Decimal(18, 2)), 14, 1)
GO
SET IDENTITY_INSERT [dbo].[Especie] OFF
GO
