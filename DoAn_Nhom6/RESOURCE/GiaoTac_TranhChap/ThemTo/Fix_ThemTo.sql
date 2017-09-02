USE [QuanLyLaiXe]
GO
------------------------
----- T1: THEM THONG TIN TO ------
------------------------

--- T1----
--DROP PROCEDURE GT_Fix_XemDanhSachTo
CREATE PROC GT_Fix_XemDanhSachTo
	@SLTO INT OUT
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL Serializable
	BEGIN TRY
		
		SET @SLTO = (SELECT COUNT(MaTo) FROM TOLAI)		
		
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		
		SELECT * FROM TOLAI
				
	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCH
COMMIT TRAN
RETURN 0