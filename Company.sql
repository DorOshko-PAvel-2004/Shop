/*
   18 июня 2024 г.13:49:15
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
CREATE TABLE dbo.Company
	(
	CompanyID int NOT NULL primary key identity(1,1),
	CompanyName nvarchar(50) NOT NULL unique
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.Company SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
