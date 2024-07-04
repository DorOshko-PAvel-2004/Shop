USE [Shop]
GO

INSERT INTO [dbo].[ProductType]
           ([TypeName]
           ,[CategoryID])
     VALUES
           ('Молочные напитки',6), ('Творожные изделия',6), ('Кисломолочные',6),
		   ('Мучное',7), ('Глазированные',7),
		   ('Хлеб',8), ('Булочки',8),
		   ('Безалкогольное',9), ('Вода',9), ('Алкоголь',9),
		   ('Колбасы',10), ('Мясо',10)
GO

select * from [dbo].[ProductType] join [dbo].[ProductCategory] 
on [ProductType].[CategoryID]=[ProductCategory].CategoryID;
