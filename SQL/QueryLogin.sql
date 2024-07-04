USE [Shop]
GO

INSERT INTO [dbo].[UserData]
           ([Login]
           ,[Password]
           ,[RoleID])
     VALUES
           ('Antony'
           ,'123456'
           ,1),
		   ('admin','admin',2),
		   ('_secret_','-1',3)
GO


