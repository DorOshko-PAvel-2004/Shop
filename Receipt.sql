/*
   18 июня 2024 г.18:13:51
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
CREATE TABLE dbo.Receipt
	(
	BuyID int NOT NULL primary key identity(1,1),
	[Login] nvarchar(50) NOT NULL,
	TotalAmount float(53) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Receipt ADD CONSTRAINT
	FK_Receipt_Login FOREIGN KEY
	(
	[Login]
	) REFERENCES dbo.UserData
	(
	[Login]
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO


ALTER TABLE dbo.Receipt ADD CONSTRAINT
	DF_Receipt_TotalAmount DEFAULT 0 FOR TotalAmount
GO
ALTER TABLE dbo.Receipt SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
