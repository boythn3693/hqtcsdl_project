USE [QuanLyLaiXe]
GO

----T1------
DECLARE @slto FLOAT
------------------
EXEC GT_XemDanhSachTo @slto OUT
PRINT N'So luong to:' + ISNULL(CAST(@slto AS varchar(50)),'')
------------------


DECLARE @slto1 FLOAT
------------------
EXEC GT_Fix_XemDanhSachTo @slto1 OUT
PRINT N'So luong to:' + ISNULL(CAST(@slto1 AS varchar(50)),'')
------------------