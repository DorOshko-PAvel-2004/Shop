/*
   18 июня 2024 г.17:23:24
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
CREATE TABLE dbo.UserData
	(
	Login nvarchar(50) NOT NULL primary key,
	Password nvarchar(50) NOT NULL,
	RoleID nvarchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.UserData ADD CONSTRAINT
	DF_UserData_Role DEFAULT 0 FOR Role
GO

alter table dbo.UserData
add constraint FK_UserData_Role	foreign key (RoleID) references dbo.Role (RoleID)
go
ALTER TABLE dbo.UserData SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
