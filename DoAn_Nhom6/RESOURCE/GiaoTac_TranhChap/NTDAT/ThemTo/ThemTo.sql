USE [QuanLyLaiXe]
GO
------------------------
----- T1: THEM THONG TIN TO ------
----- T2: THEM THONG TIN TO ------
------------------------

--- T1----
--DROP PROCEDURE GT_XemDanhSachTo
CREATE PROC GT_XemDanhSachTo
AS
BEGIN TRAN
	BEGIN TRY
		
		
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		
		SELECT T.MaTo,T.TenTo,TX1.TenTaiXe,T.NgayNhanChuc,TX2.TenTaiXe
		FROM TOLAI T, TAIXE TX1, TAIXE TX2 
		WHERE T.ToTruong=TX1.MaTaiXe AND T.QuanLy=TX2.MaTaiXe
				
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
