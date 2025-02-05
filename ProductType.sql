/*
   18 июня 2024 г.13:17:41
   Пользователь: 
   Сервер: DESKTOP-93G6P48\USEFUL
   База данных: Shop
   Приложение: 
*/

/* Чтобы предотвратить возможность потери данных, необходимо внимательно просмотреть этот скрипт, прежде чем запускать его вне контекста конструктора баз данных.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ProductCategory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.ProductType
	(
	TypeID int NOT NULL identity(1,1),
	TypeName varchar(50) NOT NULL unique,
	CategoryID int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.ProductType ADD CONSTRAINT
	PK_ProductType PRIMARY KEY CLUSTERED 
	(
	TypeID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

ALTER TABLE dbo.ProductType ADD CONSTRAINT
	FK_ProductType_ProductCategory FOREIGN KEY
	(
	CategoryID
	) REFERENCES dbo.ProductCategory
	(
	CategoryID
	) ON UPDATE  CASCADE
	
GO
ALTER TABLE dbo.ProductType SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
