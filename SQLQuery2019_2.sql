USE [Master]
GO
CREATE DATABASE [Sales]
GO
USE [Sales]
GO
CREATE TABLE [dbo].[Product]
( 
[ProductId] [uniqueidentifier] DEFAULT NEWID() NOT NULL,
[ProductName] [nchar](50) NULL,
[ProductDescription] [nchar](3000) NULL,
[ProductPrice] MONEY NULL
) ON [PRIMARY]
GO

USE [Sales]
GO
 BEGIN
 TRUNCATE TABLE [Sales].[dbo].[Product]
 DECLARE @Record INT
 SET @Record=1
 WHILE (1=1)
 BEGIN
 INSERT INTO [Sales].[dbo].[Product]
 ([ProductName] ,[ProductDescription],[ProductPrice])
 VALUES ('Product ' + STR(@Record), 'Description ' + STR(@Record), @Record*100/3)
 SET @RECORD = @RECORD+1
 END
END

SELECT CURRENT_TIMESTAMP;
SELECT * from Product
SELECT CURRENT_TIMESTAMP

Tid før index		= 4
Tid efter index		= 2
