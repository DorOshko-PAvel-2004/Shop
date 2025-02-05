/*
   18 июня 2024 г.17:06:26
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
CREATE TABLE dbo.ShipmentProduct
	(
	ShipmentID int NOT NULL,
	ProductID int NOT NULL,
	Count int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.ShipmentProduct ADD CONSTRAINT
	DF_ShipmentProduct_Count DEFAULT 0 FOR Count
GO
ALTER TABLE dbo.ShipmentProduct ADD CONSTRAINT
	PK_ShipmentProduct PRIMARY KEY CLUSTERED 
	(
	ProductID, ShipmentID
	) --WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
	ON [PRIMARY]

GO
ALTER TABLE dbo.ShipmentProduct ADD CONSTRAINT
	FK_ShipmentProduct_Product FOREIGN KEY
	(
	ProductID
	) REFERENCES dbo.Product
	(
	ProductID
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ShipmentProduct ADD CONSTRAINT
	FK_ShipmentProduct_Shipment FOREIGN KEY
	(
	ShipmentID
	) REFERENCES dbo.Shipment
	(
	ShipmentID
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ShipmentProduct SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
