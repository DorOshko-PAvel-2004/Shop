/*
   20 июня 2024 г.14:13:16
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
CREATE TABLE dbo.ProductStatus
	(
	StatusID int NOT NULL primary key identity(1,1),
	StatusName nvarchar(50) NOT NULL unique
	)  ON [PRIMARY]
GO
GO
ALTER TABLE dbo.ProductStatus SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
