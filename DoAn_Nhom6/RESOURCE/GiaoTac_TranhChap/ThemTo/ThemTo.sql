USE [QuanLyLaiXe]
GO
------------------------
----- T1: THEM THONG TIN TO ------
----- T2: THEM THONG TIN TO ------
------------------------

--- T1----
--DROP PROCEDURE GT_XemDanhSachTo
CREATE PROC GT_XemDanhSachTo
	@SLTO INT OUT
AS
BEGIN TRAN
	BEGIN TRY
		
		SET @SLTO = (SELECT COUNT(MaTo) FROM TOLAI)
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		
		SELECT * FROM TOLAI
				
	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCH
COMMIT TRAN
RETURN 0
GO

--- T2 -----
--DROP PROCEDURE GT_THEM_TO
CREATE PROC GT_THEM_TO
	@TenTo nvarchar(512),
	@ToTruong int,
	@NgayNhanChuc datetime,
	@QuanLy int
AS
BEGIN TRAN
	BEGIN TRY
		
		PRINT N'DA CHAY T2'
		
		INSERT TOLAI VALUES(@TenTo, @ToTruong, @NgayNhanChuc, @QuanLy)
		
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN
	END CATCH
COMMIT TRAN
RETURN 1
