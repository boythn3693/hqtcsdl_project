USE [QuanLyLaiXe]
GO
------------------------
--- T1: CAP NHAT THONG TIN TO ------
------------------------

--- T1----
--DROP PROCEDURE GT_FIX_CAPNHATTHONGTIN_TO
CREATE PROC GT_FIX_CAPNHATTHONGTIN_TO
	@MaTo INT,
	@NgayNhanChuc datetime
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL REPEATABLE READ
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM TOLAI WHERE MaTo=@MaTo)
		BEGIN 
			PRINT N'MA TO KHONG DUNG'
			ROLLBACK TRAN
			RETURN
		END
		
		SELECT * FROM TOLAI
	
		--ĐỂ TEST		WAITFOR DELAY '0:0:10'
		
		UPDATE TOLAI 
		SET NgayNhanChuc=@NgayNhanChuc
		WHERE MaTo=@MaTo
				
	END TRY	BEGIN CATCH		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN	END CATCH
COMMIT TRAN
RETURN 0
