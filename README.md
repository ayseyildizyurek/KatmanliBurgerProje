# KatmanliBurgerProje

Database Script Kodları:

USE [KatmanliBurgerDb]
GO
SET IDENTITY_INSERT [dbo].[Burgers] ON 

INSERT [dbo].[Burgers] ([Id], [Name], [Description], [Price], [Image], [Piece], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, N'Bigking', N'Hamburger eti (dana), 3,75'''' ekmek, 1 dilim peynir, turşu, Big King sosu, göbek salata, ', CAST(150.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\f2.png', 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Burgers] ([Id], [Name], [Description], [Price], [Image], [Piece], [CreatedDate], [UpdatedDate], [Status]) VALUES (3, N'King Chicken', N'King Chicken® tavuk eti, 4,25'''' ekmek, mayonez, göbek salata', CAST(100.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\f7.png', 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Burgers] ([Id], [Name], [Description], [Price], [Image], [Piece], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, N'Chicken Royale', N'Chicken Royale® eti, 7'''' ekmek, mayonez, göbek salata', CAST(120.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\f8.png', 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Burgers] ([Id], [Name], [Description], [Price], [Image], [Piece], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, N'Plant Based Royal', N'Sebze proteininden oluşan Planty Whopper®, 5'''' ekmek, turşu, ketçap, mayonez, göbek salata, domates, soğan', CAST(130.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\f9.png', 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[Burgers] OFF
GO
SET IDENTITY_INSERT [dbo].[Garnitures] ON 

INSERT [dbo].[Garnitures] ([Id], [Name], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, N'Turşu', CAST(N'2023-11-17T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Garnitures] ([Id], [Name], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, N'Marul', CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Garnitures] ([Id], [Name], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, N'Domates', CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Garnitures] ([Id], [Name], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, N'Ketçap', CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Garnitures] ([Id], [Name], [CreatedDate], [UpdatedDate], [Status]) VALUES (6, N'Mayonez', CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Garnitures] ([Id], [Name], [CreatedDate], [UpdatedDate], [Status]) VALUES (7, N'Soğan', CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Garnitures] ([Id], [Name], [CreatedDate], [UpdatedDate], [Status]) VALUES (8, N'Çedar Peyniri', CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[Garnitures] OFF
GO
SET IDENTITY_INSERT [dbo].[BurgerGarnitures] ON 

INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, 1, 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, 1, 2, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, 1, 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (6, 3, 5, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (7, 3, 6, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (8, 3, 7, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (9, 4, 8, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (10, 4, 5, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (11, 4, 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (12, 5, 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (13, 5, 2, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (14, 5, 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerGarnitures] ([Id], [BurgerId], [GarnitureId], [CreatedDate], [UpdatedDate], [Status]) VALUES (15, 5, 5, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[BurgerGarnitures] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name], [Description], [Price], [Image], [Piece], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, N'Bigking Menü', N'Bigking Menü', CAST(200.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\rwm1.png', 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[Menus] ([Id], [Name], [Description], [Price], [Image], [Piece], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, N'King Chicken Menü', N'King Chicken Menü', CAST(250.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\tb1.png', 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[BurgerMenus] ON 

INSERT [dbo].[BurgerMenus] ([Id], [BurgerId], [MenuId], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, 1, 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[BurgerMenus] ([Id], [BurgerId], [MenuId], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, 3, 2, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[BurgerMenus] OFF
GO
SET IDENTITY_INSERT [dbo].[ByProducts] ON 

INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, N'Parmak Patates', CAST(30.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\f5.png', 1, N'Parmak Dilim Patates', 1, 2, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, N'Elma Dilim Patates', CAST(30.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\f5.png', 1, N'Elma Dilim Patates', 1, 2, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (3, N'Soğan Halkası', CAST(35.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\s1.png', 1, N'Soğan Halkası', 1, 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, N'Karışık Atıştırma', CAST(80.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\k1.png', 1, N'Karışık Atıştırma', 1, 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (6, N'Fuse Tea', CAST(15.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\fu1.png', 1, N'Soğuk İçecek                               ', 1, 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (7, N'Kola/Fanta/Sprite', CAST(80.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\cf1.png', 1, N'Soğuk İçecek', 1, 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (8, N'Sufle', CAST(50.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\su1.png', 1, N'Tatlı', 1, 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (9, N'Limonlu Cheese Cake', CAST(55.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\lc1.png', 1, N'Tatlı', 1, 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ByProducts] ([Id], [Name], [Price], [Image], [Piece], [Description], [Size], [CategoryId], [CreatedDate], [UpdatedDate], [Status]) VALUES (10, N'Çikolatalı Kubbe', CAST(80.00 AS Decimal(18, 2)), N'\feane-1.0.0\images\cc1.png', 1, N'Tatlı', 1, 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[ByProducts] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuByProducts] ON 

INSERT [dbo].[MenuByProducts] ([Id], [MenuId], [ByProductId], [CreatedDate], [UpdatedDate], [Status]) VALUES (1, 1, 1, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[MenuByProducts] ([Id], [MenuId], [ByProductId], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, 1, 6, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[MenuByProducts] ([Id], [MenuId], [ByProductId], [CreatedDate], [UpdatedDate], [Status]) VALUES (3, 1, 8, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[MenuByProducts] ([Id], [MenuId], [ByProductId], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, 2, 2, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[MenuByProducts] ([Id], [MenuId], [ByProductId], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, 2, 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[MenuByProducts] ([Id], [MenuId], [ByProductId], [CreatedDate], [UpdatedDate], [Status]) VALUES (6, 2, 9, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[MenuByProducts] OFF
GO
SET IDENTITY_INSERT [dbo].[ParameterDetails] ON 

INSERT [dbo].[ParameterDetails] ([Id], [Code], [Description], [ParameterTypeId], [CreatedDate], [UpdatedDate], [Status]) VALUES (2, N'Kayit_Basarisiz', N'Kayıt esnasında bir hata oluştu', 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ParameterDetails] ([Id], [Code], [Description], [ParameterTypeId], [CreatedDate], [UpdatedDate], [Status]) VALUES (3, N'Genel_Hata', N'Bir hata oluştu, tekrar deneyiniz', 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ParameterDetails] ([Id], [Code], [Description], [ParameterTypeId], [CreatedDate], [UpdatedDate], [Status]) VALUES (4, N'Guncelleme_Basarisiz', N'Güncelleme esnasında bir hata oluştu', 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ParameterDetails] ([Id], [Code], [Description], [ParameterTypeId], [CreatedDate], [UpdatedDate], [Status]) VALUES (5, N'Silme_Basarisiz', N'Silme esnasında bir hata oluştu', 4, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ParameterDetails] ([Id], [Code], [Description], [ParameterTypeId], [CreatedDate], [UpdatedDate], [Status]) VALUES (7, N'Slider_Aciklama1', N'Fifty Shades Of Error List! ekibinin çabalarıyla kısa sürede oluşturulan MVC projesinde çok büyük emekler vardır. Emeği geçen herkese teşekkürler.', 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ParameterDetails] ([Id], [Code], [Description], [ParameterTypeId], [CreatedDate], [UpdatedDate], [Status]) VALUES (8, N'Slider_Aciklama2', N'Diyet yapmaktan korkanların kaçmak isteyeceği adres. Burada çok farklı lezzetler(!) tadacaksınız. Ürünlerimiz son derece sağlıklı olup yüksek miktarda kalori içermektedir. Uzun süre maruz kalındığında bağımlılık etkisi yapacaktır.', 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
INSERT [dbo].[ParameterDetails] ([Id], [Code], [Description], [ParameterTypeId], [CreatedDate], [UpdatedDate], [Status]) VALUES (9, N'Slider_Aciklama3', N'Projede Katmanlı Yapı Mimarisi kullanılmıştır. Clean Code Prensiplerine önem verilmiştir. Kısa zamanda hazırlanan bu projeyi yeterince incelerseniz MVC yapısını tamamen çözeceksiniz ;)', 3, CAST(N'2023-11-19T00:00:00.0000000' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[ParameterDetails] OFF
GO
