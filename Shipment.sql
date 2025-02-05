/*
   18 июня 2024 г.17:02:05
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
CREATE TABLE dbo.Shipment
	(
	ShipmentID int NOT NULL,
	StartDate datetime NOT NULL,
	EndDate datetime NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Shipment ADD CONSTRAINT
	PK_Shipment PRIMARY KEY CLUSTERED 
	(
	ShipmentID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Shipment SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
