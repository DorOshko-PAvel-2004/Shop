/*
   18 июня 2024 г.16:34:30
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
ALTER TABLE dbo.Company SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ProductType SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Product
	(
	ProductID int NOT NULL identity(1,1),
	Name nvarchar(50) NOT NULL unique,
	TypeID int NOT NULL,
	CompanyID int NOT NULL,
	Price float not null,
	StatusID int not null,
	[Image] image
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Product ADD CONSTRAINT
	PK_Product PRIMARY KEY CLUSTERED 
	(
	ProductID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Product ADD CONSTRAINT
	FK_Product_ProductType FOREIGN KEY
	(
	TypeID
	) REFERENCES dbo.ProductType
	(
	TypeID
	) ON UPDATE  Cascade 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Product ADD CONSTRAINT
	FK_Product_Company FOREIGN KEY
	(
	CompanyID
	) REFERENCES dbo.Company
	(
	CompanyID
	) ON UPDATE  Cascade 
	 ON DELETE  NO ACTION 

ALTER TABLE dbo.Product ADD CONSTRAINT
	FK_Product_ProductStatus FOREIGN KEY
	(
	StatusID
	) REFERENCES dbo.ProductStatus
	(
	StatusID
	) ON UPDATE  Cascade 
	 ON DELETE  NO ACTION	
GO
ALTER TABLE dbo.Product SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
