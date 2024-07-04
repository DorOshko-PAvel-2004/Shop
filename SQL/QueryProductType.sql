USE [Shop]
GO

INSERT INTO [dbo].[ProductType]
           ([TypeName]
           ,[CategoryID])
     VALUES
           ('�������� �������',6), ('��������� �������',6), ('�������������',6),
		   ('������',7), ('�������������',7),
		   ('����',8), ('�������',8),
		   ('��������������',9), ('����',9), ('��������',9),
		   ('�������',10), ('����',10)
GO

select * from [dbo].[ProductType] join [dbo].[ProductCategory] 
on [ProductType].[CategoryID]=[ProductCategory].CategoryID;
