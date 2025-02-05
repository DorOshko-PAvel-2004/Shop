/*
   20 июня 2024 г.14:05:29
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
CREATE TABLE dbo.ReceiptProduct
	(
	ReceiptID int NOT NULL,
	ProductID int NOT NULL,
	Count int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.ReceiptProduct ADD CONSTRAINT
	DF_ReceiptProduct_Count DEFAULT 0 FOR Count
GO
ALTER TABLE dbo.ReceiptProduct ADD CONSTRAINT
	FK_ReceiptProduct_Product FOREIGN KEY
	(
	ProductID
	) REFERENCES dbo.Product
	(
	ProductID
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ReceiptProduct ADD CONSTRAINT
	FK_ReceiptProduct_Receipt FOREIGN KEY
	(
	ReceiptID
	) REFERENCES dbo.Receipt
	(
	ReceiptID
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	
ALTER TABLE dbo.ReceiptProduct ADD CONSTRAINT
	PK_ReceiptProduct PRIMARY KEY CLUSTERED 
	(
	ReceiptID,
	ProductID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
GO
ALTER TABLE dbo.ReceiptProduct SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
