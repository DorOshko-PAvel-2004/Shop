USE [Shop]
GO

INSERT INTO [dbo].[Shipment]
           ([ShipmentID]
           ,[StartDate]
           ,[EndDate])
     VALUES
           (1
           ,convert(datetime,'2024-01-23',120), convert(datetime,'2024-02-01',120))
GO


